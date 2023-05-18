using CalculatorMaui.MVVM.Views;

namespace CalculatorMaui;

public partial class App : Application
{

    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new CalculatorPage());
    }
}
