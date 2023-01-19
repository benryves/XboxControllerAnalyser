namespace BeeDevelopment.XboxControllerAnalyser {
	partial class GameControllerStatePreview {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameControllerStatePreview));
			this.updateTimer = new System.Windows.Forms.Timer(this.components);
			this.livePreviewFields = new System.Windows.Forms.ListView();
			this.fieldHeader = new System.Windows.Forms.ColumnHeader();
			this.valueHeader = new System.Windows.Forms.ColumnHeader();
			this.livePreviewSplit = new System.Windows.Forms.SplitContainer();
			this.inputGroup = new System.Windows.Forms.GroupBox();
			this.baseRadioButtons = new System.Windows.Forms.TableLayoutPanel();
			this.hexadecimalRadioButton = new System.Windows.Forms.RadioButton();
			this.decimalRadioButton = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.controlTable = new System.Windows.Forms.TableLayoutPanel();
			this.fieldVisibilityGroup = new System.Windows.Forms.GroupBox();
			this.fieldVisibilityTable = new System.Windows.Forms.TableLayoutPanel();
			this.fieldVisibilityReported = new System.Windows.Forms.RadioButton();
			this.fieldVisibilityAll = new System.Windows.Forms.RadioButton();
			this.fieldVisibilityLabel = new System.Windows.Forms.Label();
			this.forceFeedbackOutputGroup = new System.Windows.Forms.GroupBox();
			this.outputForceFeedbackTable = new System.Windows.Forms.TableLayoutPanel();
			this.leftActuatorLabel = new System.Windows.Forms.Label();
			this.rightActuatorLabel = new System.Windows.Forms.Label();
			this.leftActuatorPanel = new System.Windows.Forms.Panel();
			this.leftActuatorStrength = new System.Windows.Forms.TrackBar();
			this.leftActuatorSpinner = new System.Windows.Forms.NumericUpDown();
			this.rightActuatorPanel = new System.Windows.Forms.Panel();
			this.rightActuatorStrength = new System.Windows.Forms.TrackBar();
			this.rightActuatorSpinner = new System.Windows.Forms.NumericUpDown();
			this.lightGunCalibrationGroup = new System.Windows.Forms.GroupBox();
			this.lightGunCalibrationTable = new System.Windows.Forms.TableLayoutPanel();
			this.lightGunCalibrationTopLeftGroup = new System.Windows.Forms.GroupBox();
			this.lightGunCalibrationTopLeftTable = new System.Windows.Forms.TableLayoutPanel();
			this.lightGunCalibrationTopLeftY = new System.Windows.Forms.TrackBar();
			this.lightGunCalibrationTopLeftYLabel = new System.Windows.Forms.Label();
			this.lightGunCalibrationTopLeftX = new System.Windows.Forms.TrackBar();
			this.lightGunCalibrationTopLeftXLabel = new System.Windows.Forms.Label();
			this.lightGunCalibrateTopLeftCheckbox = new System.Windows.Forms.CheckBox();
			this.lightGunCalibrationCentreGroup = new System.Windows.Forms.GroupBox();
			this.lightGunCalibrationCentreTable = new System.Windows.Forms.TableLayoutPanel();
			this.lightGunCalibrationCentreY = new System.Windows.Forms.TrackBar();
			this.lightGunCalibrationCentreYLabel = new System.Windows.Forms.Label();
			this.lightGunCalibrationCentreX = new System.Windows.Forms.TrackBar();
			this.lightGunCalibrationCentreXLabel = new System.Windows.Forms.Label();
			this.lightGunCalibrateCentreCheckbox = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.livePreviewSplit)).BeginInit();
			this.livePreviewSplit.Panel1.SuspendLayout();
			this.livePreviewSplit.Panel2.SuspendLayout();
			this.livePreviewSplit.SuspendLayout();
			this.inputGroup.SuspendLayout();
			this.baseRadioButtons.SuspendLayout();
			this.controlTable.SuspendLayout();
			this.fieldVisibilityGroup.SuspendLayout();
			this.fieldVisibilityTable.SuspendLayout();
			this.forceFeedbackOutputGroup.SuspendLayout();
			this.outputForceFeedbackTable.SuspendLayout();
			this.leftActuatorPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.leftActuatorStrength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leftActuatorSpinner)).BeginInit();
			this.rightActuatorPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rightActuatorStrength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rightActuatorSpinner)).BeginInit();
			this.lightGunCalibrationGroup.SuspendLayout();
			this.lightGunCalibrationTable.SuspendLayout();
			this.lightGunCalibrationTopLeftGroup.SuspendLayout();
			this.lightGunCalibrationTopLeftTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lightGunCalibrationTopLeftY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lightGunCalibrationTopLeftX)).BeginInit();
			this.lightGunCalibrationCentreGroup.SuspendLayout();
			this.lightGunCalibrationCentreTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lightGunCalibrationCentreY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lightGunCalibrationCentreX)).BeginInit();
			this.SuspendLayout();
			// 
			// updateTimer
			// 
			this.updateTimer.Interval = 20;
			this.updateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
			// 
			// livePreviewFields
			// 
			this.livePreviewFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fieldHeader,
            this.valueHeader});
			this.livePreviewFields.Dock = System.Windows.Forms.DockStyle.Fill;
			this.livePreviewFields.FullRowSelect = true;
			this.livePreviewFields.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.livePreviewFields.Location = new System.Drawing.Point(3, 19);
			this.livePreviewFields.Name = "livePreviewFields";
			this.livePreviewFields.Size = new System.Drawing.Size(374, 402);
			this.livePreviewFields.TabIndex = 0;
			this.livePreviewFields.UseCompatibleStateImageBehavior = false;
			this.livePreviewFields.View = System.Windows.Forms.View.Details;
			// 
			// fieldHeader
			// 
			this.fieldHeader.Text = "Field";
			this.fieldHeader.Width = 170;
			// 
			// valueHeader
			// 
			this.valueHeader.Text = "Value";
			this.valueHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.valueHeader.Width = 180;
			// 
			// livePreviewSplit
			// 
			this.livePreviewSplit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.livePreviewSplit.Location = new System.Drawing.Point(4, 2);
			this.livePreviewSplit.Name = "livePreviewSplit";
			// 
			// livePreviewSplit.Panel1
			// 
			this.livePreviewSplit.Panel1.Controls.Add(this.inputGroup);
			this.livePreviewSplit.Panel1.Padding = new System.Windows.Forms.Padding(3);
			// 
			// livePreviewSplit.Panel2
			// 
			this.livePreviewSplit.Panel2.Controls.Add(this.controlTable);
			this.livePreviewSplit.Size = new System.Drawing.Size(776, 455);
			this.livePreviewSplit.SplitterDistance = 386;
			this.livePreviewSplit.TabIndex = 1;
			// 
			// inputGroup
			// 
			this.inputGroup.Controls.Add(this.livePreviewFields);
			this.inputGroup.Controls.Add(this.baseRadioButtons);
			this.inputGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputGroup.Location = new System.Drawing.Point(3, 3);
			this.inputGroup.Name = "inputGroup";
			this.inputGroup.Size = new System.Drawing.Size(380, 449);
			this.inputGroup.TabIndex = 0;
			this.inputGroup.TabStop = false;
			this.inputGroup.Text = "Input";
			// 
			// baseRadioButtons
			// 
			this.baseRadioButtons.ColumnCount = 3;
			this.baseRadioButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.baseRadioButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.baseRadioButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.baseRadioButtons.Controls.Add(this.hexadecimalRadioButton, 2, 0);
			this.baseRadioButtons.Controls.Add(this.decimalRadioButton, 1, 0);
			this.baseRadioButtons.Controls.Add(this.label1, 0, 0);
			this.baseRadioButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.baseRadioButtons.Location = new System.Drawing.Point(3, 421);
			this.baseRadioButtons.Name = "baseRadioButtons";
			this.baseRadioButtons.RowCount = 1;
			this.baseRadioButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.baseRadioButtons.Size = new System.Drawing.Size(374, 25);
			this.baseRadioButtons.TabIndex = 3;
			// 
			// hexadecimalRadioButton
			// 
			this.hexadecimalRadioButton.AutoSize = true;
			this.hexadecimalRadioButton.Location = new System.Drawing.Point(251, 3);
			this.hexadecimalRadioButton.Name = "hexadecimalRadioButton";
			this.hexadecimalRadioButton.Size = new System.Drawing.Size(117, 19);
			this.hexadecimalRadioButton.TabIndex = 2;
			this.hexadecimalRadioButton.TabStop = true;
			this.hexadecimalRadioButton.Text = "&Hexadecimal (16)";
			this.hexadecimalRadioButton.UseVisualStyleBackColor = true;
			// 
			// decimalRadioButton
			// 
			this.decimalRadioButton.AutoSize = true;
			this.decimalRadioButton.Location = new System.Drawing.Point(127, 3);
			this.decimalRadioButton.Name = "decimalRadioButton";
			this.decimalRadioButton.Size = new System.Drawing.Size(91, 19);
			this.decimalRadioButton.TabIndex = 1;
			this.decimalRadioButton.TabStop = true;
			this.decimalRadioButton.Text = "&Decimal (10)";
			this.decimalRadioButton.UseVisualStyleBackColor = true;
			this.decimalRadioButton.CheckedChanged += new System.EventHandler(this.NumericDataBaseRadioButton_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Show input data in:";
			// 
			// controlTable
			// 
			this.controlTable.ColumnCount = 1;
			this.controlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.controlTable.Controls.Add(this.fieldVisibilityGroup, 0, 2);
			this.controlTable.Controls.Add(this.forceFeedbackOutputGroup, 0, 0);
			this.controlTable.Controls.Add(this.lightGunCalibrationGroup, 0, 1);
			this.controlTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.controlTable.Location = new System.Drawing.Point(0, 0);
			this.controlTable.Name = "controlTable";
			this.controlTable.RowCount = 3;
			this.controlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
			this.controlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
			this.controlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.controlTable.Size = new System.Drawing.Size(386, 455);
			this.controlTable.TabIndex = 1;
			// 
			// fieldVisibilityGroup
			// 
			this.fieldVisibilityGroup.Controls.Add(this.fieldVisibilityTable);
			this.fieldVisibilityGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fieldVisibilityGroup.Location = new System.Drawing.Point(3, 307);
			this.fieldVisibilityGroup.Name = "fieldVisibilityGroup";
			this.fieldVisibilityGroup.Size = new System.Drawing.Size(380, 145);
			this.fieldVisibilityGroup.TabIndex = 0;
			this.fieldVisibilityGroup.TabStop = false;
			this.fieldVisibilityGroup.Text = "Field Visibility";
			// 
			// fieldVisibilityTable
			// 
			this.fieldVisibilityTable.ColumnCount = 1;
			this.fieldVisibilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.fieldVisibilityTable.Controls.Add(this.fieldVisibilityReported, 0, 1);
			this.fieldVisibilityTable.Controls.Add(this.fieldVisibilityAll, 0, 2);
			this.fieldVisibilityTable.Controls.Add(this.fieldVisibilityLabel, 0, 0);
			this.fieldVisibilityTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fieldVisibilityTable.Location = new System.Drawing.Point(3, 19);
			this.fieldVisibilityTable.Name = "fieldVisibilityTable";
			this.fieldVisibilityTable.RowCount = 3;
			this.fieldVisibilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.fieldVisibilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.fieldVisibilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.fieldVisibilityTable.Size = new System.Drawing.Size(374, 123);
			this.fieldVisibilityTable.TabIndex = 1;
			// 
			// fieldVisibilityReported
			// 
			this.fieldVisibilityReported.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.fieldVisibilityReported.AutoSize = true;
			this.fieldVisibilityReported.Checked = true;
			this.fieldVisibilityReported.Location = new System.Drawing.Point(3, 68);
			this.fieldVisibilityReported.Name = "fieldVisibilityReported";
			this.fieldVisibilityReported.Size = new System.Drawing.Size(160, 19);
			this.fieldVisibilityReported.TabIndex = 0;
			this.fieldVisibilityReported.TabStop = true;
			this.fieldVisibilityReported.Text = "Only show &reported fields";
			this.fieldVisibilityReported.UseVisualStyleBackColor = true;
			this.fieldVisibilityReported.CheckedChanged += new System.EventHandler(this.FieldVisibility_CheckedChanged);
			// 
			// fieldVisibilityAll
			// 
			this.fieldVisibilityAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.fieldVisibilityAll.AutoSize = true;
			this.fieldVisibilityAll.Location = new System.Drawing.Point(3, 98);
			this.fieldVisibilityAll.Name = "fieldVisibilityAll";
			this.fieldVisibilityAll.Size = new System.Drawing.Size(100, 19);
			this.fieldVisibilityAll.TabIndex = 1;
			this.fieldVisibilityAll.Text = "Show &all fields";
			this.fieldVisibilityAll.UseVisualStyleBackColor = true;
			this.fieldVisibilityAll.CheckedChanged += new System.EventHandler(this.FieldVisibility_CheckedChanged);
			// 
			// fieldVisibilityLabel
			// 
			this.fieldVisibilityLabel.AutoEllipsis = true;
			this.fieldVisibilityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fieldVisibilityLabel.Location = new System.Drawing.Point(3, 0);
			this.fieldVisibilityLabel.Name = "fieldVisibilityLabel";
			this.fieldVisibilityLabel.Size = new System.Drawing.Size(374, 63);
			this.fieldVisibilityLabel.TabIndex = 2;
			this.fieldVisibilityLabel.Text = resources.GetString("fieldVisibilityLabel.Text");
			// 
			// forceFeedbackOutputGroup
			// 
			this.forceFeedbackOutputGroup.Controls.Add(this.outputForceFeedbackTable);
			this.forceFeedbackOutputGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.forceFeedbackOutputGroup.Location = new System.Drawing.Point(3, 3);
			this.forceFeedbackOutputGroup.Name = "forceFeedbackOutputGroup";
			this.forceFeedbackOutputGroup.Size = new System.Drawing.Size(380, 146);
			this.forceFeedbackOutputGroup.TabIndex = 0;
			this.forceFeedbackOutputGroup.TabStop = false;
			this.forceFeedbackOutputGroup.Text = "Output";
			// 
			// outputForceFeedbackTable
			// 
			this.outputForceFeedbackTable.ColumnCount = 1;
			this.outputForceFeedbackTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.outputForceFeedbackTable.Controls.Add(this.leftActuatorLabel, 0, 0);
			this.outputForceFeedbackTable.Controls.Add(this.rightActuatorLabel, 0, 2);
			this.outputForceFeedbackTable.Controls.Add(this.leftActuatorPanel, 0, 1);
			this.outputForceFeedbackTable.Controls.Add(this.rightActuatorPanel, 0, 3);
			this.outputForceFeedbackTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputForceFeedbackTable.Location = new System.Drawing.Point(3, 19);
			this.outputForceFeedbackTable.Name = "outputForceFeedbackTable";
			this.outputForceFeedbackTable.RowCount = 4;
			this.outputForceFeedbackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.outputForceFeedbackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.outputForceFeedbackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.outputForceFeedbackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.outputForceFeedbackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.outputForceFeedbackTable.Size = new System.Drawing.Size(374, 124);
			this.outputForceFeedbackTable.TabIndex = 0;
			// 
			// leftActuatorLabel
			// 
			this.leftActuatorLabel.AutoSize = true;
			this.leftActuatorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.leftActuatorLabel.Location = new System.Drawing.Point(3, 16);
			this.leftActuatorLabel.Name = "leftActuatorLabel";
			this.leftActuatorLabel.Size = new System.Drawing.Size(368, 15);
			this.leftActuatorLabel.TabIndex = 0;
			this.leftActuatorLabel.Text = "Left Actuator Strength";
			// 
			// rightActuatorLabel
			// 
			this.rightActuatorLabel.AutoSize = true;
			this.rightActuatorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.rightActuatorLabel.Location = new System.Drawing.Point(3, 78);
			this.rightActuatorLabel.Name = "rightActuatorLabel";
			this.rightActuatorLabel.Size = new System.Drawing.Size(368, 15);
			this.rightActuatorLabel.TabIndex = 1;
			this.rightActuatorLabel.Text = "Right Actuator Strength";
			// 
			// leftActuatorPanel
			// 
			this.leftActuatorPanel.Controls.Add(this.leftActuatorStrength);
			this.leftActuatorPanel.Controls.Add(this.leftActuatorSpinner);
			this.leftActuatorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.leftActuatorPanel.Location = new System.Drawing.Point(3, 34);
			this.leftActuatorPanel.Name = "leftActuatorPanel";
			this.leftActuatorPanel.Size = new System.Drawing.Size(368, 25);
			this.leftActuatorPanel.TabIndex = 4;
			// 
			// leftActuatorStrength
			// 
			this.leftActuatorStrength.Dock = System.Windows.Forms.DockStyle.Fill;
			this.leftActuatorStrength.LargeChange = 8192;
			this.leftActuatorStrength.Location = new System.Drawing.Point(0, 0);
			this.leftActuatorStrength.Maximum = 65535;
			this.leftActuatorStrength.Name = "leftActuatorStrength";
			this.leftActuatorStrength.Size = new System.Drawing.Size(308, 25);
			this.leftActuatorStrength.SmallChange = 2048;
			this.leftActuatorStrength.TabIndex = 2;
			this.leftActuatorStrength.TickFrequency = 2048;
			this.leftActuatorStrength.ValueChanged += new System.EventHandler(this.LeftActuatorStrength_ValueChanged);
			// 
			// leftActuatorSpinner
			// 
			this.leftActuatorSpinner.Dock = System.Windows.Forms.DockStyle.Right;
			this.leftActuatorSpinner.Location = new System.Drawing.Point(308, 0);
			this.leftActuatorSpinner.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.leftActuatorSpinner.Name = "leftActuatorSpinner";
			this.leftActuatorSpinner.Size = new System.Drawing.Size(60, 23);
			this.leftActuatorSpinner.TabIndex = 5;
			this.leftActuatorSpinner.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.leftActuatorSpinner.ValueChanged += new System.EventHandler(this.LeftActuatorSpinner_ValueChanged);
			// 
			// rightActuatorPanel
			// 
			this.rightActuatorPanel.Controls.Add(this.rightActuatorStrength);
			this.rightActuatorPanel.Controls.Add(this.rightActuatorSpinner);
			this.rightActuatorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rightActuatorPanel.Location = new System.Drawing.Point(3, 96);
			this.rightActuatorPanel.Name = "rightActuatorPanel";
			this.rightActuatorPanel.Size = new System.Drawing.Size(368, 25);
			this.rightActuatorPanel.TabIndex = 5;
			// 
			// rightActuatorStrength
			// 
			this.rightActuatorStrength.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rightActuatorStrength.LargeChange = 8192;
			this.rightActuatorStrength.Location = new System.Drawing.Point(0, 0);
			this.rightActuatorStrength.Maximum = 65535;
			this.rightActuatorStrength.Name = "rightActuatorStrength";
			this.rightActuatorStrength.Size = new System.Drawing.Size(308, 25);
			this.rightActuatorStrength.SmallChange = 2048;
			this.rightActuatorStrength.TabIndex = 3;
			this.rightActuatorStrength.TickFrequency = 2048;
			this.rightActuatorStrength.ValueChanged += new System.EventHandler(this.RightActuatorStrength_ValueChanged);
			// 
			// rightActuatorSpinner
			// 
			this.rightActuatorSpinner.Dock = System.Windows.Forms.DockStyle.Right;
			this.rightActuatorSpinner.Location = new System.Drawing.Point(308, 0);
			this.rightActuatorSpinner.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.rightActuatorSpinner.Name = "rightActuatorSpinner";
			this.rightActuatorSpinner.Size = new System.Drawing.Size(60, 23);
			this.rightActuatorSpinner.TabIndex = 4;
			this.rightActuatorSpinner.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.rightActuatorSpinner.ValueChanged += new System.EventHandler(this.RightActuatorSpinner_ValueChanged);
			// 
			// lightGunCalibrationGroup
			// 
			this.lightGunCalibrationGroup.Controls.Add(this.lightGunCalibrationTable);
			this.lightGunCalibrationGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lightGunCalibrationGroup.Location = new System.Drawing.Point(3, 155);
			this.lightGunCalibrationGroup.Name = "lightGunCalibrationGroup";
			this.lightGunCalibrationGroup.Size = new System.Drawing.Size(380, 146);
			this.lightGunCalibrationGroup.TabIndex = 1;
			this.lightGunCalibrationGroup.TabStop = false;
			this.lightGunCalibrationGroup.Text = "Light Gun Calibration";
			// 
			// lightGunCalibrationTable
			// 
			this.lightGunCalibrationTable.ColumnCount = 2;
			this.lightGunCalibrationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.lightGunCalibrationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.lightGunCalibrationTable.Controls.Add(this.lightGunCalibrationTopLeftGroup, 1, 0);
			this.lightGunCalibrationTable.Controls.Add(this.lightGunCalibrationCentreGroup, 0, 0);
			this.lightGunCalibrationTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lightGunCalibrationTable.Location = new System.Drawing.Point(3, 19);
			this.lightGunCalibrationTable.Name = "lightGunCalibrationTable";
			this.lightGunCalibrationTable.RowCount = 1;
			this.lightGunCalibrationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.lightGunCalibrationTable.Size = new System.Drawing.Size(374, 124);
			this.lightGunCalibrationTable.TabIndex = 0;
			// 
			// lightGunCalibrationTopLeftGroup
			// 
			this.lightGunCalibrationTopLeftGroup.Controls.Add(this.lightGunCalibrationTopLeftTable);
			this.lightGunCalibrationTopLeftGroup.Controls.Add(this.lightGunCalibrateTopLeftCheckbox);
			this.lightGunCalibrationTopLeftGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lightGunCalibrationTopLeftGroup.Location = new System.Drawing.Point(190, 3);
			this.lightGunCalibrationTopLeftGroup.Name = "lightGunCalibrationTopLeftGroup";
			this.lightGunCalibrationTopLeftGroup.Size = new System.Drawing.Size(181, 118);
			this.lightGunCalibrationTopLeftGroup.TabIndex = 1;
			this.lightGunCalibrationTopLeftGroup.TabStop = false;
			this.lightGunCalibrationTopLeftGroup.Text = "Top Left Offset";
			// 
			// lightGunCalibrationTopLeftTable
			// 
			this.lightGunCalibrationTopLeftTable.ColumnCount = 2;
			this.lightGunCalibrationTopLeftTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.lightGunCalibrationTopLeftTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.lightGunCalibrationTopLeftTable.Controls.Add(this.lightGunCalibrationTopLeftY, 1, 1);
			this.lightGunCalibrationTopLeftTable.Controls.Add(this.lightGunCalibrationTopLeftYLabel, 0, 1);
			this.lightGunCalibrationTopLeftTable.Controls.Add(this.lightGunCalibrationTopLeftX, 1, 0);
			this.lightGunCalibrationTopLeftTable.Controls.Add(this.lightGunCalibrationTopLeftXLabel, 0, 0);
			this.lightGunCalibrationTopLeftTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lightGunCalibrationTopLeftTable.Location = new System.Drawing.Point(3, 19);
			this.lightGunCalibrationTopLeftTable.Name = "lightGunCalibrationTopLeftTable";
			this.lightGunCalibrationTopLeftTable.RowCount = 2;
			this.lightGunCalibrationTopLeftTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.lightGunCalibrationTopLeftTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.lightGunCalibrationTopLeftTable.Size = new System.Drawing.Size(175, 71);
			this.lightGunCalibrationTopLeftTable.TabIndex = 1;
			// 
			// lightGunCalibrationTopLeftY
			// 
			this.lightGunCalibrationTopLeftY.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lightGunCalibrationTopLeftY.LargeChange = 8192;
			this.lightGunCalibrationTopLeftY.Location = new System.Drawing.Point(23, 38);
			this.lightGunCalibrationTopLeftY.Maximum = 32767;
			this.lightGunCalibrationTopLeftY.Minimum = -32768;
			this.lightGunCalibrationTopLeftY.Name = "lightGunCalibrationTopLeftY";
			this.lightGunCalibrationTopLeftY.Size = new System.Drawing.Size(149, 30);
			this.lightGunCalibrationTopLeftY.SmallChange = 2048;
			this.lightGunCalibrationTopLeftY.TabIndex = 6;
			this.lightGunCalibrationTopLeftY.TickFrequency = 2048;
			this.lightGunCalibrationTopLeftY.Scroll += new System.EventHandler(this.LightGunCalibrationTrackBar_Scroll);
			// 
			// lightGunCalibrationTopLeftYLabel
			// 
			this.lightGunCalibrationTopLeftYLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lightGunCalibrationTopLeftYLabel.AutoSize = true;
			this.lightGunCalibrationTopLeftYLabel.Location = new System.Drawing.Point(3, 45);
			this.lightGunCalibrationTopLeftYLabel.Name = "lightGunCalibrationTopLeftYLabel";
			this.lightGunCalibrationTopLeftYLabel.Size = new System.Drawing.Size(14, 15);
			this.lightGunCalibrationTopLeftYLabel.TabIndex = 5;
			this.lightGunCalibrationTopLeftYLabel.Text = "Y";
			// 
			// lightGunCalibrationTopLeftX
			// 
			this.lightGunCalibrationTopLeftX.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lightGunCalibrationTopLeftX.LargeChange = 8192;
			this.lightGunCalibrationTopLeftX.Location = new System.Drawing.Point(23, 3);
			this.lightGunCalibrationTopLeftX.Maximum = 32767;
			this.lightGunCalibrationTopLeftX.Minimum = -32768;
			this.lightGunCalibrationTopLeftX.Name = "lightGunCalibrationTopLeftX";
			this.lightGunCalibrationTopLeftX.Size = new System.Drawing.Size(149, 29);
			this.lightGunCalibrationTopLeftX.SmallChange = 2048;
			this.lightGunCalibrationTopLeftX.TabIndex = 4;
			this.lightGunCalibrationTopLeftX.TickFrequency = 2048;
			this.lightGunCalibrationTopLeftX.Scroll += new System.EventHandler(this.LightGunCalibrationTrackBar_Scroll);
			// 
			// lightGunCalibrationTopLeftXLabel
			// 
			this.lightGunCalibrationTopLeftXLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lightGunCalibrationTopLeftXLabel.AutoSize = true;
			this.lightGunCalibrationTopLeftXLabel.Location = new System.Drawing.Point(3, 10);
			this.lightGunCalibrationTopLeftXLabel.Name = "lightGunCalibrationTopLeftXLabel";
			this.lightGunCalibrationTopLeftXLabel.Size = new System.Drawing.Size(14, 15);
			this.lightGunCalibrationTopLeftXLabel.TabIndex = 1;
			this.lightGunCalibrationTopLeftXLabel.Text = "X";
			// 
			// lightGunCalibrateTopLeftCheckbox
			// 
			this.lightGunCalibrateTopLeftCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
			this.lightGunCalibrateTopLeftCheckbox.AutoSize = true;
			this.lightGunCalibrateTopLeftCheckbox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lightGunCalibrateTopLeftCheckbox.Location = new System.Drawing.Point(3, 90);
			this.lightGunCalibrateTopLeftCheckbox.Name = "lightGunCalibrateTopLeftCheckbox";
			this.lightGunCalibrateTopLeftCheckbox.Size = new System.Drawing.Size(175, 25);
			this.lightGunCalibrateTopLeftCheckbox.TabIndex = 2;
			this.lightGunCalibrateTopLeftCheckbox.Text = "Calibrate";
			this.lightGunCalibrateTopLeftCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lightGunCalibrateTopLeftCheckbox.UseVisualStyleBackColor = true;
			this.lightGunCalibrateTopLeftCheckbox.CheckedChanged += new System.EventHandler(this.CalibrateCheckbox_CheckedChanged);
			// 
			// lightGunCalibrationCentreGroup
			// 
			this.lightGunCalibrationCentreGroup.Controls.Add(this.lightGunCalibrationCentreTable);
			this.lightGunCalibrationCentreGroup.Controls.Add(this.lightGunCalibrateCentreCheckbox);
			this.lightGunCalibrationCentreGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lightGunCalibrationCentreGroup.Location = new System.Drawing.Point(3, 3);
			this.lightGunCalibrationCentreGroup.Name = "lightGunCalibrationCentreGroup";
			this.lightGunCalibrationCentreGroup.Size = new System.Drawing.Size(181, 118);
			this.lightGunCalibrationCentreGroup.TabIndex = 0;
			this.lightGunCalibrationCentreGroup.TabStop = false;
			this.lightGunCalibrationCentreGroup.Text = "Centre Offset";
			// 
			// lightGunCalibrationCentreTable
			// 
			this.lightGunCalibrationCentreTable.ColumnCount = 2;
			this.lightGunCalibrationCentreTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.lightGunCalibrationCentreTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.lightGunCalibrationCentreTable.Controls.Add(this.lightGunCalibrationCentreY, 1, 1);
			this.lightGunCalibrationCentreTable.Controls.Add(this.lightGunCalibrationCentreYLabel, 0, 1);
			this.lightGunCalibrationCentreTable.Controls.Add(this.lightGunCalibrationCentreX, 1, 0);
			this.lightGunCalibrationCentreTable.Controls.Add(this.lightGunCalibrationCentreXLabel, 0, 0);
			this.lightGunCalibrationCentreTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lightGunCalibrationCentreTable.Location = new System.Drawing.Point(3, 19);
			this.lightGunCalibrationCentreTable.Name = "lightGunCalibrationCentreTable";
			this.lightGunCalibrationCentreTable.RowCount = 2;
			this.lightGunCalibrationCentreTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.lightGunCalibrationCentreTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.lightGunCalibrationCentreTable.Size = new System.Drawing.Size(175, 71);
			this.lightGunCalibrationCentreTable.TabIndex = 0;
			// 
			// lightGunCalibrationCentreY
			// 
			this.lightGunCalibrationCentreY.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lightGunCalibrationCentreY.LargeChange = 8192;
			this.lightGunCalibrationCentreY.Location = new System.Drawing.Point(23, 38);
			this.lightGunCalibrationCentreY.Maximum = 32767;
			this.lightGunCalibrationCentreY.Minimum = -32768;
			this.lightGunCalibrationCentreY.Name = "lightGunCalibrationCentreY";
			this.lightGunCalibrationCentreY.Size = new System.Drawing.Size(149, 30);
			this.lightGunCalibrationCentreY.SmallChange = 2048;
			this.lightGunCalibrationCentreY.TabIndex = 6;
			this.lightGunCalibrationCentreY.TickFrequency = 2048;
			this.lightGunCalibrationCentreY.Scroll += new System.EventHandler(this.LightGunCalibrationTrackBar_Scroll);
			// 
			// lightGunCalibrationCentreYLabel
			// 
			this.lightGunCalibrationCentreYLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lightGunCalibrationCentreYLabel.AutoSize = true;
			this.lightGunCalibrationCentreYLabel.Location = new System.Drawing.Point(3, 45);
			this.lightGunCalibrationCentreYLabel.Name = "lightGunCalibrationCentreYLabel";
			this.lightGunCalibrationCentreYLabel.Size = new System.Drawing.Size(14, 15);
			this.lightGunCalibrationCentreYLabel.TabIndex = 5;
			this.lightGunCalibrationCentreYLabel.Text = "Y";
			// 
			// lightGunCalibrationCentreX
			// 
			this.lightGunCalibrationCentreX.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lightGunCalibrationCentreX.LargeChange = 8192;
			this.lightGunCalibrationCentreX.Location = new System.Drawing.Point(23, 3);
			this.lightGunCalibrationCentreX.Maximum = 32767;
			this.lightGunCalibrationCentreX.Minimum = -32768;
			this.lightGunCalibrationCentreX.Name = "lightGunCalibrationCentreX";
			this.lightGunCalibrationCentreX.Size = new System.Drawing.Size(149, 29);
			this.lightGunCalibrationCentreX.SmallChange = 2048;
			this.lightGunCalibrationCentreX.TabIndex = 4;
			this.lightGunCalibrationCentreX.TickFrequency = 2048;
			this.lightGunCalibrationCentreX.Scroll += new System.EventHandler(this.LightGunCalibrationTrackBar_Scroll);
			// 
			// lightGunCalibrationCentreXLabel
			// 
			this.lightGunCalibrationCentreXLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lightGunCalibrationCentreXLabel.AutoSize = true;
			this.lightGunCalibrationCentreXLabel.Location = new System.Drawing.Point(3, 10);
			this.lightGunCalibrationCentreXLabel.Name = "lightGunCalibrationCentreXLabel";
			this.lightGunCalibrationCentreXLabel.Size = new System.Drawing.Size(14, 15);
			this.lightGunCalibrationCentreXLabel.TabIndex = 1;
			this.lightGunCalibrationCentreXLabel.Text = "X";
			// 
			// lightGunCalibrateCentreCheckbox
			// 
			this.lightGunCalibrateCentreCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
			this.lightGunCalibrateCentreCheckbox.AutoSize = true;
			this.lightGunCalibrateCentreCheckbox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lightGunCalibrateCentreCheckbox.Location = new System.Drawing.Point(3, 90);
			this.lightGunCalibrateCentreCheckbox.Name = "lightGunCalibrateCentreCheckbox";
			this.lightGunCalibrateCentreCheckbox.Size = new System.Drawing.Size(175, 25);
			this.lightGunCalibrateCentreCheckbox.TabIndex = 1;
			this.lightGunCalibrateCentreCheckbox.Text = "Calibrate";
			this.lightGunCalibrateCentreCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lightGunCalibrateCentreCheckbox.UseVisualStyleBackColor = true;
			this.lightGunCalibrateCentreCheckbox.CheckedChanged += new System.EventHandler(this.CalibrateCheckbox_CheckedChanged);
			// 
			// GameControllerStatePreview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.livePreviewSplit);
			this.Name = "GameControllerStatePreview";
			this.Padding = new System.Windows.Forms.Padding(4, 2, 4, 4);
			this.Text = "Live Preview";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameControllerStatePreview_FormClosing);
			this.Load += new System.EventHandler(this.GameControllerStatePreview_Load);
			this.livePreviewSplit.Panel1.ResumeLayout(false);
			this.livePreviewSplit.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.livePreviewSplit)).EndInit();
			this.livePreviewSplit.ResumeLayout(false);
			this.inputGroup.ResumeLayout(false);
			this.baseRadioButtons.ResumeLayout(false);
			this.baseRadioButtons.PerformLayout();
			this.controlTable.ResumeLayout(false);
			this.fieldVisibilityGroup.ResumeLayout(false);
			this.fieldVisibilityTable.ResumeLayout(false);
			this.fieldVisibilityTable.PerformLayout();
			this.forceFeedbackOutputGroup.ResumeLayout(false);
			this.outputForceFeedbackTable.ResumeLayout(false);
			this.outputForceFeedbackTable.PerformLayout();
			this.leftActuatorPanel.ResumeLayout(false);
			this.leftActuatorPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.leftActuatorStrength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leftActuatorSpinner)).EndInit();
			this.rightActuatorPanel.ResumeLayout(false);
			this.rightActuatorPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rightActuatorStrength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rightActuatorSpinner)).EndInit();
			this.lightGunCalibrationGroup.ResumeLayout(false);
			this.lightGunCalibrationTable.ResumeLayout(false);
			this.lightGunCalibrationTopLeftGroup.ResumeLayout(false);
			this.lightGunCalibrationTopLeftGroup.PerformLayout();
			this.lightGunCalibrationTopLeftTable.ResumeLayout(false);
			this.lightGunCalibrationTopLeftTable.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.lightGunCalibrationTopLeftY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lightGunCalibrationTopLeftX)).EndInit();
			this.lightGunCalibrationCentreGroup.ResumeLayout(false);
			this.lightGunCalibrationCentreGroup.PerformLayout();
			this.lightGunCalibrationCentreTable.ResumeLayout(false);
			this.lightGunCalibrationCentreTable.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.lightGunCalibrationCentreY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lightGunCalibrationCentreX)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer updateTimer;
		private ListView livePreviewFields;
		private ColumnHeader fieldHeader;
		private ColumnHeader valueHeader;
		private SplitContainer livePreviewSplit;
		private GroupBox inputGroup;
		private GroupBox forceFeedbackOutputGroup;
		private TableLayoutPanel outputForceFeedbackTable;
		private Label leftActuatorLabel;
		private Label rightActuatorLabel;
		private TrackBar leftActuatorStrength;
		private TrackBar rightActuatorStrength;
		private GroupBox fieldVisibilityGroup;
		private TableLayoutPanel fieldVisibilityTable;
		private RadioButton fieldVisibilityReported;
		private RadioButton fieldVisibilityAll;
		private Label fieldVisibilityLabel;
		private TableLayoutPanel baseRadioButtons;
		private RadioButton hexadecimalRadioButton;
		private RadioButton decimalRadioButton;
		private Label label1;
		private TableLayoutPanel controlTable;
		private GroupBox lightGunCalibrationGroup;
		private TableLayoutPanel lightGunCalibrationTable;
		private GroupBox lightGunCalibrationTopLeftGroup;
		private GroupBox lightGunCalibrationCentreGroup;
		private TableLayoutPanel lightGunCalibrationCentreTable;
		private TrackBar lightGunCalibrationCentreY;
		private Label lightGunCalibrationCentreYLabel;
		private TrackBar lightGunCalibrationCentreX;
		private Label lightGunCalibrationCentreXLabel;
		private TableLayoutPanel lightGunCalibrationTopLeftTable;
		private TrackBar lightGunCalibrationTopLeftY;
		private Label lightGunCalibrationTopLeftYLabel;
		private TrackBar lightGunCalibrationTopLeftX;
		private Label lightGunCalibrationTopLeftXLabel;
		private CheckBox lightGunCalibrateCentreCheckbox;
		private CheckBox lightGunCalibrateTopLeftCheckbox;
		private Panel leftActuatorPanel;
		private Panel rightActuatorPanel;
		private NumericUpDown leftActuatorSpinner;
		private NumericUpDown rightActuatorSpinner;
	}
}