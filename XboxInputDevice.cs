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
		public enum GameControllerDigitalButtons : byte {
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

		[Flags]
		public enum GameControllerLightGunFlags : byte {
			None = 0,
			LightVisible = 0x20,
			Unknown1 = 0x40,
			Unknown2 = 0x80,
		};

		public struct GameControllerInputState {

			public GameControllerDigitalButtons DigitalButtons;
			public GameControllerLightGunFlags LightGunFlags;
			public byte A;
			public byte B;
			public byte X;
			public byte Y;
			public byte Black;
			public byte White;
			public byte LeftTrigger;
			public byte RightTrigger;
			public short LeftStickX;
			public short LeftStickY;
			public short RightStickX;
			public short RightStickY;

			public GameControllerInputState(byte[] report) {
				this.DigitalButtons = (GameControllerDigitalButtons)report[2];
				this.LightGunFlags = (GameControllerLightGunFlags)report[3];
				this.A = report[4];
				this.B = report[5];
				this.X = report[6];
				this.Y = report[7];
				this.Black = report[8];
				this.White = report[9];
				this.LeftTrigger = report[10];
				this.RightTrigger = report[11];
				this.LeftStickX = (short)(report[12] | (report[13] << 8));
				this.LeftStickY = (short)(report[14] | (report[15] << 8));
				this.RightStickX = (short)(report[16] | (report[17] << 8));
				this.RightStickY = (short)(report[18] | (report[19] << 8));
			}

		};

		public struct GameControllerOutputState {

			public ushort LeftActuatorStrength;
			public ushort RightActuatorStrength;

			public GameControllerOutputState(byte[] report) {
				this.LeftActuatorStrength = (ushort)(report[2] | (report[3] << 8));
				this.RightActuatorStrength = (ushort)(report[4] | (report[5] << 8));
			}

			public byte[] GetBytes() {
				var report = new byte[6];
				report[0] = 0;
				report[1] = 6;
				report[2] = (byte)this.LeftActuatorStrength;
				report[3] = (byte)(this.LeftActuatorStrength >> 8);
				report[4] = (byte)this.RightActuatorStrength;
				report[5] = (byte)(this.RightActuatorStrength >> 8);
				return report;
			}

		}

		public struct GameControllerLightGunCalibrationState {

			public short CentreXOffset;
			public short CentreYOffset;

			public short TopLeftXOffset;
			public short TopLeftYOffset;

			public GameControllerLightGunCalibrationState(byte[] report) {
				this.CentreXOffset = (short)(report[2] | (report[3] << 8));
				this.CentreYOffset = (short)(report[4] | (report[5] << 8));
				this.TopLeftXOffset = (short)(report[6] | (report[7] << 8));
				this.TopLeftYOffset = (short)(report[8] | (report[9] << 8));

			}

			public byte[] GetBytes() {
				var report = new byte[10];
				report[0] = 1;
				report[1] = 10;
				report[2] = (byte)this.CentreXOffset;
				report[3] = (byte)(this.CentreXOffset >> 8);
				report[4] = (byte)this.CentreYOffset;
				report[5] = (byte)(this.CentreYOffset >> 8);
				report[6] = (byte)this.TopLeftXOffset;
				report[7] = (byte)(this.TopLeftXOffset >> 8);
				report[8] = (byte)this.TopLeftYOffset;
				report[9] = (byte)(this.TopLeftYOffset >> 8);
				return report;
			}

		}
	}
}
