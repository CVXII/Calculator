#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#endif

namespace MauiScientificCalculator;

public partial class App : Application
{
    public App()
	{
		InitializeComponent();


        MainPage = new CalculatorPage();
	}
}
