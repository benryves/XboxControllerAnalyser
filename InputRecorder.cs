using LibUsbDotNet;
using LibUsbDotNet.Info;
using LibUsbDotNet.Main;
using System.CodeDom;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Windows.Forms;

namespace BeeDevelopment.XboxControllerAnalyser {
	public partial class InputRecorder : Form {

		public UsbDevice? Device { get; set; }

		public InputRecorder() {
			InitializeComponent();
		}

		private void InputRecorder_Load(object sender, EventArgs e) {
			this.PopulateEndpointList();
		}

		bool formClosing = false; // flag set when closing.
		private void InputRecorder_FormClosing(object sender, FormClosingEventArgs e) {
			if (this.recorderWorker.IsBusy) {
				this.recorderWorker.CancelAsync();
				e.Cancel = true;
				formClosing = true;
			}
		}

		private void FileMenu_DropDownOpening(object sender, EventArgs e) {
			this.saveMenu.Enabled = this.recordedDataList.Items.Count > 0;
		}

		private void FileMenu_DropDownClosed(object sender, EventArgs e) {
			this.saveMenu.Enabled = true;
		}

		private void SaveMenu_Click(object sender, EventArgs e) {
			if (this.recordedDataList.Items.Count > 0 && this.saveFileDialog.ShowDialog(this) == DialogResult.OK) {
				try {
					File.WriteAllText(this.saveFileDialog.FileName, ConvertRecordedDataListToText());
				} catch (Exception ex) {
					MessageBox.Show(this, "Could not save file: " + ex.Message, Path.GetFileName(saveFileDialog.FileName), MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void ExitMenu_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void EditMenu_DropDownOpening(object sender, EventArgs e) {
			this.recordMenu.Enabled = this.recordButton.Enabled;
			this.recordMenu.Text = this.recordButton.Text;
			this.copyMenu.Enabled = this.recordedDataList.Items.Count > 0;
			this.clearMenu.Enabled = this.recordedDataList.Items.Count > 0;
		}

		private void EditMenu_DropDownClosed(object sender, EventArgs e) {
			this.recordMenu.Text = "Record/Stop";
			this.recordMenu.Enabled = true;
			this.copyMenu.Enabled = true;
			this.clearMenu.Enabled = true;
		}

		private void RecordMenu_Click(object sender, EventArgs e) {
			this.recordButton.PerformClick();
		}

		private void CopyMenu_Click(object sender, EventArgs e) {
			var text = ConvertRecordedDataListToText();
			if (!string.IsNullOrEmpty(text)) {
				Clipboard.SetText(text);
			}
		}

		private void ClearMenu_Click(object sender, EventArgs e) {
			this.recordedDataList.Items.Clear();
			this.recordedDataList.Groups.Clear();
		}

		private class EndpointListItem {

			[NotNull]
			public UsbEndpointInfo UsbEndpointInfo { get; set; }

			public EndpointListItem(UsbEndpointInfo usbEndpointInfo) {
				this.UsbEndpointInfo = usbEndpointInfo;
			}

			public override string ToString() {
				return string.Format("{0} {1} {2}",
					(UsbEndpointInfo.Descriptor.EndpointID & 0x80) == 0 ? "Write" : "Read",
					UsbEndpointInfo.Descriptor.DescriptorType.ToString(),
					UsbEndpointInfo.Descriptor.EndpointID & 0x7F
				);
			}
		}

		private void PopulateEndpointList() {
			this.endpointList.Items.Clear();
			this.endpointList.Enabled = false;
			if (this.Device != null) {
				foreach (var config in this.Device.Configs) {
					foreach (var interfaceInfo in config.InterfaceInfoList) {
						foreach (var endpointInfo in interfaceInfo.EndpointInfoList) {
							if ((endpointInfo.Descriptor.EndpointID & 0x80) != 0) { // only list read endpoints
								this.endpointList.Items.Add(new EndpointListItem(endpointInfo));
							}
						}
					}
				}
			}
			this.endpointList.SelectedIndex = this.endpointList.Items.Count > 0 ? 0 : -1;
			this.endpointList.Enabled = this.endpointList.Items.Count > 0;
		}

		private void RecordButton_Click(object sender, EventArgs e) {
			this.recordButton.Enabled = false;
			if (this.recorderWorker.IsBusy) {
				this.recorderWorker.CancelAsync();
			} else {
				this.recorderWorker.RunWorkerAsync();
			}
		}

		private void RecorderWorker_DoWork(object sender, DoWorkEventArgs e) {
			
			if (e.Cancel) {
				return;
			} else {
				this.recordButton.Invoke(() => {
					this.recordButton.Text = "Stop";
					this.recordButton.Enabled = true;
				});
				this.endpointList.Invoke(() => {
					this.endpointList.Enabled = false;
				});
			}

			// which endpoint are we reading?
			EndpointListItem? endpoint = null;
			this.endpointList.Invoke(() => {
				endpoint = this.endpointList.SelectedItem as EndpointListItem;
			});

			if (this.Device != null && endpoint != null) {

				using (var reader = this.Device.OpenEndpointReader((ReadEndpointID)endpoint.UsbEndpointInfo.Descriptor.EndpointID)) {

					var recordedData = new List<KeyValuePair<DateTime, byte[]>>(1024);

					while (!this.recorderWorker.CancellationPending) {
						var data = new byte[endpoint.UsbEndpointInfo.Descriptor.MaxPacketSize];
						switch (reader.Read(data, 100, out int dataLength)) {
							case ErrorCode.Success:
								// Got data!
								var capturedData = new byte[dataLength];
								Array.Copy(data, capturedData, dataLength);
								recordedData.Add(new KeyValuePair<DateTime, byte[]>(DateTime.Now, capturedData));
								break;
							case ErrorCode.IoTimedOut:
								// It's OK to time out, just means we don't have any data.
								break;
							default:
								// Error reading, so bail out.
								this.recorderWorker.CancelAsync();
								break;
						}
					}

					e.Result = recordedData;
				}
			}
		}

		private void RecorderWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			this.recordButton.Invoke(() => {
				this.recordButton.Text = "Record";
				this.recordButton.Enabled = true;
			});
			this.endpointList.Invoke(() => {
				this.endpointList.Enabled = this.endpointList.Items.Count > 0;
			});

			if (formClosing) {
				this.Close();
			} else {
				if (e.Result != null) {
					var recordedData = e.Result as List<KeyValuePair<DateTime, byte[]>>;
					if (recordedData != null) {
						if (recordedData.Count == 0) {
							MessageBox.Show(this, "No data was received.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
						} else {
							var firstEvent = recordedData[0].Key;
							var lastEvent = recordedData[^1].Key;
							var group = new ListViewGroup {
								Header = firstEvent.ToLongDateString() + " (" + firstEvent.ToLongTimeString() + (firstEvent != lastEvent ? ("-" + lastEvent.ToLongTimeString()) : "") + ")",
								Tag = recordedData,
							};
							this.recordedDataList.Groups.Add(group);

							Font monospaceFont = this.Font;
							MainInterface? mainForm = this.Owner as MainInterface;
							if (mainForm != null) {
								monospaceFont = mainForm.MonospaceFont;
							}

							foreach (var recordedDataPoint in recordedData) {
								var time = recordedDataPoint.Key - firstEvent;
								var item = new ListViewItem {
									Text = string.Format("{0:00}:{1:00}.{2:000}", time.TotalMinutes, time.Seconds, time.Milliseconds),
									Tag = recordedDataPoint,
									Group = group,
									UseItemStyleForSubItems = false,
								};
								this.recordedDataList.Items.Add(item);

								item.SubItems.Add(recordedDataPoint.Value.Length.ToString());

								var dataText = new StringBuilder(recordedDataPoint.Value.Length * 3);
								for (int i = 0; i < recordedDataPoint.Value.Length; ++i) {
									dataText.AppendFormat((i == 0 ? "" : " ") + "{0:X2}", recordedDataPoint.Value[i]);
								}
								item.SubItems.Add(new ListViewItem.ListViewSubItem {
									Text = dataText.ToString(),
									Font = monospaceFont,
								});
							}
						}
					}
				}
			}
		}

		

		private string ConvertRecordedDataListToText() {

			var result = new StringBuilder(1024);

			foreach (ListViewGroup group in this.recordedDataList.Groups) {
				result.AppendLine("========== " + group.ToString() + " ==========");
				result.AppendLine();
				foreach (ListViewItem item in group.Items) {
					result.Append((item.Text + ":").PadRight(10));
					if (item.SubItems.Count > 1) {
						result.Append(item.SubItems[1].Text.PadLeft(6));
						if (item.SubItems.Count > 2) {
							result.Append("    ");
							result.Append(item.SubItems[2].Text);
						}
					}
					result.AppendLine();
				}
				result.AppendLine();
			}

			return result.ToString();
		}
	}
}
