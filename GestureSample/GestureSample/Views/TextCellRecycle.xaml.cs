using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


		void Cell_Down(object sender, MR.Gestures.DownUpEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Down method called on cell '" + ((TextCell)sender).Text + "' with " + e.TriggeringTouches.Length + " fingers");
		}

		void Cell_Up(object sender, MR.Gestures.DownUpEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Up method called on cell '" + ((TextCell)sender).Text + "' with " + e.TriggeringTouches.Length + " fingers");
		}

		void Cell_Tapping(object sender, MR.Gestures.TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Tapping method called on cell '" + ((TextCell)sender).Text + "' " + e.NumberOfTaps + " times");
		}

		void Cell_Tapped(object sender, MR.Gestures.TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Tapped method called on cell '" + ((TextCell)sender).Text + "' " + e.NumberOfTaps + " times");
		}

		void Cell_DoubleTapped(object sender, MR.Gestures.TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_DoubleTapped method called on cell '" + ((TextCell)sender).Text + "' " + e.NumberOfTaps + " times");
		}

		void Cell_LongPressing(object sender, MR.Gestures.LongPressEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_LongPressing method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_LongPressed(object sender, MR.Gestures.LongPressEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_LongPressed method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_Panning(object sender, MR.Gestures.PanEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Panning method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_Panned(object sender, MR.Gestures.PanEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Panned method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_Swiped(object sender, MR.Gestures.SwipeEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Swiped method called on cell '" + ((TextCell)sender).Text + "', swiped " + e.Direction);
		}

		void Cell_Pinching(object sender, MR.Gestures.PinchEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Pinching method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_Pinched(object sender, MR.Gestures.PinchEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Pinched method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_Rotating(object sender, MR.Gestures.RotateEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Rotating method called on cell '" + ((TextCell)sender).Text + "'");
		}

		void Cell_Rotated(object sender, MR.Gestures.RotateEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("TextCellRecycle.Cell_Rotated method called on cell '" + ((TextCell)sender).Text + "'");
		}
	}
}
