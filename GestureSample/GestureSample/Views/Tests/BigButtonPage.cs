using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestureSample.Views.Tests
{
	public class BigButtonPage : ContentPage
	{
		public BigButtonPage()
		{
			var cmd = new Command(OnButtonClick);
			var image = "Resources/images/Border";
			if(Device.RuntimePlatform == Device.iOS)
				image = "images/Border";
			if (Device.RuntimePlatform == Device.Android)
				image = "Border";
			Content = new BigButton("TTTTouch me", image, cmd)
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				WidthRequest = 120,
				HeightRequest = 120,
			};
		}

		private void OnButtonClick()
		{
			this.DisplayAlert("BigButton", "You really touched me.", "OK");
		}
	}
}
