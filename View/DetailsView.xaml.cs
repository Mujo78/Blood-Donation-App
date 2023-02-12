using DarujKrv.ViewModels;
using Microsoft.Maui.Controls.Internals;

namespace DarujKrv;

public partial class DetailsView : ContentPage
{
	public DetailsView()
	{
		InitializeComponent();

        this.BindingContext = new DetailsViewModels();

       

    }


}