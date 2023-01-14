namespace BeeDevelopment.XboxControllerAnalyser {
	partial class MainInterface {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.usbDeviceTree = new System.Windows.Forms.TreeView();
			this.usbDeviceInfo = new System.Windows.Forms.ListView();
			this.usbDeviceInfoFieldColumn = new System.Windows.Forms.ColumnHeader();
			this.usbDeviceInfoValueColumn = new System.Windows.Forms.ColumnHeader();
			this.usbDeviceInfoDescriptionColumn = new System.Windows.Forms.ColumnHeader();
			this.usbDeviceSplit = new System.Windows.Forms.SplitContainer();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.fileSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.copyMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.viewSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.livePreviewMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.inputRecorderMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.usbDeviceSplit)).BeginInit();
			this.usbDeviceSplit.Panel1.SuspendLayout();
			this.usbDeviceSplit.Panel2.SuspendLayout();
			this.usbDeviceSplit.SuspendLayout();
			this.mainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// usbDeviceTree
			// 
			this.usbDeviceTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.usbDeviceTree.Location = new System.Drawing.Point(0, 0);
			this.usbDeviceTree.Name = "usbDeviceTree";
			this.usbDeviceTree.Size = new System.Drawing.Size(266, 437);
			this.usbDeviceTree.TabIndex = 0;
			this.usbDeviceTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.UsbDeviceTree_AfterSelect);
			this.usbDeviceTree.DoubleClick += new System.EventHandler(this.UsbDeviceTree_DoubleClick);
			// 
			// usbDeviceInfo
			// 
			this.usbDeviceInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usbDeviceInfoFieldColumn,
            this.usbDeviceInfoValueColumn,
            this.usbDeviceInfoDescriptionColumn});
			this.usbDeviceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.usbDeviceInfo.FullRowSelect = true;
			this.usbDeviceInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.usbDeviceInfo.Location = new System.Drawing.Point(0, 0);
			this.usbDeviceInfo.Name = "usbDeviceInfo";
			this.usbDeviceInfo.Size = new System.Drawing.Size(674, 437);
			this.usbDeviceInfo.TabIndex = 2;
			this.usbDeviceInfo.UseCompatibleStateImageBehavior = false;
			this.usbDeviceInfo.View = System.Windows.Forms.View.Details;
			// 
			// usbDeviceInfoFieldColumn
			// 
			this.usbDeviceInfoFieldColumn.Text = "Field";
			this.usbDeviceInfoFieldColumn.Width = 200;
			// 
			// usbDeviceInfoValueColumn
			// 
			this.usbDeviceInfoValueColumn.Text = "Value";
			this.usbDeviceInfoValueColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.usbDeviceInfoValueColumn.Width = 150;
			// 
			// usbDeviceInfoDescriptionColumn
			// 
			this.usbDeviceInfoDescriptionColumn.Text = "Description";
			this.usbDeviceInfoDescriptionColumn.Width = 300;
			// 
			// usbDeviceSplit
			// 
			this.usbDeviceSplit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.usbDeviceSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.usbDeviceSplit.Location = new System.Drawing.Point(0, 24);
			this.usbDeviceSplit.Name = "usbDeviceSplit";
			// 
			// usbDeviceSplit.Panel1
			// 
			this.usbDeviceSplit.Panel1.Controls.Add(this.usbDeviceTree);
			// 
			// usbDeviceSplit.Panel2
			// 
			this.usbDeviceSplit.Panel2.Controls.Add(this.usbDeviceInfo);
			this.usbDeviceSplit.Size = new System.Drawing.Size(944, 437);
			this.usbDeviceSplit.SplitterDistance = 266;
			this.usbDeviceSplit.TabIndex = 3;
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(944, 24);
			this.mainMenuStrip.TabIndex = 4;
			this.mainMenuStrip.Text = "menuStrip1";
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
            this.copyMenu});
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
			this.copyMenu.Size = new System.Drawing.Size(144, 22);
			this.copyMenu.Text = "&Copy";
			this.copyMenu.Click += new System.EventHandler(this.CopyMenu_Click);
			// 
			// viewMenu
			// 
			this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshMenu,
            this.viewSeparator,
            this.livePreviewMenu,
            this.inputRecorderMenu});
			this.viewMenu.Name = "viewMenu";
			this.viewMenu.Size = new System.Drawing.Size(44, 20);
			this.viewMenu.Text = "&View";
			this.viewMenu.DropDownClosed += new System.EventHandler(this.ViewMenu_DropDownClosed);
			this.viewMenu.DropDownOpening += new System.EventHandler(this.ViewMenu_DropDownOpening);
			// 
			// refreshMenu
			// 
			this.refreshMenu.Name = "refreshMenu";
			this.refreshMenu.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.refreshMenu.Size = new System.Drawing.Size(180, 22);
			this.refreshMenu.Text = "&Refresh";
			this.refreshMenu.Click += new System.EventHandler(this.RefreshMenu_Click);
			// 
			// viewSeparator
			// 
			this.viewSeparator.Name = "viewSeparator";
			this.viewSeparator.Size = new System.Drawing.Size(177, 6);
			// 
			// livePreviewMenu
			// 
			this.livePreviewMenu.Name = "livePreviewMenu";
			this.livePreviewMenu.Size = new System.Drawing.Size(180, 22);
			this.livePreviewMenu.Text = "Live &Preview...";
			this.livePreviewMenu.Click += new System.EventHandler(this.LivePreviewMenu_Click);
			// 
			// inputRecorderMenu
			// 
			this.inputRecorderMenu.Name = "inputRecorderMenu";
			this.inputRecorderMenu.Size = new System.Drawing.Size(180, 22);
			this.inputRecorderMenu.Text = "&Input Recorder...";
			this.inputRecorderMenu.Click += new System.EventHandler(this.InputRecorderMenu_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "Text files (*.txt)|*.txt";
			// 
			// MainInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(944, 461);
			this.Controls.Add(this.usbDeviceSplit);
			this.Controls.Add(this.mainMenuStrip);
			this.KeyPreview = true;
			this.MainMenuStrip = this.mainMenuStrip;
			this.Name = "MainInterface";
			this.Load += new System.EventHandler(this.MainInterface_Load);
			this.usbDeviceSplit.Panel1.ResumeLayout(false);
			this.usbDeviceSplit.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.usbDeviceSplit)).EndInit();
			this.usbDeviceSplit.ResumeLayout(false);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TreeView usbDeviceTree;
		private ListView usbDeviceInfo;
		private ColumnHeader usbDeviceInfoFieldColumn;
		private ColumnHeader usbDeviceInfoValueColumn;
		private ColumnHeader usbDeviceInfoDescriptionColumn;
		private SplitContainer usbDeviceSplit;
		private MenuStrip mainMenuStrip;
		private ToolStripMenuItem fileMenu;
		private ToolStripMenuItem exitMenu;
		private ToolStripMenuItem viewMenu;
		private ToolStripMenuItem refreshMenu;
		private ToolStripMenuItem editMenu;
		private ToolStripMenuItem copyMenu;
		private ToolStripMenuItem saveMenu;
		private SaveFileDialog saveFileDialog;
		private ToolStripMenuItem livePreviewMenu;
		private ToolStripMenuItem inputRecorderMenu;
		private ToolStripSeparator fileSeparator;
		private ToolStripSeparator viewSeparator;
	}
}