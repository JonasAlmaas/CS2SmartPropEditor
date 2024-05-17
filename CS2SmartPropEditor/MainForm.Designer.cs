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
		this.SuspendLayout();
		// 
		// MainForm
		// 
		this.AutoScaleDimensions = new SizeF(10F, 25F);
		this.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = SystemColors.Control;
		this.ClientSize = new Size(1280, 800);
		this.Name = "MainForm";
		this.Text = "CS2 Smart-Prop Editor";
		this.ResumeLayout(false);
	}

	#endregion
}
