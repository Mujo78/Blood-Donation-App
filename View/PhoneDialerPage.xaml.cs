using DarujKrv.ViewModels;

namespace DarujKrv.View;


public partial class PhoneDialerPage : ContentPage
{
	public PhoneDialerPage()
	{
		InitializeComponent();
        BindingContext = new PhoneDialerViewModel();
    }
}