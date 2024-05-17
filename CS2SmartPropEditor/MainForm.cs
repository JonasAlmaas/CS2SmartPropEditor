using System.Diagnostics;

using CS2SmartPropEditor.Settings;
using CS2SmartPropEditor.Project;

namespace CS2SmartPropEditor;

public partial class MainForm : Form
{
	public MainForm() {
		InitializeComponent();

		this.updateSaveButtonEnabled();
	}

	#region Update state function

	private void updateSaveButtonEnabled() {
		this.saveToolStripMenuItem.Enabled = !string.IsNullOrEmpty(ProjectSettings.Get().ProjectPath);
	}

	#endregion // Update state function

	private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
		Application.Exit();
	}

	private void openToolStripMenuItem_Click(object sender, EventArgs e) {
		this.openSmartProjectFileDialog.ShowDialog();
		var fPath = this.openSmartProjectFileDialog.FileName;
		if (!string.IsNullOrEmpty(fPath)) {
			ProjectSettings.Get().SetProjectPath(fPath);
			this.updateSaveButtonEnabled();
		}
	}

	private void settingsToolStripMenuItem1_Click(object sender, EventArgs e) {
		var settingsForm = new SettingsForm();
		settingsForm.Show();
	}

	private void smartPropVDCToolStripMenuItem_Click(object sender, EventArgs e) {
		var url = "https://developer.valvesoftware.com/wiki/Counter-Strike_2_Workshop_Tools/Level_Design/Smartprops";
		Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
	}

	private void MainForm_DragDrop(object sender, DragEventArgs e) {
		if (e.Data==null) return;

		// TODO: If a project is open and we have unsaved changes, prompt the user to save

		if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0) {
			var fPath = files[0];
			if (!string.IsNullOrEmpty(fPath)) {
				if (File.Exists(fPath)) {
					ProjectSettings.Get().SetProjectPath(fPath);
					this.updateSaveButtonEnabled();
				} else {
					MessageBox.Show($"File not found: {fPath}");
				}
			}
		}
	}

	private void MainForm_DragEnter(object sender, DragEventArgs e) {
		if (e.Data==null) return;

		if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0) {
			var fPath = files[0];
			if (!string.IsNullOrEmpty(fPath) && File.Exists(fPath)) {
				if (Path.GetExtension(fPath) == SmartProject.Extension) {
					e.Effect = DragDropEffects.All;
				}
			}
		}
	}

	private void createProjectToolStripMenuItem_Click(object sender, EventArgs e) {
		// TODO: Check if a project is open with unsaved changes and prompt the user to save

		var createProjectForm = new CreateProjectForm();
		createProjectForm.Show();
	}

	private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
		var ps = ProjectSettings.Get();

		if (ps.Project==null) return;

		//ProjectSettings.Get().ProjectPath
		var data = SmartProjectSerializer.Serialize(ps.Project);
		if (data==null) {
			MessageBox.Show("Failed to serialize project data");
			return;
		}

		if (string.IsNullOrEmpty(ps.ProjectPath)) {
			// TODO: Promt the user to select a path
			MessageBox.Show("Can not save without a project path");
		} else {
			File.WriteAllText(ps.ProjectPath, data);
		}
	}
}
