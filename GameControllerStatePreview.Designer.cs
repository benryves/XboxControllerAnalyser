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
			this.livePreviewFields.Location = new System.Drawing.Point(0, 0);
			this.livePreviewFields.Name = "livePreviewFields";
			this.livePreviewFields.Size = new System.Drawing.Size(384, 421);
			this.livePreviewFields.TabIndex = 0;
			this.livePreviewFields.UseCompatibleStateImageBehavior = false;
			this.livePreviewFields.View = System.Windows.Forms.View.Details;
			// 
			// fieldHeader
			// 
			this.fieldHeader.Text = "Field";
			this.fieldHeader.Width = 180;
			// 
			// valueHeader
			// 
			this.valueHeader.Text = "Value";
			this.valueHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.valueHeader.Width = 180;
			// 
			// GameControllerStatePreview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 421);
			this.Controls.Add(this.livePreviewFields);
			this.Name = "GameControllerStatePreview";
			this.Text = "Live Preview";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameControllerStatePreview_FormClosing);
			this.Load += new System.EventHandler(this.GameControllerStatePreview_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer updateTimer;
		private ListView livePreviewFields;
		private ColumnHeader fieldHeader;
		private ColumnHeader valueHeader;
	}
}