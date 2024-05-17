namespace CS2SmartPropEditor
{
	partial class CreateProjectForm
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
			this.labelProjectName = new Label();
			this.textBoxProjectName = new TextBox();
			this.textBoxAddonName = new TextBox();
			this.labelAddon = new Label();
			this.buttonCreate = new Button();
			this.buttonCancel = new Button();
			this.SuspendLayout();
			// 
			// labelProjectName
			// 
			this.labelProjectName.AutoSize = true;
			this.labelProjectName.Location = new Point(189, 133);
			this.labelProjectName.Name = "labelProjectName";
			this.labelProjectName.Size = new Size(79, 15);
			this.labelProjectName.TabIndex = 0;
			this.labelProjectName.Text = "Project Name";
			// 
			// textBoxProjectName
			// 
			this.textBoxProjectName.Location = new Point(273, 130);
			this.textBoxProjectName.Name = "textBoxProjectName";
			this.textBoxProjectName.Size = new Size(318, 23);
			this.textBoxProjectName.TabIndex = 1;
			this.textBoxProjectName.TextChanged += this.textBoxProjectName_TextChanged;
			// 
			// textBoxAddonName
			// 
			this.textBoxAddonName.Location = new Point(273, 162);
			this.textBoxAddonName.Name = "textBoxAddonName";
			this.textBoxAddonName.Size = new Size(318, 23);
			this.textBoxAddonName.TabIndex = 3;
			this.textBoxAddonName.TextChanged += this.textBoxAddonName_TextChanged;
			// 
			// labelAddon
			// 
			this.labelAddon.AutoSize = true;
			this.labelAddon.Location = new Point(189, 165);
			this.labelAddon.Name = "labelAddon";
			this.labelAddon.Size = new Size(78, 15);
			this.labelAddon.TabIndex = 2;
			this.labelAddon.Text = "Addon Name";
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new Point(247, 243);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new Size(75, 23);
			this.buttonCreate.TabIndex = 4;
			this.buttonCreate.Text = "Create";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += this.buttonCreate_Click;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new Point(328, 243);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += this.buttonCancel_Click;
			// 
			// CreateProjectForm
			// 
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(800, 450);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.textBoxAddonName);
			this.Controls.Add(this.labelAddon);
			this.Controls.Add(this.textBoxProjectName);
			this.Controls.Add(this.labelProjectName);
			this.Name = "CreateProjectForm";
			this.Text = "Create Smart Project";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private Label labelProjectName;
		private TextBox textBoxProjectName;
		private TextBox textBoxAddonName;
		private Label labelAddon;
		private Button buttonCreate;
		private Button buttonCancel;
	}
}
