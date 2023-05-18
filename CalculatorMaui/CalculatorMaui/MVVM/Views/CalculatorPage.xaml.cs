using CalculatorMaui.MVVM.ViewModels;

namespace CalculatorMaui.MVVM.Views;

public partial class CalculatorPage : ContentPage
{

    public CalculatorPage()
	{
		InitializeComponent();
        BindingContext = new CalculatorViewModel();
    }
}