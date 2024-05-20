using System.Diagnostics;

using CS2SmartPropEditor.Settings;

internal class ResourceCompiler
{
	public static bool Compile(string path) {
		var appSettings = AppSettings.Get();
		var binPath = Path.Combine(appSettings.SteamAppPath, "game\\bin\\win64");
		var exePath = Path.Combine(binPath, "resourcecompiler.exe");

		if (!File.Exists(exePath)) {
			MessageBox.Show(
				$"Check if the install path is correct \"{appSettings.SteamAppPath}\"",
				"Failed to find resourcecompiler.exe");
			return false;
		}

		var psi = new ProcessStartInfo {
			WorkingDirectory = binPath,
			FileName = Path.Combine(binPath, "resourcecompiler.exe"),
			ArgumentList = {
				"-nocustomermachine",
				"-nop4",
				"-novpk",
				path
			},
			UseShellExecute = false,
			RedirectStandardOutput = false,
			CreateNoWindow = true
		};

		var p = Process.Start(psi);

		if (p != null) {
			p.WaitForExit();
			return p.ExitCode == 0;
		} else {
			return false;
		}
	}
}
