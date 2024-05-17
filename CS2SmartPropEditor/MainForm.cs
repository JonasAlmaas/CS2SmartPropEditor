namespace CS2SmartPropEditor;

public partial class MainForm : Form
{
	public MainForm() {
		InitializeComponent();
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
		Application.Exit();
	}

	private void openToolStripMenuItem_Click(object sender, EventArgs e) {
		this.openSmartProjectFileDialog.ShowDialog();
		var fPath = this.openSmartProjectFileDialog.FileName;
		if (fPath!=null) {
			var fContent = File.ReadAllText(fPath);
			Console.WriteLine(fContent);
		}
	}
}
