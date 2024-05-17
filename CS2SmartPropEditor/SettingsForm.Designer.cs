namespace CS2SmartPropEditor
{
	partial class SettingsForm
	{
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
			this.folderBrowserDialog1 = new FolderBrowserDialog();
			this.panel1 = new Panel();
			this.textBoxSteamAppPath = new TextBox();
			this.labelSteamAppPath = new Label();
			this.buttonSteamAppPathFind = new Button();
			this.buttonSteamAppPathReset = new Button();
			this.panel2 = new Panel();
			this.buttonSave = new Button();
			this.buttonCancel = new Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = SystemColors.Control;
			this.panel1.Controls.Add(this.textBoxSteamAppPath);
			this.panel1.Controls.Add(this.labelSteamAppPath);
			this.panel1.Controls.Add(this.buttonSteamAppPathFind);
			this.panel1.Controls.Add(this.buttonSteamAppPathReset);
			this.panel1.Dock = DockStyle.Fill;
			this.panel1.Location = new Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(794, 444);
			this.panel1.TabIndex = 3;
			// 
			// textBoxSteamAppPath
			// 
			this.textBoxSteamAppPath.Location = new Point(148, 3);
			this.textBoxSteamAppPath.Name = "textBoxSteamAppPath";
			this.textBoxSteamAppPath.Size = new Size(481, 23);
			this.textBoxSteamAppPath.TabIndex = 3;
			// 
			// labelSteamAppPath
			// 
			this.labelSteamAppPath.AutoSize = true;
			this.labelSteamAppPath.Location = new Point(3, 6);
			this.labelSteamAppPath.Name = "labelSteamAppPath";
			this.labelSteamAppPath.Size = new Size(139, 15);
			this.labelSteamAppPath.TabIndex = 2;
			this.labelSteamAppPath.Text = "CS2 Installation Directory";
			// 
			// buttonSteamAppPathFind
			// 
			this.buttonSteamAppPathFind.Location = new Point(635, 3);
			this.buttonSteamAppPathFind.Name = "buttonSteamAppPathFind";
			this.buttonSteamAppPathFind.Size = new Size(75, 23);
			this.buttonSteamAppPathFind.TabIndex = 1;
			this.buttonSteamAppPathFind.Text = "Find";
			this.buttonSteamAppPathFind.UseVisualStyleBackColor = true;
			this.buttonSteamAppPathFind.Click += this.buttonSteamAppPathFind_Click;
			// 
			// buttonSteamAppPathReset
			// 
			this.buttonSteamAppPathReset.Location = new Point(716, 3);
			this.buttonSteamAppPathReset.Name = "buttonSteamAppPathReset";
			this.buttonSteamAppPathReset.Size = new Size(75, 23);
			this.buttonSteamAppPathReset.TabIndex = 1;
			this.buttonSteamAppPathReset.Text = "Reset";
			this.buttonSteamAppPathReset.UseVisualStyleBackColor = true;
			this.buttonSteamAppPathReset.Click += this.buttonSteamAppPathReset_Click;
			// 
			// panel2
			// 
			this.panel2.BackColor = SystemColors.Control;
			this.panel2.Controls.Add(this.buttonSave);
			this.panel2.Controls.Add(this.buttonCancel);
			this.panel2.Dock = DockStyle.Bottom;
			this.panel2.Location = new Point(3, 418);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(794, 29);
			this.panel2.TabIndex = 4;
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.buttonSave.Location = new Point(635, 3);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new Size(75, 23);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += this.buttonSave_Click;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.buttonCancel.Location = new Point(716, 3);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new Size(75, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += this.buttonCancel_Click;
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "SettingsForm";
			this.Padding = new Padding(3);
			this.Text = "Settings";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		#endregion
		private FolderBrowserDialog folderBrowserDialog1;
		private Panel panel1;
		private Panel panel2;
		private Button buttonSave;
		private Button buttonCancel;
		private Panel panel3;
		private Panel panel4;
		private TextBox textBox1;
		private Button buttonSteamAppPathReset;
		private Label labelSteamAppPath;
		private TextBox textBoxSteamAppPath;
		private Button buttonSteamAppPathFind;
	}
}
