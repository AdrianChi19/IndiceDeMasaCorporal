using Imc.Models;
using Imc.Maui.ViewModel;
namespace Imc.Maui.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}