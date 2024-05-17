namespace CS2SmartPropEditor.Settings;

internal class AppSettings
{
	public string SteamAppPath {get;private set;}

	public AppSettings() {
		this.SteamAppPath = RegestryManager.GetSteamAppPath();
	}

	#region Static Interface

	private static AppSettings? instance = null;
	public static AppSettings Get() => instance ??= new AppSettings();

	#endregion // Static Interface
}
