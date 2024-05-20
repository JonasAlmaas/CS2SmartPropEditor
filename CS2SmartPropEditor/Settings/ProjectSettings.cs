using CS2SmartPropEditor.Project;

namespace CS2SmartPropEditor.Settings;

internal class ProjectSettings
{
	public string? ProjectPath {get; private set;}=null;
	public SmartProject? Project {get; private set;}=null;

	public bool SetProject(string? fPath) {
		var project = fPath!=null ? SmartProjectSerializer.Deserialize(fPath) : null;

		if (fPath==null || project!=null) {
			this.ProjectPath = fPath;
			this.Project = project;
			return true;
		} else {
			return false;
		}
	}

	#region Static Interface

	private static ProjectSettings? instance = null;
	public static ProjectSettings Get() => instance ??= new ProjectSettings();

	#endregion // Static Interface
}
