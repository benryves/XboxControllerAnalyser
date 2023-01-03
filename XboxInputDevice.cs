using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeDevelopment.XboxControllerAnalyser {

	internal class XboxInputDevice {

		public enum ControllerType : byte {
			GameController = 0x01,
			DvdMoviePlaybackReceiver = 0x03,
		};

		public enum GameControllerSubType : byte {
			Duke = 0x01,
			ControllerS = 0x02,
			SteeringWheel = 0x10,
			ArcadeStick = 0x20,
			LightGun = 0x50,
		};

		[Flags]
		public enum GameControllerDigitalButtons {
			None = 0,
			Up = 0x01,
			Down = 0x02,
			Left = 0x04,
			Right = 0x08,
			Start = 0x10,
			Back = 0x20,
			LeftStick = 0x40,
			RightStick = 0x80,
		};

		public struct GameControllerInputState {

			public GameControllerDigitalButtons DigitalButtons;
			public byte A;
			public byte B;
			public byte X;
			public byte Y;
			public byte Black;
			public byte White;
			public byte LeftTrigger;
			public byte RightTrigger;
			public ushort LeftStickX;
			public ushort LeftStickY;
			public ushort RightStickX;
			public ushort RightStickY;

			public GameControllerInputState(byte[] report) {
				this.DigitalButtons = (GameControllerDigitalButtons)report[2];
				this.A = report[4];
				this.B = report[5];
				this.X = report[6];
				this.Y = report[7];
				this.Black = report[8];
				this.White = report[9];
				this.LeftTrigger = report[10];
				this.RightTrigger = report[11];
				this.LeftStickX = (ushort)(report[12] | (report[13] << 8));
				this.LeftStickY	= (ushort)(report[14] | (report[15] << 8));
				this.RightStickX = (ushort)(report[16] | (report[17] << 8));
				this.RightStickY = (ushort)(report[18] | (report[19] << 8));
			}

		};

	}
}
