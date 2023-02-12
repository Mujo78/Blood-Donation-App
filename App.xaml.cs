using DarujKrv.Data;
using DarujKrv.Moduli;

namespace DarujKrv;

public partial class App : Application
{
	public static User users { get; set; }
	
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
