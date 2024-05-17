#if DEBUG && false
using System.Runtime.InteropServices;
#endif

namespace CS2SmartPropEditor;

internal static class Program
{
	[STAThread]
	static void Main(string[] args)
	{
#if DEBUG && false
		AllocConsole();
		Console.WriteLine("Starting CS2 Smart-Prop Editor...");
#endif

		// To customize application configuration such as set high DPI settings or default font,
		// see https://aka.ms/applicationconfiguration.
		ApplicationConfiguration.Initialize();
		Application.Run(new MainForm());
	}

#if DEBUG && false
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool AllocConsole();
#endif
}
