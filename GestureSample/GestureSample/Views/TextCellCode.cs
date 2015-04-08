using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestureSample.ViewModels;
using Xamarin.Forms;

namespace GestureSample.Views
{
	public class TextCellCode : ContentPage
	{
		public TextCellCode()
		{
			this.Title = "Code";

			var list = new MR.Gestures.ListView();
			list.SetBinding(ListView.ItemsSourceProperty, "Strings");
			list.ItemTemplate = new DataTemplate(() =>
			{
				var cell = new MR.Gestures.TextCell();
				cell.SetBinding(TextCell.TextProperty, ".");

				cell.Down += (s, e) => { AddText(s, "Down with " + e.TriggeringTouches.Length + " fingers"); };
				cell.Up += (s, e) => { AddText(s, "Up with " + e.TriggeringTouches.Length + " fingers"); };
				cell.Tapping += (s, e) => { AddText(s, "Tapping " + e.NumberOfTaps + " times"); };
				cell.Tapped += (s, e) => { AddText(s, "Tapped " + e.NumberOfTaps + " times"); };
				cell.DoubleTapped += (s, e) => { AddText(s, "DoubleTapped " + e.NumberOfTaps + " times"); };
				cell.LongPressing += (s, e) => { AddText(s, "LongPressing"); };
				cell.LongPressed += (s, e) => { AddText(s, "LongPressed"); };
				cell.Panning += (s, e) => { AddText(s, "Panning"); };
				cell.Panned += (s, e) => { AddText(s, "Panned"); };
				cell.Swiped += (s, e) => { AddText(s, "Swiped"); };
				cell.Pinching += (s, e) => { AddText(s, "Pinching"); };
				cell.Pinched += (s, e) => { AddText(s, "Pinched"); };
				cell.Rotating += (s, e) => { AddText(s, "Rotating"); };
				cell.Rotated += (s, e) => { AddText(s, "Rotated"); };

				return cell;
			});


			var label = new Label();
			label.SetBinding(Label.TextProperty, "Text");
			var scroll = new ScrollView();
			scroll.Content = label;
			
			var layout = new RelativeLayout();

			layout.Children.Add(
					list,
					Constraint.Constant(0),
					Constraint.Constant(0),
					Constraint.RelativeToParent((parent) => parent.Width / 2),
					Constraint.RelativeToParent((parent) => parent.Height)
				);

			layout.Children.Add(
					scroll,
					Constraint.RelativeToParent((parent) => parent.Width / 2),
					Constraint.Constant(0),
					Constraint.RelativeToParent((parent) => parent.Width / 2),
					Constraint.RelativeToParent((parent) => parent.Height)
				);

			this.Content = layout;
		}

		private void AddText(object item, string text)
		{
			var s = ((TextCell)item).Text;
			((ListOfStringsViewModel)BindingContext).AddText(String.Format("TextCellCode: '{0}' {1}", s, text));
		}
	}
}
