using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestureSample.ViewModels;
using MR.Gestures;
using static GestureSample.ViewModels.ListOfObjectsViewModel;

namespace GestureSample.Views
{
	public partial class CollectionViewVertical
	{
		public CollectionViewVertical()
		{
			InitializeComponent();
		}

		private void CollectionView_SelectionChanged(object sender, Xamarin.Forms.SelectionChangedEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText($"CollectionView_SelectionChanged method called, Item = {((TextAndImage)e.CurrentSelection.FirstOrDefault()).Text}");
		}

		void CollectionView_Down(object sender, MR.Gestures.DownUpEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("CollectionView_Down method called with " + e.TriggeringTouches.Length + " fingers");
		}

		void CollectionView_Up(object sender, MR.Gestures.DownUpEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("CollectionView_Up method called with " + e.TriggeringTouches.Length + " fingers");
		}

		void CollectionView_Tapping(object sender, MR.Gestures.TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("CollectionView_Tapping method called " + e.NumberOfTaps + " times");
		}

		void CollectionView_Tapped(object sender, MR.Gestures.TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("CollectionView_Tapped method called " + e.NumberOfTaps + " times");
		}

		void CollectionView_DoubleTapped(object sender, MR.Gestures.TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("CollectionView_DoubleTapped method called " + e.NumberOfTaps + " times");
		}

		void CollectionView_LongPressing(object sender, MR.Gestures.LongPressEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("CollectionView_LongPressing method called");
		}

		void CollectionView_LongPressed(object sender, MR.Gestures.LongPressEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("CollectionView_LongPressed method called");
		}

		void CollectionView_Panning(object sender, MR.Gestures.PanEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("CollectionView_Panning method called");
		}

		void CollectionView_Panned(object sender, MR.Gestures.PanEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("CollectionView_Panned method called");
		}

		void CollectionView_Swiped(object sender, MR.Gestures.SwipeEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("CollectionView_Swiped method called, swiped " + e.Direction);
		}

		void CollectionView_Pinching(object sender, MR.Gestures.PinchEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("CollectionView_Pinching method called");
		}

		void CollectionView_Pinched(object sender, MR.Gestures.PinchEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("CollectionView_Pinched method called");
		}

		void CollectionView_Rotating(object sender, MR.Gestures.RotateEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("CollectionView_Rotating method called");
		}

		void CollectionView_Rotated(object sender, MR.Gestures.RotateEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("CollectionView_Rotated method called");
		}
	}
}
