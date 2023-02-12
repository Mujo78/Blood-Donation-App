using CommunityToolkit.Maui.Views;

namespace DarujKrv.View;

public partial class PopUpPage : Popup
{
	public PopUpPage()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        Close();
    }
}