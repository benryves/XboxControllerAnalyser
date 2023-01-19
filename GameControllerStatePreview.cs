using LibUsbDotNet;
using LibUsbDotNet.Main;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BeeDevelopment.XboxControllerAnalyser {
	public partial class GameControllerStatePreview : Form {

		public UsbDevice? Device { get; set; }
		public bool ShowUnusedFields { get; set; }

		private int numericDataBase = 10;
		public int NumericDataBase {
			get { return this.numericDataBase; }
			set {
				switch (value) {
					case 10:
						this.numericDataBase = value;
						this.decimalRadioButton.Checked = true;
						this.leftActuatorSpinner.Hexadecimal = false;
						this.rightActuatorSpinner.Hexadecimal = false;
						break;
					case 16:
						this.numericDataBase = value;
						this.hexadecimalRadioButton.Checked = true;
						this.leftActuatorSpinner.Hexadecimal = true;
						this.rightActuatorSpinner.Hexadecimal = true;
						break;
					default:
						throw new InvalidOperationException();
				}
			}
		}

		private void NumericDataBaseRadioButton_CheckedChanged(object sender, EventArgs e) {
			if (this.decimalRadioButton.Checked) {
				this.NumericDataBase = 10;
			} else if (this.hexadecimalRadioButton.Checked) {
				this.NumericDataBase = 16;
			}
		}

		private string ByteFormatString {
			get {
				switch (this.NumericDataBase) {
					case 16:
						return "0x{0:X2}";
					default:
						return "{0}";
				}
			}
		}

		private string UShortFormatString {
			get {
				switch (this.NumericDataBase) {
					case 16:
						return "0x{0:X4}";
					default:
						return "{0}";
				}
			}
		}

		private string ShortCoordinatesFormatString {
			get {
				switch (this.NumericDataBase) {
					case 16:
						return "(0x{0:X4},0x{1:X4})";
					default:
						return "({0,6:0},{1,6:0})";
				}
			}
		}

		[AllowNull] ListViewItem.ListViewSubItem dpad;
		[AllowNull] ListViewItem.ListViewSubItem start;
		[AllowNull] ListViewItem.ListViewSubItem back;
		[AllowNull] ListViewItem.ListViewSubItem leftStickButton;
		[AllowNull] ListViewItem.ListViewSubItem rightStickButton;

		[AllowNull] ListViewItem.ListViewSubItem lightGunLightVisible;
		[AllowNull] ListViewItem.ListViewSubItem lightGunUnknown1;
		[AllowNull] ListViewItem.ListViewSubItem lightGunUnknown2;

		[AllowNull] ListViewItem.ListViewSubItem a;
		[AllowNull] ListViewItem.ListViewSubItem b;
		[AllowNull] ListViewItem.ListViewSubItem x;
		[AllowNull] ListViewItem.ListViewSubItem y;
		[AllowNull] ListViewItem.ListViewSubItem black;
		[AllowNull] ListViewItem.ListViewSubItem white;
		[AllowNull] ListViewItem.ListViewSubItem leftTrigger;
		[AllowNull] ListViewItem.ListViewSubItem rightTrigger;

		[AllowNull] ListViewItem.ListViewSubItem leftStick;
		[AllowNull] ListViewItem.ListViewSubItem rightStick;

		private ListViewItem.ListViewSubItem CreateLivePreviewListViewItem(string field) {

			Font monospaceFont = this.Font;
			MainInterface? mainInterface = this.Owner as MainInterface;
			if (mainInterface != null) {
				monospaceFont = mainInterface.MonospaceFont;
			}

			var group = this.livePreviewFields.Groups[^1];

			var fieldItem = new ListViewItem {
				Text = field,
				Group = group,
				UseItemStyleForSubItems = false,
			};

			var subItem = new ListViewItem.ListViewSubItem {
				Tag = fieldItem,
				Font = monospaceFont,
			};

			fieldItem.SubItems.Add(subItem);

			this.livePreviewFields.Items.Add(fieldItem);

			return subItem;
		}

		private void AddAllPreviewFields() {
			this.livePreviewFields.Items.Clear();
			this.livePreviewFields.Groups.Clear();

			this.livePreviewFields.Groups.Add(new ListViewGroup("Digital Buttons"));
			this.dpad = this.CreateLivePreviewListViewItem("Direction Pad");
			this.start = this.CreateLivePreviewListViewItem("Start");
			this.back = this.CreateLivePreviewListViewItem("Back");
			this.leftStickButton = this.CreateLivePreviewListViewItem("Left Stick");
			this.rightStickButton = this.CreateLivePreviewListViewItem("Right Stick");

			this.livePreviewFields.Groups.Add(new ListViewGroup("Light Gun Flags"));
			this.lightGunLightVisible = this.CreateLivePreviewListViewItem("Light Visible");
			this.lightGunUnknown1 = this.CreateLivePreviewListViewItem("Unknown 1");
			this.lightGunUnknown2 = this.CreateLivePreviewListViewItem("Unknown 2");

			this.livePreviewFields.Groups.Add(new ListViewGroup("Analogue Buttons"));
			this.a = this.CreateLivePreviewListViewItem("A");
			this.b = this.CreateLivePreviewListViewItem("B");
			this.x = this.CreateLivePreviewListViewItem("X");
			this.y = this.CreateLivePreviewListViewItem("Y");
			this.black = this.CreateLivePreviewListViewItem("Black");
			this.white = this.CreateLivePreviewListViewItem("White");

			this.livePreviewFields.Groups.Add(new ListViewGroup("Triggers"));
			this.leftTrigger = this.CreateLivePreviewListViewItem("Left Trigger");
			this.rightTrigger = this.CreateLivePreviewListViewItem("Right Trigger");

			this.livePreviewFields.Groups.Add(new ListViewGroup("Analogue Sticks"));
			this.leftStick = this.CreateLivePreviewListViewItem("Left Stick");
			this.rightStick = this.CreateLivePreviewListViewItem("Right Stick");

			this.leftActuatorStrength.Enabled = this.leftActuatorLabel.Enabled = true;
			this.rightActuatorStrength.Enabled = this.rightActuatorLabel.Enabled = true;
		}

		private void RemoveUnusedPreviewFields() {
			// get capabilities to hide unused fields
			if (this.Device != null) {

				// descriptor
				{
					var setupPacket = new UsbSetupPacket {
						RequestType = 0xC1,
						Request = 6,
						Value = 0x4200,
						Index = 0,
						Length = 16,
					};

					var response = new byte[setupPacket.Length];
					var handle = GCHandle.Alloc(response, GCHandleType.Pinned);
					bool success = false;

					try {
						success = this.Device.ControlTransfer(ref setupPacket, handle.AddrOfPinnedObject(), setupPacket.Length, out int length) && length == response.Length;
					} finally {
						handle.Free();
					}

					if (success && response[4] == 0x01 && response[5] == 0x50) {
						this.lightGunCalibrationChanged = true;
					} else {
						this.lightGunCalibrationGroup.Enabled = false;
						this.lightGunCalibrationGroup.Visible = false;
						this.controlTable.RowStyles[1].Height = 0;
					}
				}

				// input
				{
					var setupPacket = new UsbSetupPacket {
						RequestType = 0xC1,
						Request = 1,
						Value = 0x0100,
						Index = 0,
						Length = 20,
					};

					var response = new byte[setupPacket.Length];
					var handle = GCHandle.Alloc(response, GCHandleType.Pinned);
					bool success = false;

					try {
						success = this.Device.ControlTransfer(ref setupPacket, handle.AddrOfPinnedObject(), setupPacket.Length, out int length) && length == response.Length;
					} finally {
						handle.Free();
					}

					if (success) {
						var state = new XboxInputDevice.GameControllerInputState(response);

						if ((state.DigitalButtons & (XboxInputDevice.GameControllerDigitalButtons.Up | XboxInputDevice.GameControllerDigitalButtons.Down | XboxInputDevice.GameControllerDigitalButtons.Left | XboxInputDevice.GameControllerDigitalButtons.Right)) == XboxInputDevice.GameControllerDigitalButtons.None) this.livePreviewFields.Items.Remove(this.dpad.Tag as ListViewItem);
						if ((state.DigitalButtons & XboxInputDevice.GameControllerDigitalButtons.Start) == XboxInputDevice.GameControllerDigitalButtons.None) this.livePreviewFields.Items.Remove(this.start.Tag as ListViewItem);
						if ((state.DigitalButtons & XboxInputDevice.GameControllerDigitalButtons.Back) == XboxInputDevice.GameControllerDigitalButtons.None) this.livePreviewFields.Items.Remove(this.back.Tag as ListViewItem);
						if ((state.DigitalButtons & XboxInputDevice.GameControllerDigitalButtons.LeftStick) == XboxInputDevice.GameControllerDigitalButtons.None) this.livePreviewFields.Items.Remove(this.leftStickButton.Tag as ListViewItem);
						if ((state.DigitalButtons & XboxInputDevice.GameControllerDigitalButtons.RightStick) == XboxInputDevice.GameControllerDigitalButtons.None) this.livePreviewFields.Items.Remove(this.rightStickButton.Tag as ListViewItem);

						if ((state.LightGunFlags & XboxInputDevice.GameControllerLightGunFlags.LightVisible) == XboxInputDevice.GameControllerLightGunFlags.None) this.livePreviewFields.Items.Remove(this.lightGunLightVisible.Tag as ListViewItem);
						if ((state.LightGunFlags & XboxInputDevice.GameControllerLightGunFlags.Unknown1) == XboxInputDevice.GameControllerLightGunFlags.None) this.livePreviewFields.Items.Remove(this.lightGunUnknown1.Tag as ListViewItem);
						if ((state.LightGunFlags & XboxInputDevice.GameControllerLightGunFlags.Unknown2) == XboxInputDevice.GameControllerLightGunFlags.None) this.livePreviewFields.Items.Remove(this.lightGunUnknown2.Tag as ListViewItem);

						if (state.A == 0) this.livePreviewFields.Items.Remove(this.a.Tag as ListViewItem);
						if (state.B == 0) this.livePreviewFields.Items.Remove(this.b.Tag as ListViewItem);
						if (state.X == 0) this.livePreviewFields.Items.Remove(this.x.Tag as ListViewItem);
						if (state.Y == 0) this.livePreviewFields.Items.Remove(this.y.Tag as ListViewItem);
						if (state.Black == 0) this.livePreviewFields.Items.Remove(this.black.Tag as ListViewItem);
						if (state.White == 0) this.livePreviewFields.Items.Remove(this.white.Tag as ListViewItem);

						if (state.LeftTrigger == 0) this.livePreviewFields.Items.Remove(this.leftTrigger.Tag as ListViewItem);
						if (state.RightTrigger == 0) this.livePreviewFields.Items.Remove(this.rightTrigger.Tag as ListViewItem);

						if (state.LeftStickX == 0 && state.LeftStickY == 0) this.livePreviewFields.Items.Remove(this.leftStick.Tag as ListViewItem);
						if (state.RightStickX == 0 && state.RightStickY == 0) this.livePreviewFields.Items.Remove(this.rightStick.Tag as ListViewItem);

					}
				}

				// output
				{
					var setupPacket = new UsbSetupPacket {
						RequestType = 0xC1,
						Request = 1,
						Value = 0x0200,
						Index = 0,
						Length = 6,
					};

					var response = new byte[setupPacket.Length];
					var handle = GCHandle.Alloc(response, GCHandleType.Pinned);
					bool success = false;

					try {
						success = this.Device.ControlTransfer(ref setupPacket, handle.AddrOfPinnedObject(), setupPacket.Length, out int length) && length == response.Length;
					} finally {
						handle.Free();
					}

					if (success) {
						var state = new XboxInputDevice.GameControllerOutputState(response);
						this.leftActuatorStrength.Enabled = this.leftActuatorLabel.Enabled = state.LeftActuatorStrength != 0;
						this.rightActuatorStrength.Enabled = this.rightActuatorLabel.Enabled = state.RightActuatorStrength != 0;
					} else {
						this.leftActuatorStrength.Enabled = this.leftActuatorLabel.Enabled = false;
						this.rightActuatorStrength.Enabled = this.rightActuatorLabel.Enabled = false;
					}
				}
			}
		}

		public GameControllerStatePreview() {
			InitializeComponent();
		}

		private void GameControllerStatePreview_Load(object sender, EventArgs e) {

			this.NumericDataBase = this.NumericDataBase;
			this.AddAllPreviewFields();

			// double-buffer list view
			var prop = typeof(ListView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			prop?.SetValue(this.livePreviewFields, true, null);

			if (this.ShowUnusedFields) {
				this.fieldVisibilityAll.Checked = true;
			} else {
				this.RemoveUnusedPreviewFields();
			}

			// poll the controller for its state
			if (this.Device != null && this.Device.IsOpen) {
				this.updateTimer.Start();
			}
		}

		private void GameControllerStatePreview_FormClosing(object sender, FormClosingEventArgs e) {
			this.updateTimer.Stop();

			if (this.Device != null) {

				// try to switch off the motors
				if (this.leftActuatorStrength.Enabled || this.rightActuatorStrength.Enabled) {

					var report = new XboxInputDevice.GameControllerOutputState {
						LeftActuatorStrength = 0,
						RightActuatorStrength = 0
					};

					var data = report.GetBytes();

					var setupPacket = new UsbSetupPacket {
						RequestType = 0x21,
						Request = 9,
						Value = 0x0200,
						Index = 0,
						Length = (short)data.Length,
					};

					var handle = GCHandle.Alloc(data, GCHandleType.Pinned);
					try {
						for (int i = 0; i < 10; ++i) {
							if (this.Device.ControlTransfer(ref setupPacket, handle.AddrOfPinnedObject(), setupPacket.Length, out int length) && length == data.Length) {
								break;
							}
							Thread.Sleep(100);
						}

					} finally {
						handle.Free();
					}
				}
			}
		}

		private void UpdateTimer_Tick(object sender, EventArgs e) {
			if (this.Device != null) {

				{

					// Calibrate light gun
					if (lightGunCalibrationChanged) {
						var setupPacket = new UsbSetupPacket {
							RequestType = 0x21,
							Request = 9,
							Value = 0x0201,
							Index = 0,
							Length = 10,
						};

						var report = new XboxInputDevice.GameControllerLightGunCalibrationState {
							CentreXOffset = (short)this.lightGunCalibrationCentreX.Value,
							CentreYOffset = (short)this.lightGunCalibrationCentreY.Value,
							TopLeftXOffset = (short)this.lightGunCalibrationTopLeftX.Value,
							TopLeftYOffset = (short)this.lightGunCalibrationTopLeftY.Value,
						};
						var data = report.GetBytes();

						var handle = GCHandle.Alloc(data, GCHandleType.Pinned);
						bool success = false;

						try {
							success = this.Device.ControlTransfer(ref setupPacket, handle.AddrOfPinnedObject(), setupPacket.Length, out int length) && length == data.Length;
						} finally {
							handle.Free();
						}

						if (success) {
							lightGunCalibrationChanged = false;
						} else {
							this.lightGunCalibrationGroup.Enabled = false;
						}
					}

					{
						// GET_REPORT
						var setupPacket = new UsbSetupPacket {
							RequestType = 0xA1,
							Request = 1,
							Value = 0x0100,
							Index = 0,
							Length = 20,
						};

						var response = new byte[setupPacket.Length];
						var handle = GCHandle.Alloc(response, GCHandleType.Pinned);
						bool success = false;

						try {
							success = this.Device.ControlTransfer(ref setupPacket, handle.AddrOfPinnedObject(), setupPacket.Length, out int length) && length == response.Length;
						} finally {
							handle.Free();
						}

						if (this.inputGroup.Enabled = success) {

							var state = new XboxInputDevice.GameControllerInputState(response);

							this.dpad.Text = (state.DigitalButtons & (XboxInputDevice.GameControllerDigitalButtons.Up | XboxInputDevice.GameControllerDigitalButtons.Down | XboxInputDevice.GameControllerDigitalButtons.Left | XboxInputDevice.GameControllerDigitalButtons.Right)).ToString();
							this.start.Text = ((state.DigitalButtons & XboxInputDevice.GameControllerDigitalButtons.Start) != XboxInputDevice.GameControllerDigitalButtons.None).ToString();
							this.back.Text = ((state.DigitalButtons & XboxInputDevice.GameControllerDigitalButtons.Back) != XboxInputDevice.GameControllerDigitalButtons.None).ToString();
							this.leftStickButton.Text = ((state.DigitalButtons & XboxInputDevice.GameControllerDigitalButtons.LeftStick) != XboxInputDevice.GameControllerDigitalButtons.None).ToString();
							this.rightStickButton.Text = ((state.DigitalButtons & XboxInputDevice.GameControllerDigitalButtons.RightStick) != XboxInputDevice.GameControllerDigitalButtons.None).ToString();

							this.lightGunLightVisible.Text = ((state.LightGunFlags & XboxInputDevice.GameControllerLightGunFlags.LightVisible) != XboxInputDevice.GameControllerLightGunFlags.None).ToString();
							this.lightGunUnknown1.Text = ((state.LightGunFlags & XboxInputDevice.GameControllerLightGunFlags.Unknown1) != XboxInputDevice.GameControllerLightGunFlags.None).ToString();
							this.lightGunUnknown2.Text = ((state.LightGunFlags & XboxInputDevice.GameControllerLightGunFlags.Unknown2) != XboxInputDevice.GameControllerLightGunFlags.None).ToString();

							this.a.Text = string.Format(ByteFormatString, state.A);
							this.b.Text = string.Format(ByteFormatString, state.B);
							this.x.Text = string.Format(ByteFormatString, state.X);
							this.y.Text = string.Format(ByteFormatString, state.Y);
							this.black.Text = string.Format(ByteFormatString, state.Black);
							this.white.Text = string.Format(ByteFormatString, state.White);

							this.leftTrigger.Text = string.Format(ByteFormatString, state.LeftTrigger);
							this.rightTrigger.Text = string.Format(ByteFormatString, state.RightTrigger);

							this.leftStick.Text = string.Format(ShortCoordinatesFormatString, state.LeftStickX, state.LeftStickY);
							this.rightStick.Text = string.Format(ShortCoordinatesFormatString, state.RightStickX, state.RightStickY);

							if (this.lightGunCalibrationGroup.Enabled && state.A > 127 && (state.LightGunFlags & XboxInputDevice.GameControllerLightGunFlags.LightVisible) != XboxInputDevice.GameControllerLightGunFlags.None) {
								if (this.lightGunCalibrateCentreCheckbox.Checked) {

									this.lightGunCalibrateCentreCheckbox.Checked = false;

									this.lightGunCalibrationCentreX.Value = Math.Max(short.MinValue, Math.Min(short.MaxValue, -state.LeftStickX + this.lightGunCalibrationCentreX.Value));
									this.lightGunCalibrationCentreY.Value = Math.Max(short.MinValue, Math.Min(short.MaxValue, -state.LeftStickY + this.lightGunCalibrationCentreY.Value));

									this.lightGunCalibrationChanged = true;
								}
								if (this.lightGunCalibrateTopLeftCheckbox.Checked) {
									this.lightGunCalibrateTopLeftCheckbox.Checked = false;

									this.lightGunCalibrationTopLeftX.Value = Math.Max(short.MinValue, Math.Min(short.MaxValue, -25000 - state.LeftStickX));
									this.lightGunCalibrationTopLeftY.Value = Math.Max(short.MinValue, Math.Min(short.MaxValue, +25000 - state.LeftStickY));

									this.lightGunCalibrationChanged = true;
								}
							}

						}
					}
				}

				if (this.leftActuatorStrength.Enabled || this.rightActuatorStrength.Enabled) {

					var report = new XboxInputDevice.GameControllerOutputState {
						LeftActuatorStrength = (ushort)this.leftActuatorStrength.Value,
						RightActuatorStrength = (ushort)this.rightActuatorStrength.Value
					};

					var data = report.GetBytes();

					var setupPacket = new UsbSetupPacket {
						RequestType = 0x21,
						Request = 9,
						Value = 0x0200,
						Index = 0,
						Length = (short)data.Length,
					};

					var handle = GCHandle.Alloc(data, GCHandleType.Pinned);

					try {
						this.forceFeedbackOutputGroup.Enabled = (this.Device.ControlTransfer(ref setupPacket, handle.AddrOfPinnedObject(), setupPacket.Length, out int length) && length == setupPacket.Length);
					} finally {
						handle.Free();
					}
				}

			}
		}

		private void FieldVisibility_CheckedChanged(object sender, EventArgs e) {
			var showUnusedFieldsChange = this.fieldVisibilityAll.Checked;
			if (this.ShowUnusedFields != showUnusedFieldsChange) {
				this.ShowUnusedFields = showUnusedFieldsChange;
				this.AddAllPreviewFields();
				if (!this.ShowUnusedFields) {
					this.RemoveUnusedPreviewFields();
				}
			}
		}

		bool lightGunCalibrationChanged = true;

		private void LightGunCalibrationTrackBar_Scroll(object sender, EventArgs e) {
			lightGunCalibrationChanged = true;
		}

		private void CalibrateCheckbox_CheckedChanged(object sender, EventArgs e) {
			var checkbox = sender as CheckBox;
			if (checkbox == null) {
				lightGunCalibrateCentreCheckbox.Checked = false;
				lightGunCalibrateTopLeftCheckbox.Checked = false;
			} else if (checkbox.Checked) {
				if (checkbox == lightGunCalibrateCentreCheckbox) {
					lightGunCalibrateTopLeftCheckbox.Checked = false;
					this.lightGunCalibrationCentreX.Value = 0;
					this.lightGunCalibrationCentreY.Value = 0;
					this.lightGunCalibrationTopLeftX.Value = 0;
					this.lightGunCalibrationTopLeftY.Value = 0;
					this.lightGunCalibrationChanged = true;
				} else if (checkbox == lightGunCalibrateTopLeftCheckbox) {
					lightGunCalibrateCentreCheckbox.Checked = false;
					this.lightGunCalibrationTopLeftX.Value = 0;
					this.lightGunCalibrationTopLeftY.Value = 0;
					this.lightGunCalibrationChanged = true;
				}
			}
		}

		private void LeftActuatorSpinner_ValueChanged(object sender, EventArgs e) {
			if (this.leftActuatorStrength.Value != (int)this.leftActuatorSpinner.Value) {
				this.leftActuatorStrength.Value = (int)this.leftActuatorSpinner.Value;
			}
		}

		private void RightActuatorSpinner_ValueChanged(object sender, EventArgs e) {
			if (this.rightActuatorStrength.Value != (int)this.rightActuatorSpinner.Value) {
				this.rightActuatorStrength.Value = (int)this.rightActuatorSpinner.Value;
			}
		}

		private void LeftActuatorStrength_ValueChanged(object sender, EventArgs e) {
			if ((int)this.leftActuatorSpinner.Value != this.leftActuatorStrength.Value) {
				this.leftActuatorSpinner.Value = this.leftActuatorStrength.Value;
			}
		}

		private void RightActuatorStrength_ValueChanged(object sender, EventArgs e) {
			if ((int)this.rightActuatorSpinner.Value != this.rightActuatorStrength.Value) {
				this.rightActuatorSpinner.Value = this.rightActuatorStrength.Value;
			}
		}
	}
}
