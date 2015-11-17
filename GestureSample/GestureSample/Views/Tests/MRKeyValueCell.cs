using System;
using Xamarin.Forms;

namespace GestureSample.Views.Tests
{
	public class MRKeyValueCell : MR.Gestures.ViewCell
	{
		public MRKeyValueCell(string key, string value)
		{
			View = new StackLayout()
			{
				Padding = new Thickness(15, 10),
				Orientation = StackOrientation.Horizontal,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label () { 
						Text = key,
						TextColor = Color.Purple,
						HorizontalOptions = LayoutOptions.StartAndExpand
					},
					new Label () { 
						Text = value,
						TextColor = Color.Gray,
						HorizontalOptions = LayoutOptions.EndAndExpand
					}
				}
			};
		}
	}
}
