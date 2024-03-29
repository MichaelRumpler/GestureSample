﻿namespace GestureSample.Views.Tests
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
						TextColor = Colors.Purple,
						HorizontalOptions = LayoutOptions.StartAndExpand
					},
					new Label () { 
						Text = value,
						TextColor = Colors.Gray,
						HorizontalOptions = LayoutOptions.EndAndExpand
					}
				}
			};
		}
	}
}
