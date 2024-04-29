using GestureSample.ViewModels;
using MR.Gestures;

namespace GestureSample.Views
{
	public partial class TextCellRecycle
	{
		public TextCellRecycle()
		{
			InitializeComponent();
		}


		void Cell_Down(object sender, DownUpEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Down method called on cell '" + ((TextCell)sender).Text + "' with " + e.TriggeringTouches.Length + " fingers");
		}

		void Cell_Up(object sender, DownUpEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Up method called on cell '" + ((TextCell)sender).Text + "' with " + e.TriggeringTouches.Length + " fingers");
		}

		void Cell_Tapping(object sender, TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Tapping method called on cell '" + ((TextCell)sender).Text + "' " + e.NumberOfTaps + " times");
		}

		void Cell_Tapped(object sender, TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Tapped method called on cell '" + ((TextCell)sender).Text + "' " + e.NumberOfTaps + " times");
		}

		void Cell_DoubleTapped(object sender, TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_DoubleTapped method called on cell '" + ((TextCell)sender).Text + "' " + e.NumberOfTaps + " times");
		}

		void Cell_LongPressing(object sender, LongPressEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_LongPressing method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_LongPressed(object sender, LongPressEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_LongPressed method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_Panning(object sender, PanEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Panning method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_Panned(object sender, PanEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Panned method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_Swiped(object sender, SwipeEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Swiped method called on cell '" + ((TextCell)sender).Text + "', swiped " + e.Direction);
		}

		void Cell_Pinching(object sender, PinchEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Pinching method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_Pinched(object sender, PinchEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Pinched method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_Rotating(object sender, RotateEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Rotating method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_Rotated(object sender, RotateEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Rotated method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_MouseEntered(object sender, MouseEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_MouseEntered method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_MouseMoved(object sender, MouseEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_MouseMoved method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_MouseExited(object sender, MouseEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_MouseExited method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_ScrollWheelChanged(object sender, ScrollWheelEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_ScrollWheelChanged method called on cell '" + ((TextCell)sender).Text + "'");
		}
	}
}
