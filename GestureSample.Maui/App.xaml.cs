using GestureSample.Views;

namespace GestureSample.Maui;

public partial class App : Application
{
	public static NavigationPage MainNavigation;

	public App()
	{
		InitializeComponent();

		var mainPage = new MainPage("Control Categories", null);
		MainPage = MainNavigation = new NavigationPage(mainPage);
	}
}
