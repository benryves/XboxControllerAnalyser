using LibUsbDotNet;
using LibUsbDotNet.Descriptors;
using LibUsbDotNet.Info;
using LibUsbDotNet.LibUsb;
using LibUsbDotNet.Main;
using LibUsbDotNet.WinUsb;
using System.Runtime.InteropServices;
using System.Text;

namespace BeeDevelopment.XboxControllerAnalyser {
	public partial class MainInterface : Form {
		
		public MainInterface() {
			InitializeComponent();
			this.Text = Application.ProductName;
		}

		private void MainInterface_Load(object sender, EventArgs e) {
			this.RefreshDeviceList();
		}

		private void SaveMenu_Click(object sender, EventArgs e) {
			if (this.usbDeviceInfo.Items.Count > 0 && this.saveFileDialog.ShowDialog(this) == DialogResult.OK) {
				try {
					File.WriteAllText(this.saveFileDialog.FileName, ConvertUsbDeviceInfoToText());
				} catch (Exception ex){
					MessageBox.Show(this, "Could not save file: " + ex.Message, Path.GetFileName(saveFileDialog.FileName), MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void ExitMenu_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void CopyMenu_Click(object sender, EventArgs e) {
			if (this.usbDeviceInfo.Items.Count > 0) {
				Clipboard.SetText(ConvertUsbDeviceInfoToText());
			}
		}

		private void RefreshMenu_Click(object sender, EventArgs e) {
			this.RefreshDeviceList();
		}

		private void RefreshDeviceList() {

			// Remember the previously-selected node, just in case.
			var selectedNode = this.usbDeviceTree.SelectedNode;
			var previouslySelectedDevice = "";
			if (selectedNode != null) {
				if (selectedNode.Tag is LibUsbRegistry) {
					var reg = (LibUsbRegistry)selectedNode.Tag;
					previouslySelectedDevice = reg.SymbolicName;
				}
				if (selectedNode.Tag is WinUsbRegistry) {
					var reg = (WinUsbRegistry)selectedNode.Tag;
					previouslySelectedDevice = reg.SymbolicName;
				}
				selectedNode = null;
			}

			// Hide existing USB device info
			this.ClearUsbDeviceInfo();

			// Start from an empty tree
			this.usbDeviceTree.Nodes.Clear();

			// Add all libusb devices
			if (LibUsbDevice.AllLibUsbDevices.Count > 0) {
				var node = new TreeNode("libusb Devices");
				this.usbDeviceTree.Nodes.Add(node);
				foreach (LibUsbRegistry device in LibUsbDevice.AllLibUsbDevices) {
					node.Nodes.Add(new TreeNode {
						Tag = device,
						Text = device.Name,
					});
					if (device.SymbolicName == previouslySelectedDevice) {
						selectedNode = node.Nodes[node.Nodes.Count - 1];
					}
				}
			}

			// Add all WinUSB devices
			if (LibUsbDevice.AllWinUsbDevices.Count > 0) {
				var node = new TreeNode("WinUSB Devices");
				this.usbDeviceTree.Nodes.Add(node);
				foreach (WinUsbRegistry device in LibUsbDevice.AllWinUsbDevices) {
					node.Nodes.Add(new TreeNode {
						Tag = device,
						Text = device.Name,
					});
					if (device.SymbolicName == previouslySelectedDevice) {
						selectedNode = node.Nodes[node.Nodes.Count - 1];
					}
				}
			}

			// Show all expanded
			this.usbDeviceTree.ExpandAll();

			// Restore the previously-selected node.
			if (selectedNode != null) {
				this.usbDeviceTree.SelectedNode = selectedNode;
			}
		}

		private ListViewItem CreateUsbDeviceInfoListViewItem(string field, string value, string description = "", ListViewGroup? group = null) {
			if (group == null && this.usbDeviceInfo.Groups.Count > 0) {
				group = this.usbDeviceInfo.Groups[this.usbDeviceInfo.Groups.Count - 1];
			}
			var fieldItem = new ListViewItem {
				Text = field,
				Group = group,
			};
			fieldItem.SubItems.Add(value);
			if (description != "") {
				fieldItem.SubItems.Add(description);
			}
			return fieldItem;
		}

		private void ClearUsbDeviceInfo() {
			// Start from an empty data list
			this.usbDeviceInfo.Items.Clear();
			this.usbDeviceInfo.Groups.Clear();
		}

		private bool GetUsbDeviceControlTransferData(UsbDevice device, ref UsbSetupPacket setupPacket, out byte[] response) {
			
			response = new byte[setupPacket.Length];
			var handle = GCHandle.Alloc(response, GCHandleType.Pinned);
			bool success = false;
			
			try {
				int length;
				success = device.ControlTransfer(ref setupPacket, handle.AddrOfPinnedObject(), setupPacket.Length, out length) && length == response.Length;
			} finally {
				handle.Free();
			}

			return success;
		}

		private void ShowUsbDeviceInfo(UsbDevice device) {
			
			// Start from empty
			this.ClearUsbDeviceInfo();

			// Only show device info if it's open
			if (device.IsOpen) {

				this.usbDeviceInfo.Groups.Add(new ListViewGroup("Device Descriptor"));

				{
					UsbDeviceDescriptor descriptor = device.Info.Descriptor;
					this.usbDeviceInfo.Items.AddRange(new[]{
						CreateUsbDeviceInfoListViewItem("Length", "0x" + descriptor.Length.ToString("X2"), descriptor.Length.ToString() + " bytes"),
						CreateUsbDeviceInfoListViewItem("Descriptor Type", "0x" + ((int)descriptor.DescriptorType).ToString("X2"), descriptor.DescriptorType.ToString()),
						CreateUsbDeviceInfoListViewItem("BCD USB", "0x" + descriptor.BcdUsb.ToString("X4")),
						CreateUsbDeviceInfoListViewItem("Device Class", "0x" + ((int)descriptor.Class).ToString("X2"), descriptor.Class.ToString()),
						CreateUsbDeviceInfoListViewItem("Device Sub Class", "0x" + descriptor.SubClass.ToString("X2")),
						CreateUsbDeviceInfoListViewItem("Device Protocol", "0x" + descriptor.Protocol.ToString("X2")),
						CreateUsbDeviceInfoListViewItem("Max Packet Size 0", "0x" + descriptor.MaxPacketSize0.ToString("X2"), descriptor.MaxPacketSize0.ToString() + " bytes"),
						CreateUsbDeviceInfoListViewItem("Vendor ID", "0x" + descriptor.VendorID.ToString("X4")),
						CreateUsbDeviceInfoListViewItem("Product ID", "0x" + descriptor.ProductID.ToString("X4")),
						CreateUsbDeviceInfoListViewItem("BCD Device", "0x" + descriptor.BcdDevice.ToString("X4")),
						CreateUsbDeviceInfoListViewItem("Manufacturer Index", descriptor.ManufacturerStringIndex.ToString("X2"), device.Info.ManufacturerString),
						CreateUsbDeviceInfoListViewItem("Product Index", descriptor.ProductStringIndex.ToString("X2"), device.Info.ProductString),
						CreateUsbDeviceInfoListViewItem("Serial Number", descriptor.SerialStringIndex.ToString("X2"), device.Info.SerialString),
						CreateUsbDeviceInfoListViewItem("Configuration Count", descriptor.ConfigurationCount.ToString("X2")),
					});
				}

				foreach (UsbConfigInfo config in device.Configs) {

					this.usbDeviceInfo.Groups.Add(new ListViewGroup("Configuration Descriptor"));
					{
						UsbConfigDescriptor descriptor = config.Descriptor;
						this.usbDeviceInfo.Items.AddRange(new[]{
							CreateUsbDeviceInfoListViewItem("Length", "0x" + descriptor.Length.ToString("X2"), descriptor.Length.ToString() + " bytes"),
							CreateUsbDeviceInfoListViewItem("Descriptor Type", "0x" + ((int)descriptor.DescriptorType).ToString("X2"), descriptor.DescriptorType.ToString()),
							CreateUsbDeviceInfoListViewItem("Total Length", "0x" + descriptor.TotalLength.ToString("X4"), descriptor.TotalLength.ToString() + " bytes"),
							CreateUsbDeviceInfoListViewItem("Interface Count", "0x" + descriptor.InterfaceCount.ToString("X2")),
							CreateUsbDeviceInfoListViewItem("Configuration Value", "0x" + descriptor.ConfigID.ToString("X2")),
							CreateUsbDeviceInfoListViewItem("Configuration Index", "0x" + descriptor.StringIndex.ToString("X2")),
							CreateUsbDeviceInfoListViewItem("Attributes", "0x" + descriptor.Attributes.ToString("X2")),
							CreateUsbDeviceInfoListViewItem("Max Power", "0x" + descriptor.MaxPower.ToString("X2"), (descriptor.MaxPower * 2).ToString() + " mA"),
						});
					}

					foreach (UsbInterfaceInfo interfaceInfo in config.InterfaceInfoList) {
						this.usbDeviceInfo.Groups.Add(new ListViewGroup("Interface Descriptor"));
						{
							UsbInterfaceDescriptor descriptor = interfaceInfo.Descriptor;
							this.usbDeviceInfo.Items.AddRange(new[]{
								CreateUsbDeviceInfoListViewItem("Length", "0x" + descriptor.Length.ToString("X2"), descriptor.Length.ToString() + " bytes"),
								CreateUsbDeviceInfoListViewItem("Descriptor Type", "0x" + ((int) descriptor.DescriptorType).ToString("X2"), descriptor.DescriptorType.ToString()),
								CreateUsbDeviceInfoListViewItem("Interface Number", "0x" + descriptor.InterfaceID.ToString("X2")),
								CreateUsbDeviceInfoListViewItem("Alternate Setting", "0x" + descriptor.AlternateID.ToString("X2")),
								CreateUsbDeviceInfoListViewItem("Endpoint Count", "0x" + descriptor.EndpointCount.ToString("X2")),
								CreateUsbDeviceInfoListViewItem("Interface Class", "0x" + ((int)descriptor.Class).ToString("X2"), descriptor.Class.ToString()),
								CreateUsbDeviceInfoListViewItem("Interface Sub Class", "0x" + descriptor.SubClass.ToString("X2")),
								CreateUsbDeviceInfoListViewItem("Interface Protocol", "0x" + descriptor.Protocol.ToString("X2")),
								CreateUsbDeviceInfoListViewItem("Interface Index", "0x" + descriptor.StringIndex.ToString("X2")),
							});
						}

						foreach (UsbEndpointInfo endpointInfo in interfaceInfo.EndpointInfoList) {
							this.usbDeviceInfo.Groups.Add(new ListViewGroup("Endpoint Descriptor"));
							{
								UsbEndpointDescriptor descriptor = endpointInfo.Descriptor;
								this.usbDeviceInfo.Items.AddRange(new[]{
									CreateUsbDeviceInfoListViewItem("Length", "0x" + descriptor.Length.ToString("X2"), descriptor.Length.ToString() + " bytes"),
									CreateUsbDeviceInfoListViewItem("Descriptor Type", "0x" + ((int) descriptor.DescriptorType).ToString("X2"), descriptor.DescriptorType.ToString()),
									CreateUsbDeviceInfoListViewItem("Endpoint Address", "0x" +  descriptor.EndpointID.ToString("X2")),
									CreateUsbDeviceInfoListViewItem("Attributes", "0x" +  descriptor.Attributes.ToString("X2")),
									CreateUsbDeviceInfoListViewItem("Max Packet Size", "0x" +  descriptor.MaxPacketSize.ToString("X4"), descriptor.MaxPacketSize.ToString() + " bytes"),
									CreateUsbDeviceInfoListViewItem("Interval", "0x" +  descriptor.Interval.ToString("X2"), descriptor.Interval.ToString() + "ms"),
								});
							}
						}
					}
				}

				// GET_DESCRIPTOR
				short maxInputReportSize = 0;
				short maxOutputReportSize = 0;
				{
					UsbSetupPacket setupPacket = new UsbSetupPacket {
						RequestType = 0xC1,
						Request = 6,
						Value = 0x4200,
						Index = 0,
						Length = 16,
					};
					if (GetUsbDeviceControlTransferData(device, ref setupPacket, out byte[] response)) {
						this.usbDeviceInfo.Groups.Add(new ListViewGroup("XID Descriptor"));
						this.usbDeviceInfo.Items.AddRange(new[]{
							CreateUsbDeviceInfoListViewItem("Length", "0x" + response[0].ToString("X2"), response[0].ToString() + " bytes"),
							CreateUsbDeviceInfoListViewItem("Descriptor Type", "0x" + response[1].ToString("X2")),
							CreateUsbDeviceInfoListViewItem("BCD XID", "0x" + (response[2] | response[3] << 8).ToString("X4")),
							CreateUsbDeviceInfoListViewItem("Type", "0x" + response[4].ToString("X2")),
							CreateUsbDeviceInfoListViewItem("Sub Type", "0x" + response[5].ToString("X2")),
							CreateUsbDeviceInfoListViewItem("Max Input Report Size", "0x" + (maxInputReportSize = response[6]).ToString("X2"), response[6].ToString() + " bytes"),
							CreateUsbDeviceInfoListViewItem("Max Output Report Size", "0x" + (maxOutputReportSize = response[7]).ToString("X2"), response[7].ToString() + " bytes"),
						});
						for (int i = 0; i < 4; ++i) {
							this.usbDeviceInfo.Items.Add(CreateUsbDeviceInfoListViewItem("Alternate ID " + i.ToString(), "0x" + (response[8 + i * 2 + 0] | response[8 + i * 2 + 1] << 8).ToString("X4")));
						}
					}
				}

				// GET_CAPABILITIES
				for (int capabilityType = 0; capabilityType < 2; ++capabilityType) {

					var maxReportSize = new[] { maxInputReportSize, maxOutputReportSize }[capabilityType];

					if (maxReportSize > 0) {
						UsbSetupPacket setupPacket = new UsbSetupPacket {
							RequestType = 0xC1,
							Request = 1,
							Value = (short)(new[] { 0x0100, 0x0200 }[capabilityType]),
							Index = 0,
							Length = maxReportSize,
						};
						if (GetUsbDeviceControlTransferData(device, ref setupPacket, out byte[] response)) {
							this.usbDeviceInfo.Groups.Add(new ListViewGroup("XID " + new[] { "Input", "Output" }[capabilityType] + " Capabilities"));
							this.usbDeviceInfo.Items.AddRange(new[]{
							CreateUsbDeviceInfoListViewItem("Report ID", "0x" + response[0].ToString("X2")),
							CreateUsbDeviceInfoListViewItem("Length", "0x" + response[1].ToString("X2"), response[1].ToString() + " bytes"),
						});
							for (int i = 2; i < response[1]; i += 4) {
								var data = new List<string>();
								for (int j = 0; j < 4; ++j) {
									if (i + j < response[1]) {
										data.Add("0x" + response[i + j].ToString("X2"));
									}
								}
								this.usbDeviceInfo.Items.Add(CreateUsbDeviceInfoListViewItem("Capabilities [0x" + i.ToString("X2") + "~0x" + Math.Min(i + 4, response[1]).ToString("X2") + "]", string.Join(" ", data.ToArray())));
							}
						}
					}
				}
				
			}
		}

		private void UsbDeviceTree_AfterSelect(object sender, TreeViewEventArgs e) {
			this.ClearUsbDeviceInfo();
			if (e.Node != null && e.Node.IsSelected) {
				if (e.Node.Tag is LibUsbRegistry) {
					var reg = (LibUsbRegistry)e.Node.Tag;
					if (reg.Open(out LibUsbDevice device)) {
						this.ShowUsbDeviceInfo(device);
						device.Close();
					} else {
						MessageBox.Show(this, "Could not open libusb device '" + e.Node.Text + "'.", e.Node.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				if (e.Node.Tag is WinUsbRegistry) {
					var reg = (WinUsbRegistry)e.Node.Tag;
					if (reg.Open(out WinUsbDevice device)) {
						this.ShowUsbDeviceInfo(device);
						device.Close();
					} else {
						MessageBox.Show(this, "Could not open WinUSB device '"  + e.Node.Text + "'.", e.Node.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private string ConvertUsbDeviceInfoToText() {
			
			StringBuilder result = new StringBuilder(1024);

			foreach (ListViewGroup group in this.usbDeviceInfo.Groups) {
				result.AppendLine("========== " + group.ToString() + " ==========");
				result.AppendLine();
				foreach (ListViewItem item in group.Items) {
					result.Append((item.Text + ":").PadRight(26));
					if (item.SubItems.Count > 1) {
						result.Append(item.SubItems[1].Text.PadLeft(20));
						if (item.SubItems.Count > 2) {
							result.Append(" <- " + item.SubItems[2].Text);
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