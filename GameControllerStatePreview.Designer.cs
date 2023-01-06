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
			this.updateTimer = new System.Windows.Forms.Timer(this.components);
			this.livePreviewFields = new System.Windows.Forms.ListView();
			this.fieldHeader = new System.Windows.Forms.ColumnHeader();
			this.valueHeader = new System.Windows.Forms.ColumnHeader();
			this.livePreviewSplit = new System.Windows.Forms.SplitContainer();
			this.inputGroup = new System.Windows.Forms.GroupBox();
			this.outputGroup = new System.Windows.Forms.GroupBox();
			this.outputTable = new System.Windows.Forms.TableLayoutPanel();
			this.leftActuatorLabel = new System.Windows.Forms.Label();
			this.rightActuatorLabel = new System.Windows.Forms.Label();
			this.leftActuatorStrength = new System.Windows.Forms.TrackBar();
			this.rightActuatorStrength = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.livePreviewSplit)).BeginInit();
			this.livePreviewSplit.Panel1.SuspendLayout();
			this.livePreviewSplit.Panel2.SuspendLayout();
			this.livePreviewSplit.SuspendLayout();
			this.inputGroup.SuspendLayout();
			this.outputGroup.SuspendLayout();
			this.outputTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.leftActuatorStrength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rightActuatorStrength)).BeginInit();
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
			this.livePreviewSplit.Panel2.Controls.Add(this.outputGroup);
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
			// outputGroup
			// 
			this.outputGroup.Controls.Add(this.outputTable);
			this.outputGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputGroup.Location = new System.Drawing.Point(0, 0);
			this.outputGroup.Name = "outputGroup";
			this.outputGroup.Size = new System.Drawing.Size(386, 435);
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
			this.outputTable.Size = new System.Drawing.Size(380, 413);
			this.outputTable.TabIndex = 0;
			// 
			// leftActuatorLabel
			// 
			this.leftActuatorLabel.AutoSize = true;
			this.leftActuatorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.leftActuatorLabel.Location = new System.Drawing.Point(3, 88);
			this.leftActuatorLabel.Name = "leftActuatorLabel";
			this.leftActuatorLabel.Size = new System.Drawing.Size(374, 15);
			this.leftActuatorLabel.TabIndex = 0;
			this.leftActuatorLabel.Text = "Left Actuator Strength";
			// 
			// rightActuatorLabel
			// 
			this.rightActuatorLabel.AutoSize = true;
			this.rightActuatorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.rightActuatorLabel.Location = new System.Drawing.Point(3, 294);
			this.rightActuatorLabel.Name = "rightActuatorLabel";
			this.rightActuatorLabel.Size = new System.Drawing.Size(374, 15);
			this.rightActuatorLabel.TabIndex = 1;
			this.rightActuatorLabel.Text = "Right Actuator Strength";
			// 
			// leftActuatorStrength
			// 
			this.leftActuatorStrength.Dock = System.Windows.Forms.DockStyle.Top;
			this.leftActuatorStrength.LargeChange = 8192;
			this.leftActuatorStrength.Location = new System.Drawing.Point(3, 106);
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
			this.rightActuatorStrength.Location = new System.Drawing.Point(3, 312);
			this.rightActuatorStrength.Maximum = 65535;
			this.rightActuatorStrength.Name = "rightActuatorStrength";
			this.rightActuatorStrength.Size = new System.Drawing.Size(374, 45);
			this.rightActuatorStrength.SmallChange = 2048;
			this.rightActuatorStrength.TabIndex = 3;
			this.rightActuatorStrength.TickFrequency = 2048;
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
			this.outputGroup.ResumeLayout(false);
			this.outputTable.ResumeLayout(false);
			this.outputTable.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.leftActuatorStrength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rightActuatorStrength)).EndInit();
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
	}
}