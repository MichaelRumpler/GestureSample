using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestureSample.Views.Tests
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomButtonPage : ContentPage
	{
		public CustomButtonPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs args)
		{
			var btn = (CustomButton)sender;
			Log.Text = $"'{btn.Text}' was clicked";
		}
	}
}