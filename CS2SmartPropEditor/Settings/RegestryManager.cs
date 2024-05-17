using Microsoft.Win32;

namespace CS2SmartPropEditor.Settings;

internal class RegestryManager
{
	public static string GetValveSteamAppPath() {
		var rawSteamPath = (string)Registry.GetValue(
			"HKEY_CURRENT_USER\\Software\\Valve\\Steam",
			"SteamPath",
			"c:\\program files (x86)\\steam")!;

		return Path.Combine(
			new FileInfo(rawSteamPath).FullName,
			"common\\Counter-Strike Global Offensive");
	}

	public static string GetSteamAppPath()
	{
		var steamAppPath = (string?)Registry.GetValue(RegistryKeyName.Base, RegistryKeyName.SteamAppPath, null);

		if (steamAppPath == null) {
			return GetValveSteamAppPath();
		} else {
			return steamAppPath;
		}
	}

	public static void SetSteamAppPath(string path) {
		Registry.SetValue(RegistryKeyName.Base, RegistryKeyName.SteamAppPath, path);
	}
}
