using CS2SmartPropEditor.Project;

namespace CS2SmartPropEditor.Settings;

internal class ProjectSettings
{
	public string? ProjectPath {get; private set;} = null;

	public bool SetProjectPath(string fPath) {
		this.ProjectPath = fPath;
		this.Project = SmartProjectSerializer.Deserialize(fPath);

		if (this.Project == null) {
			MessageBox.Show($"Failed to load project from \"{fPath}\"");
			this.ProjectPath = null;
			return false;
		} else {
			return true;
		}
	}

	public SmartProject? Project {get; set;} = null;

	#region Static Interface

	private static ProjectSettings? instance = null;
	public static ProjectSettings Get() => instance ??= new ProjectSettings();

	#endregion // Static Interface
}
