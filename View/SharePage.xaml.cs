using CommunityToolkit.Maui.Views;

namespace DarujKrv.View;

public partial class SharePage : ContentPage
{
	public SharePage()
	{
		InitializeComponent();
	}
    private async void AppImageButton_Clicked(object sender, EventArgs e)
    {
        this.ShowPopup(new PopUpPage());
    }
}