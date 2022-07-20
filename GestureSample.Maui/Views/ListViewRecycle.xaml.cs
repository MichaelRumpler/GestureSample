using GestureSample.ViewModels;

namespace GestureSample.Views
{
	public partial class ListViewRecycle
	{
		public ListViewRecycle()
		{
			InitializeComponent();
		}


		private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText($"ListView_ItemTapped method called. Tapped item = '{e.Item}'");
		}

		private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText($"ListView_ItemSelected method called. SelectedItem = '{e.SelectedItem}'");
		}

		void ListView_Down(object sender, MR.Gestures.DownUpEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_Down method called with " + e.TriggeringTouches.Length + " fingers");
		}

		void ListView_Up(object sender, MR.Gestures.DownUpEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_Up method called with " + e.TriggeringTouches.Length + " fingers");
		}

		void ListView_Tapping(object sender, MR.Gestures.TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_Tapping method called " + e.NumberOfTaps + " times");
		}

		void ListView_Tapped(object sender, MR.Gestures.TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_Tapped method called " + e.NumberOfTaps + " times");
		}

		void ListView_DoubleTapped(object sender, MR.Gestures.TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_DoubleTapped method called " + e.NumberOfTaps + " times");
		}

		void ListView_LongPressing(object sender, MR.Gestures.LongPressEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_LongPressing method called");
		}

		void ListView_LongPressed(object sender, MR.Gestures.LongPressEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_LongPressed method called");
		}

		void ListView_Panning(object sender, MR.Gestures.PanEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_Panning method called");
		}

		void ListView_Panned(object sender, MR.Gestures.PanEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_Panned method called");
		}

		void ListView_Swiped(object sender, MR.Gestures.SwipeEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_Swiped method called, swiped " + e.Direction);
		}

		void ListView_Pinching(object sender, MR.Gestures.PinchEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_Pinching method called");
		}

		void ListView_Pinched(object sender, MR.Gestures.PinchEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_Pinched method called");
		}

		void ListView_Rotating(object sender, MR.Gestures.RotateEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_Rotating method called");
		}

		void ListView_Rotated(object sender, MR.Gestures.RotateEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_Rotated method called");
		}

		void ListView_MouseEntered(object sender, MR.Gestures.MouseEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_MouseEntered method called");
		}

		void ListView_MouseMoved(object sender, MR.Gestures.MouseEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_MouseMoved method called");
		}

		void ListView_MouseExited(object sender, MR.Gestures.MouseEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_MouseExited method called");
		}

		void ListView_ScrollWheelChanged(object sender, MR.Gestures.ScrollWheelEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListView_ScrollWheelChanged method called");
		}
	}
}
