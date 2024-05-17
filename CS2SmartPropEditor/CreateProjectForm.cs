namespace CS2SmartPropEditor;

public partial class CreateProjectForm : Form
{
	public CreateProjectForm() {
		InitializeComponent();

		this.updateCreateButtonEnabled();
	}

	#region Support functions

	private void updateCreateButtonEnabled() {
		this.buttonCreate.Enabled = !string.IsNullOrEmpty(this.textBoxProjectName.Text)
			&& !string.IsNullOrEmpty(this.textBoxAddonName.Text);
	}

	#endregion // Support functions

	private void buttonCreate_Click(object sender, EventArgs e) {
		MessageBox.Show("Create button clicked");
	}

	private void buttonCancel_Click(object sender, EventArgs e) {
		this.Close();
	}

	private void textBoxProjectName_TextChanged(object sender, EventArgs e) {
		this.updateCreateButtonEnabled();
	}

	private void textBoxAddonName_TextChanged(object sender, EventArgs e) {
		this.updateCreateButtonEnabled();
	}
}
