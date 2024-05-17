namespace CS2SmartPropEditor.Settings;

internal class AppSettings
{
	public string SteamAppPath {get;private set;}

	public AppSettings() {
		this.SteamAppPath = RegestryManager.GetSteamAppPath();
	}

	public void SetSteamAppPath(string path) {
		RegestryManager.SetSteamAppPath(path);
		this.SteamAppPath = path;
	}

	#region Static Interface

	private static AppSettings? instance = null;
	public static AppSettings Get() => instance ??= new AppSettings();

	#endregion // Static Interface
}
