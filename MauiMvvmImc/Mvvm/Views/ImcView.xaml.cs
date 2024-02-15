using MauiMvvmImc.Mvvm.ViewModels;

namespace MauiMvvmImc.Mvvm.Views;

public partial class ImcView : ContentPage
{
	public ImcView()
	{
		InitializeComponent();
		BindingContext = new ImcViewModel();
	}
}