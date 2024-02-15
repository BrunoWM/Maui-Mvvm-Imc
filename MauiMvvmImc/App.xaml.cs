using MauiMvvmImc.Mvvm.Views;

namespace MauiMvvmImc;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new ImcView());
	}
}
