using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestureSample.Views.Tests
{
	public class BigButton : MR.Gestures.Grid
	{
		public BigButton(string title, string imageFile, Command action)
		{
			StackLayout layout = null;
			Image img = null;

			Children.Add(img = new Image { Source = imageFile, WidthRequest = 120, HeightRequest = 120 });
			Children.Add(layout = new StackLayout
			{
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.EndAndExpand,
				Padding = new Thickness(0, 0, 0, 15),
				Children =
                {
                    new Label
                    {
                        Text = title,
						HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 10,
                        TextColor = Color.Black
                    }
                }
			});
			UpCommand = action;
		}
	}
}
