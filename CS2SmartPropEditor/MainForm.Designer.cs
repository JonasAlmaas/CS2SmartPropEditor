namespace CS2SmartPropEditor;

partial class MainForm
{
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
		this.menuStrip1 = new MenuStrip();
		this.fileToolStripMenuItem = new ToolStripMenuItem();
		this.newToolStripMenuItem = new ToolStripMenuItem();
		this.createProjectToolStripMenuItem = new ToolStripMenuItem();
		this.smartPropToolStripMenuItem = new ToolStripMenuItem();
		this.openToolStripMenuItem = new ToolStripMenuItem();
		this.reloadFromDiskToolStripMenuItem = new ToolStripMenuItem();
		this.recentFilesToolStripMenuItem = new ToolStripMenuItem();
		this.toolStripSeparator2 = new ToolStripSeparator();
		this.saveToolStripMenuItem = new ToolStripMenuItem();
		this.saveAsToolStripMenuItem = new ToolStripMenuItem();
		this.toolStripSeparator1 = new ToolStripSeparator();
		this.exitToolStripMenuItem = new ToolStripMenuItem();
		this.editToolStripMenuItem = new ToolStripMenuItem();
		this.undoToolStripMenuItem = new ToolStripMenuItem();
		this.redoToolStripMenuItem = new ToolStripMenuItem();
		this.toolStripSeparator3 = new ToolStripSeparator();
		this.cutToolStripMenuItem = new ToolStripMenuItem();
		this.copyToolStripMenuItem = new ToolStripMenuItem();
		this.pasteToolStripMenuItem = new ToolStripMenuItem();
		this.duplicateToolStripMenuItem = new ToolStripMenuItem();
		this.toolStripSeparator4 = new ToolStripSeparator();
		this.deleteSelectedToolStripMenuItem = new ToolStripMenuItem();
		this.toolsToolStripMenuItem = new ToolStripMenuItem();
		this.settingsToolStripMenuItem1 = new ToolStripMenuItem();
		this.helpToolStripMenuItem = new ToolStripMenuItem();
		this.smartPropVDCToolStripMenuItem = new ToolStripMenuItem();
		this.toolStripTextBoxVersion = new ToolStripTextBox();
		this.openSmartProjectFileDialog = new OpenFileDialog();
		this.splitContainer1 = new SplitContainer();
		this.smartPropList = new ListView();
		this.splitContainer2 = new SplitContainer();
		this.tabControl1 = new TabControl();
		this.tabPageeditor = new TabPage();
		this.treeView1 = new TreeView();
		this.tabPageRaw = new TabPage();
		this.richTextBoxRawFile = new RichTextBox();
		this.panel1 = new Panel();
		this.groupBox1 = new GroupBox();
		this.groupBoxAttributes = new GroupBox();
		this.tableLayoutPanel1 = new TableLayoutPanel();
		this.label3 = new Label();
		this.textBoxSmartPropPath = new TextBox();
		this.textBoxSmartPropDescription = new TextBox();
		this.label1 = new Label();
		this.closeToolStripMenuItem = new ToolStripMenuItem();
		this.menuStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
		this.splitContainer1.Panel1.SuspendLayout();
		this.splitContainer1.Panel2.SuspendLayout();
		this.splitContainer1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.splitContainer2).BeginInit();
		this.splitContainer2.Panel1.SuspendLayout();
		this.splitContainer2.Panel2.SuspendLayout();
		this.splitContainer2.SuspendLayout();
		this.tabControl1.SuspendLayout();
		this.tabPageeditor.SuspendLayout();
		this.tabPageRaw.SuspendLayout();
		this.panel1.SuspendLayout();
		this.groupBoxAttributes.SuspendLayout();
		this.tableLayoutPanel1.SuspendLayout();
		this.SuspendLayout();
		// 
		// menuStrip1
		// 
		this.menuStrip1.BackColor = SystemColors.Control;
		this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.fileToolStripMenuItem, this.editToolStripMenuItem, this.toolsToolStripMenuItem, this.helpToolStripMenuItem, this.toolStripTextBoxVersion });
		this.menuStrip1.Location = new Point(0, 0);
		this.menuStrip1.Name = "menuStrip1";
		this.menuStrip1.Size = new Size(1064, 24);
		this.menuStrip1.TabIndex = 1;
		this.menuStrip1.Text = "menuStrip1";
		// 
		// fileToolStripMenuItem
		// 
		this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.newToolStripMenuItem, this.openToolStripMenuItem, this.reloadFromDiskToolStripMenuItem, this.recentFilesToolStripMenuItem, this.closeToolStripMenuItem, this.toolStripSeparator2, this.saveToolStripMenuItem, this.saveAsToolStripMenuItem, this.toolStripSeparator1, this.exitToolStripMenuItem });
		this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
		this.fileToolStripMenuItem.Size = new Size(37, 20);
		this.fileToolStripMenuItem.Text = "File";
		// 
		// newToolStripMenuItem
		// 
		this.newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.createProjectToolStripMenuItem, this.smartPropToolStripMenuItem });
		this.newToolStripMenuItem.Name = "newToolStripMenuItem";
		this.newToolStripMenuItem.Size = new Size(195, 22);
		this.newToolStripMenuItem.Text = "New";
		// 
		// createProjectToolStripMenuItem
		// 
		this.createProjectToolStripMenuItem.Name = "createProjectToolStripMenuItem";
		this.createProjectToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
		this.createProjectToolStripMenuItem.Size = new Size(195, 22);
		this.createProjectToolStripMenuItem.Text = "Project...";
		this.createProjectToolStripMenuItem.Click += this.createProjectToolStripMenuItem_Click;
		// 
		// smartPropToolStripMenuItem
		// 
		this.smartPropToolStripMenuItem.Enabled = false;
		this.smartPropToolStripMenuItem.Name = "smartPropToolStripMenuItem";
		this.smartPropToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
		this.smartPropToolStripMenuItem.Size = new Size(195, 22);
		this.smartPropToolStripMenuItem.Text = "Smart Prop...";
		// 
		// openToolStripMenuItem
		// 
		this.openToolStripMenuItem.Name = "openToolStripMenuItem";
		this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
		this.openToolStripMenuItem.Size = new Size(195, 22);
		this.openToolStripMenuItem.Text = "Open";
		this.openToolStripMenuItem.Click += this.openToolStripMenuItem_Click;
		// 
		// reloadFromDiskToolStripMenuItem
		// 
		this.reloadFromDiskToolStripMenuItem.Enabled = false;
		this.reloadFromDiskToolStripMenuItem.Name = "reloadFromDiskToolStripMenuItem";
		this.reloadFromDiskToolStripMenuItem.Size = new Size(195, 22);
		this.reloadFromDiskToolStripMenuItem.Text = "Reload From Disk";
		// 
		// recentFilesToolStripMenuItem
		// 
		this.recentFilesToolStripMenuItem.Enabled = false;
		this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
		this.recentFilesToolStripMenuItem.Size = new Size(195, 22);
		this.recentFilesToolStripMenuItem.Text = "Recent Files";
		// 
		// toolStripSeparator2
		// 
		this.toolStripSeparator2.Name = "toolStripSeparator2";
		this.toolStripSeparator2.Size = new Size(192, 6);
		// 
		// saveToolStripMenuItem
		// 
		this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
		this.saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
		this.saveToolStripMenuItem.Size = new Size(195, 22);
		this.saveToolStripMenuItem.Text = "Save";
		this.saveToolStripMenuItem.Click += this.saveToolStripMenuItem_Click;
		// 
		// saveAsToolStripMenuItem
		// 
		this.saveAsToolStripMenuItem.Enabled = false;
		this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
		this.saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
		this.saveAsToolStripMenuItem.Size = new Size(195, 22);
		this.saveAsToolStripMenuItem.Text = "Save As...";
		// 
		// toolStripSeparator1
		// 
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new Size(192, 6);
		// 
		// exitToolStripMenuItem
		// 
		this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
		this.exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
		this.exitToolStripMenuItem.Size = new Size(195, 22);
		this.exitToolStripMenuItem.Text = "Exit";
		this.exitToolStripMenuItem.Click += this.exitToolStripMenuItem_Click;
		// 
		// editToolStripMenuItem
		// 
		this.editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.undoToolStripMenuItem, this.redoToolStripMenuItem, this.toolStripSeparator3, this.cutToolStripMenuItem, this.copyToolStripMenuItem, this.pasteToolStripMenuItem, this.duplicateToolStripMenuItem, this.toolStripSeparator4, this.deleteSelectedToolStripMenuItem });
		this.editToolStripMenuItem.Name = "editToolStripMenuItem";
		this.editToolStripMenuItem.Size = new Size(39, 20);
		this.editToolStripMenuItem.Text = "Edit";
		// 
		// undoToolStripMenuItem
		// 
		this.undoToolStripMenuItem.Enabled = false;
		this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
		this.undoToolStripMenuItem.Size = new Size(180, 22);
		this.undoToolStripMenuItem.Text = "Undo";
		// 
		// redoToolStripMenuItem
		// 
		this.redoToolStripMenuItem.Enabled = false;
		this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
		this.redoToolStripMenuItem.Size = new Size(180, 22);
		this.redoToolStripMenuItem.Text = "Redo";
		// 
		// toolStripSeparator3
		// 
		this.toolStripSeparator3.Name = "toolStripSeparator3";
		this.toolStripSeparator3.Size = new Size(177, 6);
		// 
		// cutToolStripMenuItem
		// 
		this.cutToolStripMenuItem.Enabled = false;
		this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
		this.cutToolStripMenuItem.Size = new Size(180, 22);
		this.cutToolStripMenuItem.Text = "Cut";
		// 
		// copyToolStripMenuItem
		// 
		this.copyToolStripMenuItem.Enabled = false;
		this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
		this.copyToolStripMenuItem.Size = new Size(180, 22);
		this.copyToolStripMenuItem.Text = "Copy";
		// 
		// pasteToolStripMenuItem
		// 
		this.pasteToolStripMenuItem.Enabled = false;
		this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
		this.pasteToolStripMenuItem.Size = new Size(180, 22);
		this.pasteToolStripMenuItem.Text = "Paste";
		// 
		// duplicateToolStripMenuItem
		// 
		this.duplicateToolStripMenuItem.Enabled = false;
		this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
		this.duplicateToolStripMenuItem.Size = new Size(180, 22);
		this.duplicateToolStripMenuItem.Text = "Duplicate";
		// 
		// toolStripSeparator4
		// 
		this.toolStripSeparator4.Name = "toolStripSeparator4";
		this.toolStripSeparator4.Size = new Size(177, 6);
		// 
		// deleteSelectedToolStripMenuItem
		// 
		this.deleteSelectedToolStripMenuItem.Enabled = false;
		this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
		this.deleteSelectedToolStripMenuItem.Size = new Size(180, 22);
		this.deleteSelectedToolStripMenuItem.Text = "Delete Selected";
		// 
		// toolsToolStripMenuItem
		// 
		this.toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.settingsToolStripMenuItem1 });
		this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
		this.toolsToolStripMenuItem.Size = new Size(46, 20);
		this.toolsToolStripMenuItem.Text = "Tools";
		// 
		// settingsToolStripMenuItem1
		// 
		this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
		this.settingsToolStripMenuItem1.Size = new Size(180, 22);
		this.settingsToolStripMenuItem1.Text = "Settings";
		this.settingsToolStripMenuItem1.Click += this.settingsToolStripMenuItem1_Click;
		// 
		// helpToolStripMenuItem
		// 
		this.helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.smartPropVDCToolStripMenuItem });
		this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
		this.helpToolStripMenuItem.Size = new Size(44, 20);
		this.helpToolStripMenuItem.Text = "Help";
		// 
		// smartPropVDCToolStripMenuItem
		// 
		this.smartPropVDCToolStripMenuItem.Image = Properties.Resources.s2_logo_182;
		this.smartPropVDCToolStripMenuItem.Name = "smartPropVDCToolStripMenuItem";
		this.smartPropVDCToolStripMenuItem.Size = new Size(180, 22);
		this.smartPropVDCToolStripMenuItem.Text = "Smart Prop VDC";
		this.smartPropVDCToolStripMenuItem.Click += this.smartPropVDCToolStripMenuItem_Click;
		// 
		// toolStripTextBoxVersion
		// 
		this.toolStripTextBoxVersion.Alignment = ToolStripItemAlignment.Right;
		this.toolStripTextBoxVersion.BackColor = SystemColors.Control;
		this.toolStripTextBoxVersion.BorderStyle = BorderStyle.None;
		this.toolStripTextBoxVersion.CausesValidation = false;
		this.toolStripTextBoxVersion.Margin = new Padding(1, 0, 3, 0);
		this.toolStripTextBoxVersion.Name = "toolStripTextBoxVersion";
		this.toolStripTextBoxVersion.Overflow = ToolStripItemOverflow.Never;
		this.toolStripTextBoxVersion.ReadOnly = true;
		this.toolStripTextBoxVersion.ShortcutsEnabled = false;
		this.toolStripTextBoxVersion.Size = new Size(50, 20);
		this.toolStripTextBoxVersion.Text = "10.00.00";
		this.toolStripTextBoxVersion.TextBoxTextAlign = HorizontalAlignment.Right;
		// 
		// openSmartProjectFileDialog
		// 
		this.openSmartProjectFileDialog.DefaultExt = "smartproj";
		this.openSmartProjectFileDialog.Filter = "Smart project files|*.smartproj|All files|*.*";
		// 
		// splitContainer1
		// 
		this.splitContainer1.Dock = DockStyle.Fill;
		this.splitContainer1.Location = new Point(0, 24);
		this.splitContainer1.Name = "splitContainer1";
		// 
		// splitContainer1.Panel1
		// 
		this.splitContainer1.Panel1.Controls.Add(this.smartPropList);
		// 
		// splitContainer1.Panel2
		// 
		this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
		this.splitContainer1.Size = new Size(1064, 587);
		this.splitContainer1.SplitterDistance = 283;
		this.splitContainer1.TabIndex = 3;
		// 
		// smartPropList
		// 
		this.smartPropList.Dock = DockStyle.Fill;
		this.smartPropList.Location = new Point(0, 0);
		this.smartPropList.Name = "smartPropList";
		this.smartPropList.Size = new Size(283, 587);
		this.smartPropList.TabIndex = 2;
		this.smartPropList.UseCompatibleStateImageBehavior = false;
		this.smartPropList.SelectedIndexChanged += this.smartPropList_SelectedIndexChanged;
		// 
		// splitContainer2
		// 
		this.splitContainer2.Dock = DockStyle.Fill;
		this.splitContainer2.Location = new Point(0, 0);
		this.splitContainer2.Name = "splitContainer2";
		// 
		// splitContainer2.Panel1
		// 
		this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
		// 
		// splitContainer2.Panel2
		// 
		this.splitContainer2.Panel2.Controls.Add(this.panel1);
		this.splitContainer2.Size = new Size(777, 587);
		this.splitContainer2.SplitterDistance = 489;
		this.splitContainer2.TabIndex = 0;
		// 
		// tabControl1
		// 
		this.tabControl1.Controls.Add(this.tabPageeditor);
		this.tabControl1.Controls.Add(this.tabPageRaw);
		this.tabControl1.Dock = DockStyle.Fill;
		this.tabControl1.Location = new Point(0, 0);
		this.tabControl1.Margin = new Padding(0);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new Size(489, 587);
		this.tabControl1.TabIndex = 2;
		// 
		// tabPageeditor
		// 
		this.tabPageeditor.Controls.Add(this.treeView1);
		this.tabPageeditor.Location = new Point(4, 24);
		this.tabPageeditor.Name = "tabPageeditor";
		this.tabPageeditor.Padding = new Padding(3);
		this.tabPageeditor.Size = new Size(481, 559);
		this.tabPageeditor.TabIndex = 0;
		this.tabPageeditor.Text = "Editor";
		this.tabPageeditor.UseVisualStyleBackColor = true;
		// 
		// treeView1
		// 
		this.treeView1.Dock = DockStyle.Fill;
		this.treeView1.Location = new Point(3, 3);
		this.treeView1.Name = "treeView1";
		this.treeView1.Size = new Size(475, 553);
		this.treeView1.TabIndex = 0;
		// 
		// tabPageRaw
		// 
		this.tabPageRaw.Controls.Add(this.richTextBoxRawFile);
		this.tabPageRaw.Location = new Point(4, 24);
		this.tabPageRaw.Name = "tabPageRaw";
		this.tabPageRaw.Padding = new Padding(3);
		this.tabPageRaw.Size = new Size(481, 559);
		this.tabPageRaw.TabIndex = 1;
		this.tabPageRaw.Text = "Raw";
		this.tabPageRaw.UseVisualStyleBackColor = true;
		// 
		// richTextBoxRawFile
		// 
		this.richTextBoxRawFile.Dock = DockStyle.Fill;
		this.richTextBoxRawFile.Location = new Point(3, 3);
		this.richTextBoxRawFile.Name = "richTextBoxRawFile";
		this.richTextBoxRawFile.ReadOnly = true;
		this.richTextBoxRawFile.Size = new Size(475, 553);
		this.richTextBoxRawFile.TabIndex = 0;
		this.richTextBoxRawFile.Text = "";
		this.richTextBoxRawFile.WordWrap = false;
		// 
		// panel1
		// 
		this.panel1.BackColor = SystemColors.Window;
		this.panel1.BorderStyle = BorderStyle.Fixed3D;
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Controls.Add(this.groupBoxAttributes);
		this.panel1.Dock = DockStyle.Fill;
		this.panel1.ForeColor = SystemColors.WindowText;
		this.panel1.Location = new Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Padding = new Padding(3, 0, 3, 3);
		this.panel1.Size = new Size(284, 587);
		this.panel1.TabIndex = 4;
		// 
		// groupBox1
		// 
		this.groupBox1.Dock = DockStyle.Top;
		this.groupBox1.Location = new Point(3, 80);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new Size(274, 100);
		this.groupBox1.TabIndex = 5;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Variables";
		// 
		// groupBoxAttributes
		// 
		this.groupBoxAttributes.AutoSize = true;
		this.groupBoxAttributes.Controls.Add(this.tableLayoutPanel1);
		this.groupBoxAttributes.Dock = DockStyle.Top;
		this.groupBoxAttributes.Location = new Point(3, 0);
		this.groupBoxAttributes.Name = "groupBoxAttributes";
		this.groupBoxAttributes.Size = new Size(274, 80);
		this.groupBoxAttributes.TabIndex = 4;
		this.groupBoxAttributes.TabStop = false;
		this.groupBoxAttributes.Text = "Attributes";
		// 
		// tableLayoutPanel1
		// 
		this.tableLayoutPanel1.AutoSize = true;
		this.tableLayoutPanel1.BackColor = SystemColors.Window;
		this.tableLayoutPanel1.ColumnCount = 2;
		this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
		this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
		this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
		this.tableLayoutPanel1.Controls.Add(this.textBoxSmartPropPath, 0, 5);
		this.tableLayoutPanel1.Controls.Add(this.textBoxSmartPropDescription, 1, 0);
		this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
		this.tableLayoutPanel1.Dock = DockStyle.Fill;
		this.tableLayoutPanel1.Location = new Point(3, 19);
		this.tableLayoutPanel1.Name = "tableLayoutPanel1";
		this.tableLayoutPanel1.RowCount = 6;
		this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel1.Size = new Size(268, 58);
		this.tableLayoutPanel1.TabIndex = 3;
		// 
		// label3
		// 
		this.label3.AutoSize = true;
		this.label3.Dock = DockStyle.Fill;
		this.label3.Location = new Point(3, 29);
		this.label3.Name = "label3";
		this.label3.Size = new Size(67, 29);
		this.label3.TabIndex = 5;
		this.label3.Text = "Path";
		this.label3.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// textBoxSmartPropPath
		// 
		this.textBoxSmartPropPath.Dock = DockStyle.Fill;
		this.textBoxSmartPropPath.Location = new Point(76, 32);
		this.textBoxSmartPropPath.Name = "textBoxSmartPropPath";
		this.textBoxSmartPropPath.Size = new Size(195, 23);
		this.textBoxSmartPropPath.TabIndex = 4;
		// 
		// textBoxSmartPropDescription
		// 
		this.textBoxSmartPropDescription.Dock = DockStyle.Fill;
		this.textBoxSmartPropDescription.Location = new Point(76, 3);
		this.textBoxSmartPropDescription.Name = "textBoxSmartPropDescription";
		this.textBoxSmartPropDescription.Size = new Size(195, 23);
		this.textBoxSmartPropDescription.TabIndex = 1;
		// 
		// label1
		// 
		this.label1.AutoSize = true;
		this.label1.Dock = DockStyle.Fill;
		this.label1.Location = new Point(3, 0);
		this.label1.Name = "label1";
		this.label1.Size = new Size(67, 29);
		this.label1.TabIndex = 2;
		this.label1.Text = "Description";
		this.label1.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// closeToolStripMenuItem
		// 
		this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
		this.closeToolStripMenuItem.Size = new Size(195, 22);
		this.closeToolStripMenuItem.Text = "Close";
		this.closeToolStripMenuItem.Click += this.closeToolStripMenuItem_Click;
		// 
		// MainForm
		// 
		this.AllowDrop = true;
		this.AutoScaleDimensions = new SizeF(7F, 15F);
		this.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = SystemColors.Control;
		this.ClientSize = new Size(1064, 611);
		this.Controls.Add(this.splitContainer1);
		this.Controls.Add(this.menuStrip1);
		this.MainMenuStrip = this.menuStrip1;
		this.Margin = new Padding(2);
		this.Name = "MainForm";
		this.Text = "CS2 Smart-Prop Editor";
		this.DragDrop += this.MainForm_DragDrop;
		this.DragEnter += this.MainForm_DragEnter;
		this.menuStrip1.ResumeLayout(false);
		this.menuStrip1.PerformLayout();
		this.splitContainer1.Panel1.ResumeLayout(false);
		this.splitContainer1.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
		this.splitContainer1.ResumeLayout(false);
		this.splitContainer2.Panel1.ResumeLayout(false);
		this.splitContainer2.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.splitContainer2).EndInit();
		this.splitContainer2.ResumeLayout(false);
		this.tabControl1.ResumeLayout(false);
		this.tabPageeditor.ResumeLayout(false);
		this.tabPageRaw.ResumeLayout(false);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.groupBoxAttributes.ResumeLayout(false);
		this.groupBoxAttributes.PerformLayout();
		this.tableLayoutPanel1.ResumeLayout(false);
		this.tableLayoutPanel1.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private MenuStrip menuStrip1;
	private ToolStripMenuItem fileToolStripMenuItem;
	private ToolStripMenuItem saveToolStripMenuItem;
	private ToolStripMenuItem editToolStripMenuItem;
	private ToolStripMenuItem toolsToolStripMenuItem;
	private ToolStripMenuItem newToolStripMenuItem;
	private ToolStripMenuItem saveAsToolStripMenuItem;
	private ToolStripMenuItem createProjectToolStripMenuItem;
	private ToolStripMenuItem smartPropToolStripMenuItem;
	private ToolStripMenuItem exitToolStripMenuItem;
	private ToolStripSeparator toolStripSeparator1;
	private ToolStripMenuItem openToolStripMenuItem;
	private ToolStripSeparator toolStripSeparator2;
	private ToolStripMenuItem undoToolStripMenuItem;
	private ToolStripMenuItem redoToolStripMenuItem;
	private ToolStripSeparator toolStripSeparator3;
	private ToolStripMenuItem cutToolStripMenuItem;
	private ToolStripMenuItem copyToolStripMenuItem;
	private ToolStripMenuItem pasteToolStripMenuItem;
	private ToolStripMenuItem duplicateToolStripMenuItem;
	private ToolStripSeparator toolStripSeparator4;
	private ToolStripMenuItem deleteSelectedToolStripMenuItem;
	private ToolStripMenuItem reloadFromDiskToolStripMenuItem;
	private ToolStripMenuItem recentFilesToolStripMenuItem;
	private ToolStripMenuItem settingsToolStripMenuItem1;
	private OpenFileDialog openSmartProjectFileDialog;
	private ToolStripMenuItem helpToolStripMenuItem;
	private ToolStripMenuItem smartPropVDCToolStripMenuItem;
	private SplitContainer splitContainer1;
	private ToolStripMenuItem versionToolStripMenuItem;
	private ToolStripTextBox toolStripTextBoxVersion;
	private SplitContainer splitContainer2;
	private ListView smartPropList;
	private TextBox textBoxSmartPropDescription;
	private Label label1;
	private TableLayoutPanel tableLayoutPanel1;
	private Label label3;
	private TextBox textBoxSmartPropPath;
	private Panel panel1;
	private GroupBox groupBox1;
	private GroupBox groupBoxAttributes;
	private TabControl tabControl1;
	private TabPage tabPageeditor;
	private TabPage tabPageRaw;
	private TreeView treeView1;
	private RichTextBox richTextBoxRawFile;
	private ToolStripMenuItem closeToolStripMenuItem;
}
