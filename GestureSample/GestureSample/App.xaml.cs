using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using GestureSample.Views;


[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace GestureSample
{
	public partial class App : Application
	{
		public static NavigationPage MainNavigation;

		public App ()
		{
			InitializeComponent();

			var mainPage = new MainPage("Control Categories", null);
			MainPage = MainNavigation = new NavigationPage(mainPage);
		}
	}
}
