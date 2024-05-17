#if DEBUG
using System.Runtime.InteropServices;
#endif

namespace CS2SmartPropEditor;

internal static class Program
{
	[STAThread]
	static void Main(string[] args)
	{
#if DEBUG
		AllocConsole();
#endif

		Console.WriteLine("Starting CS2 Smart-Prop Editor...");

		// To customize application configuration such as set high DPI settings or default font,
		// see https://aka.ms/applicationconfiguration.
		ApplicationConfiguration.Initialize();
		Application.Run(new MainForm());
	}

#if DEBUG
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool AllocConsole();
#endif
}
