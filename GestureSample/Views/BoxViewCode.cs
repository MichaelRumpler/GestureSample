using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestureSample.ViewModels;

namespace GestureSample.Views
{
	public class BoxViewCode : ContentPage
	{
		public BoxViewCode()
		{
			this.Title = "Code";

			var box1 = new MR.Gestures.BoxView { Color = Colors.Red };
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
			box1.MouseEntered += (s, e) => { AddText("CodePage: Red MouseEntered"); };
			box1.MouseMoved += (s, e) => { AddText("CodePage: Red MouseMoved"); };
			box1.MouseExited += (s, e) => { AddText("CodePage: Red MouseExited"); };
			box1.ScrollWheelChanged += (s, e) => { AddText("CodePage: Red ScrollWheelChanged"); };

			var box2 = new MR.Gestures.BoxView { Color = Colors.Green };
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
			box2.SetBinding(MR.Gestures.BoxView.MouseEnteredCommandProperty, "MouseEnteredCommand");
			box2.MouseEnteredCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.MouseMovedCommandProperty, "MouseMovedCommand");
			box2.MouseMovedCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.MouseExitedCommandProperty, "MouseExitedCommand");
			box2.MouseExitedCommandParameter = "Green";
			box2.SetBinding(MR.Gestures.BoxView.ScrollWheelChangedCommandProperty, "ScrollWheelChangedCommand");
			box2.ScrollWheelChangedCommandParameter = "Green";

			var label = new Label();
			label.SetBinding(Label.TextProperty, "Text");
			var scroll = new ScrollView();
			scroll.Content = label;
			
			var layout = new Grid() {
				RowDefinitions = new RowDefinitionCollection(new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Star)),
				ColumnDefinitions = new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Star)),
			};

			layout.Children.Add(box1);

			box2.SetValue(Grid.ColumnProperty, 1);
			layout.Children.Add(box2);

			scroll.SetValue(Grid.RowProperty, 1);
			scroll.SetValue(Grid.ColumnSpanProperty, 2);
			layout.Children.Add(scroll);

			this.Content = layout;
		}

		private void AddText(string text)
		{
			((TextOnlyViewModel)BindingContext).AddText(text);
		}
	}
}
