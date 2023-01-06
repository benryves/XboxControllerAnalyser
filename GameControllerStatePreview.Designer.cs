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
			this.outputSplit = new System.Windows.Forms.SplitContainer();
			this.outputGroup = new System.Windows.Forms.GroupBox();
			this.outputTable = new System.Windows.Forms.TableLayoutPanel();
			this.leftActuatorLabel = new System.Windows.Forms.Label();
			this.rightActuatorLabel = new System.Windows.Forms.Label();
			this.leftActuatorStrength = new System.Windows.Forms.TrackBar();
			this.rightActuatorStrength = new System.Windows.Forms.TrackBar();
			this.fieldVisibilityGroup = new System.Windows.Forms.GroupBox();
			this.fieldVisibilityTable = new System.Windows.Forms.TableLayoutPanel();
			this.fieldVisibilityReported = new System.Windows.Forms.RadioButton();
			this.fieldVisibilityAll = new System.Windows.Forms.RadioButton();
			this.fieldVisibilityLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.livePreviewSplit)).BeginInit();
			this.livePreviewSplit.Panel1.SuspendLayout();
			this.livePreviewSplit.Panel2.SuspendLayout();
			this.livePreviewSplit.SuspendLayout();
			this.inputGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.outputSplit)).BeginInit();
			this.outputSplit.Panel1.SuspendLayout();
			this.outputSplit.Panel2.SuspendLayout();
			this.outputSplit.SuspendLayout();
			this.outputGroup.SuspendLayout();
			this.outputTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.leftActuatorStrength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rightActuatorStrength)).BeginInit();
			this.fieldVisibilityGroup.SuspendLayout();
			this.fieldVisibilityTable.SuspendLayout();
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
			this.livePreviewFields.Size = new System.Drawing.Size(380, 413);
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
			// 
			// livePreviewSplit.Panel2
			// 
			this.livePreviewSplit.Panel2.Controls.Add(this.outputSplit);
			this.livePreviewSplit.Size = new System.Drawing.Size(776, 435);
			this.livePreviewSplit.SplitterDistance = 386;
			this.livePreviewSplit.TabIndex = 1;
			// 
			// inputGroup
			// 
			this.inputGroup.Controls.Add(this.livePreviewFields);
			this.inputGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputGroup.Location = new System.Drawing.Point(0, 0);
			this.inputGroup.Name = "inputGroup";
			this.inputGroup.Size = new System.Drawing.Size(386, 435);
			this.inputGroup.TabIndex = 0;
			this.inputGroup.TabStop = false;
			this.inputGroup.Text = "Input";
			// 
			// outputSplit
			// 
			this.outputSplit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.outputSplit.Location = new System.Drawing.Point(0, 0);
			this.outputSplit.Name = "outputSplit";
			this.outputSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// outputSplit.Panel1
			// 
			this.outputSplit.Panel1.Controls.Add(this.outputGroup);
			// 
			// outputSplit.Panel2
			// 
			this.outputSplit.Panel2.Controls.Add(this.fieldVisibilityGroup);
			this.outputSplit.Size = new System.Drawing.Size(386, 435);
			this.outputSplit.SplitterDistance = 260;
			this.outputSplit.TabIndex = 1;
			// 
			// outputGroup
			// 
			this.outputGroup.Controls.Add(this.outputTable);
			this.outputGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputGroup.Location = new System.Drawing.Point(0, 0);
			this.outputGroup.Name = "outputGroup";
			this.outputGroup.Size = new System.Drawing.Size(386, 260);
			this.outputGroup.TabIndex = 0;
			this.outputGroup.TabStop = false;
			this.outputGroup.Text = "Output";
			// 
			// outputTable
			// 
			this.outputTable.ColumnCount = 1;
			this.outputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.outputTable.Controls.Add(this.leftActuatorLabel, 0, 0);
			this.outputTable.Controls.Add(this.rightActuatorLabel, 0, 2);
			this.outputTable.Controls.Add(this.leftActuatorStrength, 0, 1);
			this.outputTable.Controls.Add(this.rightActuatorStrength, 0, 3);
			this.outputTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputTable.Location = new System.Drawing.Point(3, 19);
			this.outputTable.Name = "outputTable";
			this.outputTable.RowCount = 4;
			this.outputTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.outputTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.outputTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.outputTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.outputTable.Size = new System.Drawing.Size(380, 238);
			this.outputTable.TabIndex = 0;
			// 
			// leftActuatorLabel
			// 
			this.leftActuatorLabel.AutoSize = true;
			this.leftActuatorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.leftActuatorLabel.Location = new System.Drawing.Point(3, 44);
			this.leftActuatorLabel.Name = "leftActuatorLabel";
			this.leftActuatorLabel.Size = new System.Drawing.Size(374, 15);
			this.leftActuatorLabel.TabIndex = 0;
			this.leftActuatorLabel.Text = "Left Actuator Strength";
			// 
			// rightActuatorLabel
			// 
			this.rightActuatorLabel.AutoSize = true;
			this.rightActuatorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.rightActuatorLabel.Location = new System.Drawing.Point(3, 162);
			this.rightActuatorLabel.Name = "rightActuatorLabel";
			this.rightActuatorLabel.Size = new System.Drawing.Size(374, 15);
			this.rightActuatorLabel.TabIndex = 1;
			this.rightActuatorLabel.Text = "Right Actuator Strength";
			// 
			// leftActuatorStrength
			// 
			this.leftActuatorStrength.Dock = System.Windows.Forms.DockStyle.Top;
			this.leftActuatorStrength.LargeChange = 8192;
			this.leftActuatorStrength.Location = new System.Drawing.Point(3, 62);
			this.leftActuatorStrength.Maximum = 65535;
			this.leftActuatorStrength.Name = "leftActuatorStrength";
			this.leftActuatorStrength.Size = new System.Drawing.Size(374, 45);
			this.leftActuatorStrength.SmallChange = 2048;
			this.leftActuatorStrength.TabIndex = 2;
			this.leftActuatorStrength.TickFrequency = 2048;
			// 
			// rightActuatorStrength
			// 
			this.rightActuatorStrength.Dock = System.Windows.Forms.DockStyle.Top;
			this.rightActuatorStrength.LargeChange = 8192;
			this.rightActuatorStrength.Location = new System.Drawing.Point(3, 180);
			this.rightActuatorStrength.Maximum = 65535;
			this.rightActuatorStrength.Name = "rightActuatorStrength";
			this.rightActuatorStrength.Size = new System.Drawing.Size(374, 45);
			this.rightActuatorStrength.SmallChange = 2048;
			this.rightActuatorStrength.TabIndex = 3;
			this.rightActuatorStrength.TickFrequency = 2048;
			// 
			// fieldVisibilityGroup
			// 
			this.fieldVisibilityGroup.Controls.Add(this.fieldVisibilityTable);
			this.fieldVisibilityGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fieldVisibilityGroup.Location = new System.Drawing.Point(0, 0);
			this.fieldVisibilityGroup.Name = "fieldVisibilityGroup";
			this.fieldVisibilityGroup.Size = new System.Drawing.Size(386, 171);
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
			this.fieldVisibilityTable.Size = new System.Drawing.Size(380, 149);
			this.fieldVisibilityTable.TabIndex = 1;
			// 
			// fieldVisibilityReported
			// 
			this.fieldVisibilityReported.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.fieldVisibilityReported.AutoSize = true;
			this.fieldVisibilityReported.Checked = true;
			this.fieldVisibilityReported.Location = new System.Drawing.Point(3, 94);
			this.fieldVisibilityReported.Name = "fieldVisibilityReported";
			this.fieldVisibilityReported.Size = new System.Drawing.Size(160, 19);
			this.fieldVisibilityReported.TabIndex = 0;
			this.fieldVisibilityReported.TabStop = true;
			this.fieldVisibilityReported.Text = "Only show reported fields";
			this.fieldVisibilityReported.UseVisualStyleBackColor = true;
			this.fieldVisibilityReported.CheckedChanged += new System.EventHandler(this.FieldVisibility_CheckedChanged);
			// 
			// fieldVisibilityAll
			// 
			this.fieldVisibilityAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.fieldVisibilityAll.AutoSize = true;
			this.fieldVisibilityAll.Location = new System.Drawing.Point(3, 124);
			this.fieldVisibilityAll.Name = "fieldVisibilityAll";
			this.fieldVisibilityAll.Size = new System.Drawing.Size(100, 19);
			this.fieldVisibilityAll.TabIndex = 1;
			this.fieldVisibilityAll.Text = "Show all fields";
			this.fieldVisibilityAll.UseVisualStyleBackColor = true;
			this.fieldVisibilityAll.CheckedChanged += new System.EventHandler(this.FieldVisibility_CheckedChanged);
			// 
			// fieldVisibilityLabel
			// 
			this.fieldVisibilityLabel.AutoEllipsis = true;
			this.fieldVisibilityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fieldVisibilityLabel.Location = new System.Drawing.Point(3, 0);
			this.fieldVisibilityLabel.Name = "fieldVisibilityLabel";
			this.fieldVisibilityLabel.Size = new System.Drawing.Size(374, 89);
			this.fieldVisibilityLabel.TabIndex = 2;
			this.fieldVisibilityLabel.Text = resources.GetString("fieldVisibilityLabel.Text");
			// 
			// GameControllerStatePreview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 441);
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
			this.outputSplit.Panel1.ResumeLayout(false);
			this.outputSplit.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.outputSplit)).EndInit();
			this.outputSplit.ResumeLayout(false);
			this.outputGroup.ResumeLayout(false);
			this.outputTable.ResumeLayout(false);
			this.outputTable.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.leftActuatorStrength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rightActuatorStrength)).EndInit();
			this.fieldVisibilityGroup.ResumeLayout(false);
			this.fieldVisibilityTable.ResumeLayout(false);
			this.fieldVisibilityTable.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer updateTimer;
		private ListView livePreviewFields;
		private ColumnHeader fieldHeader;
		private ColumnHeader valueHeader;
		private SplitContainer livePreviewSplit;
		private GroupBox inputGroup;
		private GroupBox outputGroup;
		private TableLayoutPanel outputTable;
		private Label leftActuatorLabel;
		private Label rightActuatorLabel;
		private TrackBar leftActuatorStrength;
		private TrackBar rightActuatorStrength;
		private SplitContainer outputSplit;
		private GroupBox fieldVisibilityGroup;
		private TableLayoutPanel fieldVisibilityTable;
		private RadioButton fieldVisibilityReported;
		private RadioButton fieldVisibilityAll;
		private Label fieldVisibilityLabel;
	}
}