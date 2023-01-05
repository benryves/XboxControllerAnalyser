using LibUsbDotNet;
using LibUsbDotNet.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeDevelopment.XboxControllerAnalyser {
	public partial class GameControllerStatePreview : Form {

		public UsbDevice? Device { get; set; }

		ListViewItem.ListViewSubItem dpad;
		ListViewItem.ListViewSubItem start;
		ListViewItem.ListViewSubItem back;
		ListViewItem.ListViewSubItem leftStickButton;
		ListViewItem.ListViewSubItem rightStickButton;
		
		ListViewItem.ListViewSubItem lightGunLightVisible;
		ListViewItem.ListViewSubItem lightGunUnknown1;
		ListViewItem.ListViewSubItem lightGunUnknown2;

		ListViewItem.ListViewSubItem a;
		ListViewItem.ListViewSubItem b;
		ListViewItem.ListViewSubItem x;
		ListViewItem.ListViewSubItem y;
		ListViewItem.ListViewSubItem black;
		ListViewItem.ListViewSubItem white;
		ListViewItem.ListViewSubItem leftTrigger;
		ListViewItem.ListViewSubItem rightTrigger;
		
		ListViewItem.ListViewSubItem leftStick;
		ListViewItem.ListViewSubItem rightStick;

		private ListViewItem.ListViewSubItem CreateLivePreviewListViewItem(string field) {
			
			var group = this.livePreviewFields.Groups[this.livePreviewFields.Groups.Count - 1];
			
			var fieldItem = new ListViewItem {
				Text = field,
				Group = group,
			};

			var subItem = new ListViewItem.ListViewSubItem {
				Tag = fieldItem
			};

			fieldItem.SubItems.Add(subItem);

			this.livePreviewFields.Items.Add(fieldItem);

			return subItem;
		}

		public GameControllerStatePreview() {
			InitializeComponent();

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

		}

		private void GameControllerStatePreview_Load(object sender, EventArgs e) {

			// double-buffer list view
			var prop = typeof(ListView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			if (prop != null) prop.SetValue(this.livePreviewFields, true, null);

			// get capabilities to hide unused fields
			if (this.Device != null) {

				UsbSetupPacket setupPacket = new UsbSetupPacket {
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
					int length;
					success = this.Device.ControlTransfer(ref setupPacket, handle.AddrOfPinnedObject(), setupPacket.Length, out length) && length == response.Length;
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

			// poll the controller for its state
			if (this.Device != null && this.Device.IsOpen) {
				this.updateTimer.Start();
			}
		}

		private void GameControllerStatePreview_FormClosing(object sender, FormClosingEventArgs e) {
			this.updateTimer.Stop();
		}

		private void UpdateTimer_Tick(object sender, EventArgs e) {
			if (this.Device != null) {
				
				// GET_REPORT
				UsbSetupPacket setupPacket = new UsbSetupPacket {
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
					int length;
					success = this.Device.ControlTransfer(ref setupPacket, handle.AddrOfPinnedObject(), setupPacket.Length, out length) && length == response.Length;
				} finally {
					handle.Free();
				}

				if (success) {
					
					var state = new XboxInputDevice.GameControllerInputState(response);
					this.Text = state.DigitalButtons.ToString();
					this.dpad.Text = (state.DigitalButtons & (XboxInputDevice.GameControllerDigitalButtons.Up | XboxInputDevice.GameControllerDigitalButtons.Down | XboxInputDevice.GameControllerDigitalButtons.Left | XboxInputDevice.GameControllerDigitalButtons.Right)).ToString();
					this.start.Text = ((state.DigitalButtons & XboxInputDevice.GameControllerDigitalButtons.Start) != XboxInputDevice.GameControllerDigitalButtons.None).ToString();
					this.back.Text = ((state.DigitalButtons & XboxInputDevice.GameControllerDigitalButtons.Back) != XboxInputDevice.GameControllerDigitalButtons.None).ToString();
					this.leftStickButton.Text = ((state.DigitalButtons & XboxInputDevice.GameControllerDigitalButtons.LeftStick) != XboxInputDevice.GameControllerDigitalButtons.None).ToString();
					this.rightStickButton.Text = ((state.DigitalButtons & XboxInputDevice.GameControllerDigitalButtons.RightStick) != XboxInputDevice.GameControllerDigitalButtons.None).ToString();

					this.lightGunLightVisible.Text = ((state.LightGunFlags & XboxInputDevice.GameControllerLightGunFlags.LightVisible) != XboxInputDevice.GameControllerLightGunFlags.None).ToString();
					this.lightGunUnknown1.Text = ((state.LightGunFlags & XboxInputDevice.GameControllerLightGunFlags.Unknown1) != XboxInputDevice.GameControllerLightGunFlags.None).ToString();
					this.lightGunUnknown2.Text = ((state.LightGunFlags & XboxInputDevice.GameControllerLightGunFlags.Unknown2) != XboxInputDevice.GameControllerLightGunFlags.None).ToString();
					
					this.a.Text = "0x" + state.A.ToString("X2");
					this.b.Text = "0x" + state.B.ToString("X2");
					this.x.Text = "0x" + state.X.ToString("X2");
					this.y.Text = "0x" + state.Y.ToString("X2");
					this.black.Text = "0x" + state.Black.ToString("X2");
					this.white.Text = "0x" + state.White.ToString("X2");

					this.leftTrigger.Text = "0x" + state.LeftTrigger.ToString("X2");
					this.rightTrigger.Text = "0x" + state.RightTrigger.ToString("X2");

					this.leftStick.Text = string.Format("(0x{0:X4}, 0x{1:X4})", state.LeftStickX, state.LeftStickY);
					this.rightStick.Text = string.Format("(0x{0:X4}, 0x{1:X4})", state.RightStickX, state.RightStickY);

				}

			}
		}
	}
}
