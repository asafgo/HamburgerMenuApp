using HamburgerMenuApp.Core.Interfaces.Services;
using HamburgerMenuApp.Core.Interfaces.ViewModels;
using Microsoft.Maui.Controls;
using SimpleToolkit.SimpleShell;

namespace HamburgerMenuApp.Maui.Views.Pages;

public partial class HomePage : BaseRootContentPage
{
	public HomePage(IHomePageViewModel viewModel, INavigationService navigationService) : base(navigationService)
	{
		BindingContext = viewModel;

		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //MainThread.BeginInvokeOnMainThread(() =>
        //{
        //    var shell = SimpleShell.Current;
        //    var navGrid = shell.FindByName("navBar");
        //    (navGrid as Microsoft.Maui.Controls.Grid).IsVisible = true;
        //});
    }
}
