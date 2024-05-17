﻿namespace CS2SmartPropEditor;

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
		this.openSmartProjectFileDialog = new OpenFileDialog();
		this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
		this.fileSystemWatcher1 = new FileSystemWatcher();
		this.menuStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.fileSystemWatcher1).BeginInit();
		this.SuspendLayout();
		// 
		// menuStrip1
		// 
		this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.fileToolStripMenuItem, this.editToolStripMenuItem, this.toolsToolStripMenuItem, this.helpToolStripMenuItem });
		this.menuStrip1.Location = new Point(0, 0);
		this.menuStrip1.Name = "menuStrip1";
		this.menuStrip1.Size = new Size(896, 24);
		this.menuStrip1.TabIndex = 1;
		this.menuStrip1.Text = "menuStrip1";
		// 
		// fileToolStripMenuItem
		// 
		this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.newToolStripMenuItem, this.openToolStripMenuItem, this.reloadFromDiskToolStripMenuItem, this.recentFilesToolStripMenuItem, this.toolStripSeparator2, this.saveToolStripMenuItem, this.saveAsToolStripMenuItem, this.toolStripSeparator1, this.exitToolStripMenuItem });
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
		this.undoToolStripMenuItem.Size = new Size(154, 22);
		this.undoToolStripMenuItem.Text = "Undo";
		// 
		// redoToolStripMenuItem
		// 
		this.redoToolStripMenuItem.Enabled = false;
		this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
		this.redoToolStripMenuItem.Size = new Size(154, 22);
		this.redoToolStripMenuItem.Text = "Redo";
		// 
		// toolStripSeparator3
		// 
		this.toolStripSeparator3.Name = "toolStripSeparator3";
		this.toolStripSeparator3.Size = new Size(151, 6);
		// 
		// cutToolStripMenuItem
		// 
		this.cutToolStripMenuItem.Enabled = false;
		this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
		this.cutToolStripMenuItem.Size = new Size(154, 22);
		this.cutToolStripMenuItem.Text = "Cut";
		// 
		// copyToolStripMenuItem
		// 
		this.copyToolStripMenuItem.Enabled = false;
		this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
		this.copyToolStripMenuItem.Size = new Size(154, 22);
		this.copyToolStripMenuItem.Text = "Copy";
		// 
		// pasteToolStripMenuItem
		// 
		this.pasteToolStripMenuItem.Enabled = false;
		this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
		this.pasteToolStripMenuItem.Size = new Size(154, 22);
		this.pasteToolStripMenuItem.Text = "Paste";
		// 
		// duplicateToolStripMenuItem
		// 
		this.duplicateToolStripMenuItem.Enabled = false;
		this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
		this.duplicateToolStripMenuItem.Size = new Size(154, 22);
		this.duplicateToolStripMenuItem.Text = "Duplicate";
		// 
		// toolStripSeparator4
		// 
		this.toolStripSeparator4.Name = "toolStripSeparator4";
		this.toolStripSeparator4.Size = new Size(151, 6);
		// 
		// deleteSelectedToolStripMenuItem
		// 
		this.deleteSelectedToolStripMenuItem.Enabled = false;
		this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
		this.deleteSelectedToolStripMenuItem.Size = new Size(154, 22);
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
		this.settingsToolStripMenuItem1.Size = new Size(116, 22);
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
		this.smartPropVDCToolStripMenuItem.Name = "smartPropVDCToolStripMenuItem";
		this.smartPropVDCToolStripMenuItem.Size = new Size(159, 22);
		this.smartPropVDCToolStripMenuItem.Text = "Smart Prop VDC";
		this.smartPropVDCToolStripMenuItem.Click += this.smartPropVDCToolStripMenuItem_Click;
		// 
		// openSmartProjectFileDialog
		// 
		this.openSmartProjectFileDialog.DefaultExt = "smartproj";
		this.openSmartProjectFileDialog.Filter = "Smart project files|*.smartproj|All files|*.*";
		// 
		// fileSystemWatcher1
		// 
		this.fileSystemWatcher1.EnableRaisingEvents = true;
		this.fileSystemWatcher1.SynchronizingObject = this;
		// 
		// MainForm
		// 
		this.AllowDrop = true;
		this.AutoScaleDimensions = new SizeF(7F, 15F);
		this.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = SystemColors.Control;
		this.ClientSize = new Size(896, 480);
		this.Controls.Add(this.menuStrip1);
		this.MainMenuStrip = this.menuStrip1;
		this.Margin = new Padding(2);
		this.Name = "MainForm";
		this.Text = "CS2 Smart-Prop Editor";
		this.DragDrop += this.MainForm_DragDrop;
		this.DragEnter += this.MainForm_DragEnter;
		this.menuStrip1.ResumeLayout(false);
		this.menuStrip1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.fileSystemWatcher1).EndInit();
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
	private System.ComponentModel.BackgroundWorker backgroundWorker1;
	private FileSystemWatcher fileSystemWatcher1;
}
