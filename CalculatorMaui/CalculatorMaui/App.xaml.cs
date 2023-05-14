using CalculatorMaui.MVVM.ViewModels;
using CalculatorMaui.MVVM.Views;

namespace CalculatorMaui;

public partial class App : Application
{
    private CalculatorViewModel _viewModel;

    public App()
    {
        InitializeComponent();

        MainPage = new CalculatorPage();
        _viewModel = new CalculatorViewModel();
        BindingContext = _viewModel;
    }
}
