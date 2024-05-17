namespace CS2SmartPropEditor.Settings;

internal class ProjectSettings
{
	public string? ProjectPath {get; set;} = null;

	#region Static Interface

	private static ProjectSettings? instance = null;
	public static ProjectSettings Get() => instance ??= new ProjectSettings();

	#endregion // Static Interface
}
