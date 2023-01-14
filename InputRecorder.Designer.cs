namespace BeeDevelopment.XboxControllerAnalyser {
	partial class InputRecorder {
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
			this.recorderWorker = new System.ComponentModel.BackgroundWorker();
			this.endpointList = new System.Windows.Forms.ComboBox();
			this.recordedDataList = new System.Windows.Forms.ListView();
			this.recordedTimeColumn = new System.Windows.Forms.ColumnHeader();
			this.recordedDataLengthColumn = new System.Windows.Forms.ColumnHeader();
			this.recordedDataColumn = new System.Windows.Forms.ColumnHeader();
			this.endpointAndRecorderTable = new System.Windows.Forms.TableLayoutPanel();
			this.recordButton = new System.Windows.Forms.Button();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.fileSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.copyMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.clearMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.recordMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.editSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.endpointAndRecorderTable.SuspendLayout();
			this.mainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// recorderWorker
			// 
			this.recorderWorker.WorkerSupportsCancellation = true;
			this.recorderWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RecorderWorker_DoWork);
			this.recorderWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RecorderWorker_RunWorkerCompleted);
			// 
			// endpointList
			// 
			this.endpointList.Dock = System.Windows.Forms.DockStyle.Top;
			this.endpointList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.endpointList.FormattingEnabled = true;
			this.endpointList.Location = new System.Drawing.Point(3, 3);
			this.endpointList.Name = "endpointList";
			this.endpointList.Size = new System.Drawing.Size(694, 23);
			this.endpointList.TabIndex = 1;
			// 
			// recordedDataList
			// 
			this.recordedDataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.recordedTimeColumn,
            this.recordedDataLengthColumn,
            this.recordedDataColumn});
			this.recordedDataList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.recordedDataList.FullRowSelect = true;
			this.recordedDataList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.recordedDataList.Location = new System.Drawing.Point(0, 53);
			this.recordedDataList.Name = "recordedDataList";
			this.recordedDataList.Size = new System.Drawing.Size(800, 397);
			this.recordedDataList.TabIndex = 2;
			this.recordedDataList.UseCompatibleStateImageBehavior = false;
			this.recordedDataList.View = System.Windows.Forms.View.Details;
			// 
			// recordedTimeColumn
			// 
			this.recordedTimeColumn.Text = "Time";
			this.recordedTimeColumn.Width = 80;
			// 
			// recordedDataLengthColumn
			// 
			this.recordedDataLengthColumn.Text = "Length";
			this.recordedDataLengthColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// recordedDataColumn
			// 
			this.recordedDataColumn.Text = "Data";
			this.recordedDataColumn.Width = 600;
			// 
			// endpointAndRecorderTable
			// 
			this.endpointAndRecorderTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.endpointAndRecorderTable.ColumnCount = 2;
			this.endpointAndRecorderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.endpointAndRecorderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.endpointAndRecorderTable.Controls.Add(this.endpointList, 0, 0);
			this.endpointAndRecorderTable.Controls.Add(this.recordButton, 1, 0);
			this.endpointAndRecorderTable.Dock = System.Windows.Forms.DockStyle.Top;
			this.endpointAndRecorderTable.Location = new System.Drawing.Point(0, 24);
			this.endpointAndRecorderTable.Name = "endpointAndRecorderTable";
			this.endpointAndRecorderTable.RowCount = 1;
			this.endpointAndRecorderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.endpointAndRecorderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.endpointAndRecorderTable.Size = new System.Drawing.Size(800, 29);
			this.endpointAndRecorderTable.TabIndex = 4;
			// 
			// recordButton
			// 
			this.recordButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.recordButton.Location = new System.Drawing.Point(702, 2);
			this.recordButton.Margin = new System.Windows.Forms.Padding(2);
			this.recordButton.Name = "recordButton";
			this.recordButton.Size = new System.Drawing.Size(96, 25);
			this.recordButton.TabIndex = 0;
			this.recordButton.Text = "&Record";
			this.recordButton.UseVisualStyleBackColor = true;
			this.recordButton.Click += new System.EventHandler(this.RecordButton_Click);
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(800, 24);
			this.mainMenu.TabIndex = 5;
			this.mainMenu.Text = "menuStrip1";
			// 
			// fileMenu
			// 
			this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenu,
            this.fileSeparator,
            this.exitMenu});
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(37, 20);
			this.fileMenu.Text = "&File";
			this.fileMenu.DropDownClosed += new System.EventHandler(this.FileMenu_DropDownClosed);
			this.fileMenu.DropDownOpening += new System.EventHandler(this.FileMenu_DropDownOpening);
			// 
			// saveMenu
			// 
			this.saveMenu.Name = "saveMenu";
			this.saveMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveMenu.Size = new System.Drawing.Size(147, 22);
			this.saveMenu.Text = "&Save...";
			this.saveMenu.Click += new System.EventHandler(this.SaveMenu_Click);
			// 
			// fileSeparator
			// 
			this.fileSeparator.Name = "fileSeparator";
			this.fileSeparator.Size = new System.Drawing.Size(144, 6);
			// 
			// exitMenu
			// 
			this.exitMenu.Name = "exitMenu";
			this.exitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitMenu.Size = new System.Drawing.Size(147, 22);
			this.exitMenu.Text = "E&xit";
			this.exitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
			// 
			// editMenu
			// 
			this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordMenu,
            this.editSeparator,
            this.copyMenu,
            this.clearMenu});
			this.editMenu.Name = "editMenu";
			this.editMenu.Size = new System.Drawing.Size(39, 20);
			this.editMenu.Text = "&Edit";
			this.editMenu.DropDownClosed += new System.EventHandler(this.EditMenu_DropDownClosed);
			this.editMenu.DropDownOpening += new System.EventHandler(this.EditMenu_DropDownOpening);
			// 
			// copyMenu
			// 
			this.copyMenu.Name = "copyMenu";
			this.copyMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyMenu.Size = new System.Drawing.Size(181, 22);
			this.copyMenu.Text = "&Copy";
			this.copyMenu.Click += new System.EventHandler(this.CopyMenu_Click);
			// 
			// clearMenu
			// 
			this.clearMenu.Name = "clearMenu";
			this.clearMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
			this.clearMenu.Size = new System.Drawing.Size(181, 22);
			this.clearMenu.Text = "C&lear";
			this.clearMenu.Click += new System.EventHandler(this.ClearMenu_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "Text files (*.txt)|*.txt";
			// 
			// recordMenu
			// 
			this.recordMenu.Name = "recordMenu";
			this.recordMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.recordMenu.Size = new System.Drawing.Size(181, 22);
			this.recordMenu.Text = "&Record/Stop";
			this.recordMenu.Click += new System.EventHandler(this.RecordMenu_Click);
			// 
			// editSeparator
			// 
			this.editSeparator.Name = "editSeparator";
			this.editSeparator.Size = new System.Drawing.Size(178, 6);
			// 
			// InputRecorder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.recordedDataList);
			this.Controls.Add(this.endpointAndRecorderTable);
			this.Controls.Add(this.mainMenu);
			this.MainMenuStrip = this.mainMenu;
			this.Name = "InputRecorder";
			this.Text = "Input Recorder";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputRecorder_FormClosing);
			this.Load += new System.EventHandler(this.InputRecorder_Load);
			this.endpointAndRecorderTable.ResumeLayout(false);
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.ComponentModel.BackgroundWorker recorderWorker;
		private ComboBox endpointList;
		private ListView recordedDataList;
		private ColumnHeader recordedTimeColumn;
		private ColumnHeader recordedDataColumn;
		private TableLayoutPanel endpointAndRecorderTable;
		private Button recordButton;
		private ColumnHeader recordedDataLengthColumn;
		private MenuStrip mainMenu;
		private ToolStripMenuItem fileMenu;
		private ToolStripMenuItem saveMenu;
		private ToolStripSeparator fileSeparator;
		private ToolStripMenuItem exitMenu;
		private ToolStripMenuItem editMenu;
		private ToolStripMenuItem copyMenu;
		private ToolStripMenuItem clearMenu;
		private SaveFileDialog saveFileDialog;
		private ToolStripMenuItem recordMenu;
		private ToolStripSeparator editSeparator;
	}
}