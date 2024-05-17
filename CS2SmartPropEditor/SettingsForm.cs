using CS2SmartPropEditor.Settings;

namespace CS2SmartPropEditor;

public partial class SettingsForm : Form
{
	public SettingsForm() {
		InitializeComponent();

		this.textBoxSteamAppPath.Text = AppSettings.Get().SteamAppPath;
	}

	private void buttonSteamAppPathReset_Click(object sender, EventArgs e) {
		this.textBoxSteamAppPath.Text = RegestryManager.GetValveSteamAppPath();
	}

	private void buttonSteamAppPathFind_Click(object sender, EventArgs e) {
		this.folderBrowserDialog1.InitialDirectory = this.textBoxSteamAppPath.Text;
		this.folderBrowserDialog1.ShowDialog();
		if (this.folderBrowserDialog1.SelectedPath != string.Empty) {
			this.textBoxSteamAppPath.Text = this.folderBrowserDialog1.SelectedPath;
		}
	}

	private void buttonSave_Click(object sender, EventArgs e) {
		var s = AppSettings.Get();

		s.SetSteamAppPath(this.textBoxSteamAppPath.Text);

		this.Close();
	}

	private void buttonCancel_Click(object sender, EventArgs e) {
		this.Close();
	}
}
