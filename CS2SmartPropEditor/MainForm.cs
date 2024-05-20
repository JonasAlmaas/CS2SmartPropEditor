using System.Diagnostics;

using CS2SmartPropEditor.Settings;
using CS2SmartPropEditor.Project;

namespace CS2SmartPropEditor;

public partial class MainForm : Form
{
	private ProjectSmartProp? selectedSmartProp;

	public MainForm() {
		InitializeComponent();

		this.updateTitle();
		this.toolStripTextBoxVersion.Text = $"v{Program.GetVersion()}";
		this.setupSmartPropList();
		this.updateMenuFileButtonEnabled();
	}

	#region Setup

	private void setupSmartPropList() {
		this.smartPropList.View = View.Details;
		this.smartPropList.LabelEdit = false;
		this.smartPropList.AllowColumnReorder = false;
		this.smartPropList.CheckBoxes = false;
		this.smartPropList.FullRowSelect = true;
		this.smartPropList.GridLines = false;
		this.smartPropList.Sorting = SortOrder.Ascending;
		this.smartPropList.MultiSelect = false;

		this.smartPropList.Columns.Add("Smart Prop", -2, HorizontalAlignment.Left);
	}

	#endregion // Setup

	#region Support function

	private void updateTitle() {
		var ps = ProjectSettings.Get();
		this.Text = "CS2 Smart Prop Editor" + (ps.Project!=null ? $" - {ps.Project.ProjectName}" : "");
	}

	private void updateMenuFileButtonEnabled() {
		this.closeToolStripMenuItem.Enabled = ProjectSettings.Get().Project!=null;
		this.saveToolStripMenuItem.Enabled = ProjectSettings.Get().Project!=null;
	}

	private void openProject(string? fPath) {
		var ps = ProjectSettings.Get();

		if (!ps.SetProject(fPath)) {
			MessageBox.Show($"Failed to load project from \"{fPath}\"");
			return;
		}

		this.updateTitle();
		this.updateMenuFileButtonEnabled();
		this.redrawSmartPropList();
		this.selectedSmartProp = null;
		this.updateSmartPropAttributes();
	}

	private void redrawSmartPropList() {
		this.smartPropList.Items.Clear();

		var ps = ProjectSettings.Get();
		if (ps.Project==null) return;

		this.smartPropList.Items.AddRange(ps.Project.SmartProps
			.Select(r => new ListViewItem(r.Description ?? r.Path))
			.ToArray());
	}

	private void updateSmartPropAttributes() {
		this.textBoxSmartPropDescription.Text = this.selectedSmartProp?.Description;
		this.textBoxSmartPropPath.Text = this.selectedSmartProp?.Path;
	}

	#endregion // Support function

	#region Menu strip

	private void createProjectToolStripMenuItem_Click(object sender, EventArgs e) {
		// TODO: Check if a project is open with unsaved changes and prompt the user to save

		var createProjectForm = new CreateProjectForm();
		createProjectForm.Show();
	}

	private void openToolStripMenuItem_Click(object sender, EventArgs e) {
		this.openSmartProjectFileDialog.ShowDialog();
		var fPath = this.openSmartProjectFileDialog.FileName;
		if (!string.IsNullOrEmpty(fPath)) {
			this.openProject(fPath);
		}
	}

	private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
		this.openProject(null);
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
		}
		else {
			File.WriteAllText(ps.ProjectPath, data);
		}
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
		Application.Exit();
	}

	private void settingsToolStripMenuItem1_Click(object sender, EventArgs e) {
		var settingsForm = new SettingsForm();
		settingsForm.Show();
	}

	private void smartPropVDCToolStripMenuItem_Click(object sender, EventArgs e) {
		var url = "https://developer.valvesoftware.com/wiki/Counter-Strike_2_Workshop_Tools/Level_Design/Smartprops";
		Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
	}

	#endregion // Menu strip

	private void MainForm_DragDrop(object sender, DragEventArgs e) {
		if (e.Data==null) return;

		// TODO: If a project is open and we have unsaved changes, prompt the user to save

		if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0) {
			var fPath = files[0];
			if (!string.IsNullOrEmpty(fPath)) {
				if (File.Exists(fPath)) {
					this.openProject(fPath);
				}
				else {
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

	//private void button1_Click(object sender, EventArgs e) {
	//	ResourceCompiler.Compile("D:\\SteamLibrary\\steamapps\\common\\Counter-Strike Global Offensive\\content\\csgo_addons\\warden\\smartprops\\brick_debris_01.vsmart");
	//}

	private void smartPropList_SelectedIndexChanged(object sender, EventArgs e) {
		this.selectedSmartProp = this.smartPropList.SelectedItems.Count == 1
			? ProjectSettings.Get().Project?.SmartProps.ElementAtOrDefault(this.smartPropList.SelectedItems[0].Index)
			: null;

		this.updateSmartPropAttributes();
	}
}
