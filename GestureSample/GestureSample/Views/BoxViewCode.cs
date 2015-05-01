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
	public class BoxViewCode : ContentPage
	{
		public BoxViewCode()
		{
			this.Title = "Code";

			var box1 = new MR.Gestures.BoxView { Color = Color.Red };
			box1.Down += (s, e) => { AddText("CodePage: Red Down " + e.TriggeringTouches.Length + " fingers"); };
			box1.Up += (s, e) => { AddText("CodePage: Red Up " + e.TriggeringTouches.Length + " fingers"); };
			box1.Tapping += (s, e) => { AddText("CodePage: Red Tapping " + e.NumberOfTaps + " times with " + e.NumberOfTouches + " fingers"); };
			box1.Tapped += (s, e) => { AddText("CodePage: Red Tapped " + e.NumberOfTaps + " times with " + e.NumberOfTouches + " fingers"); };
			box1.DoubleTapped += (s, e) => { AddText("CodePage: Red DoubleTapped " + e.NumberOfTaps + " times with " + e.NumberOfTouches + " fingers"); };
			box1.LongPressing += (s, e) => { AddText("CodePage: Red LongPressing"); };
			box1.LongPressed += (s, e) => { AddText("CodePage: Red LongPressed"); };
			box1.Pinching += (s, e) => { AddText("CodePage: Red Pinching"); };
			box1.Pinched += (s, e) => { AddText("CodePage: Red Pinched"); };
			box1.Panning += (s, e) => { AddText("CodePage: Red Panning"); };
			box1.Panned += (s, e) => { AddText("CodePage: Red Panned"); };
			box1.Swiped			+= (s, e) => { AddText("CodePage: Red Swiped"); };
			box1.Rotating += (s, e) => { AddText("CodePage: Red Rotating"); };
			box1.Rotated += (s, e) => { AddText("CodePage: Red Rotated"); };

			var box2 = new MR.Gestures.BoxView { Color = Color.Green };
			box2.SetBinding(MR.Gestures.BoxView.DownCommandProperty, "DownCommand");
			box2.DownCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.UpCommandProperty, "UpCommand");
			box2.UpCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.TappingCommandProperty, "TappingCommand");
			box2.TappingCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.TappedCommandProperty, "TappedCommand");
			box2.TappedCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.DoubleTappedCommandProperty, "DoubleTappedCommand");
			box2.DoubleTappedCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.LongPressingCommandProperty, "LongPressingCommand");
			box2.LongPressingCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.LongPressedCommandProperty, "LongPressedCommand");
			box2.LongPressedCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.PinchingCommandProperty, "PinchingCommand");
			box2.PinchingCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.PinchedCommandProperty, "PinchedCommand");
			box2.PinchedCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.PanningCommandProperty, "PanningCommand");
			box2.PanningCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.PannedCommandProperty, "PannedCommand");
			box2.PannedCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.SwipedCommandProperty, "SwipedCommand");
			box2.SwipedCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.RotatingCommandProperty, "RotatingCommand");
			box2.RotatingCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.RotatedCommandProperty, "RotatedCommand");
			box2.RotatedCommandParameter = "Green";

			var label = new Label();
			label.SetBinding(Label.TextProperty, "Text");
			var scroll = new ScrollView();
			scroll.Content = label;
			
			var layout = new RelativeLayout();

			layout.Children.Add(
					box1,
					Constraint.Constant(0),
					Constraint.Constant(0),
					Constraint.RelativeToParent((parent) => parent.Width / 2),
					Constraint.RelativeToParent((parent) => parent.Height / 2)
				);

			layout.Children.Add(
					box2,
					Constraint.RelativeToParent((parent) => parent.Width / 2),
					Constraint.Constant(0),
					Constraint.RelativeToParent((parent) => parent.Width / 2),
					Constraint.RelativeToParent((parent) => parent.Height / 2)
				);


			layout.Children.Add(
					scroll,
					Constraint.Constant(0),
					Constraint.RelativeToParent((parent) => parent.Height / 2),
					Constraint.RelativeToParent((parent) => parent.Width),
					Constraint.RelativeToParent((parent) => parent.Height / 2)
				);

			this.Content = layout;
		}

		private void AddText(string text)
		{
			((TextOnlyViewModel)BindingContext).AddText(text);
		}
	}
}
