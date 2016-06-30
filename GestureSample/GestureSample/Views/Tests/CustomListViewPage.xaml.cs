using GestureSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GestureSample.Views.Tests
{
    public partial class CustomListViewPage : ContentPage
    {
        public CustomListViewPage()
        {
            InitializeComponent();
        }

        void Cell_Down(object sender, MR.Gestures.DownUpEventArgs e)
        {
            ((TextOnlyViewModel)BindingContext).AddText("Cell_Down method called with " + e.TriggeringTouches.Length + " fingers");
        }

        void Cell_Up(object sender, MR.Gestures.DownUpEventArgs e)
        {
            ((TextOnlyViewModel)BindingContext).AddText("Cell_Up method called with " + e.TriggeringTouches.Length + " fingers");
        }

        void Cell_Tapping(object sender, MR.Gestures.TapEventArgs e)
        {
            ((TextOnlyViewModel)BindingContext).AddText("Cell_Tapping method called " + e.NumberOfTaps + " times");
        }

        void Cell_Tapped(object sender, MR.Gestures.TapEventArgs e)
        {
            ((TextOnlyViewModel)BindingContext).AddText("Cell_Tapped method called " + e.NumberOfTaps + " times");
        }

        void Cell_DoubleTapped(object sender, MR.Gestures.TapEventArgs e)
        {
            ((TextOnlyViewModel)BindingContext).AddText("Cell_DoubleTapped method called " + e.NumberOfTaps + " times");
        }

        void Cell_LongPressing(object sender, MR.Gestures.LongPressEventArgs e)
        {
            ((TextOnlyViewModel)BindingContext).AddText("Cell_LongPressing method called");
        }

        void Cell_LongPressed(object sender, MR.Gestures.LongPressEventArgs e)
        {
            ((TextOnlyViewModel)BindingContext).AddText("Cell_LongPressed method called");
        }

        void Cell_Panning(object sender, MR.Gestures.PanEventArgs e)
        {
            ((TextOnlyViewModel)BindingContext).AddText("Cell_Panning method called");
        }

        void Cell_Panned(object sender, MR.Gestures.PanEventArgs e)
        {
            ((TextOnlyViewModel)BindingContext).AddText("Cell_Panned method called");
        }

        void Cell_Swiped(object sender, MR.Gestures.SwipeEventArgs e)
        {
            ((TextOnlyViewModel)BindingContext).AddText("Cell_Swiped method called, swiped " + e.Direction);
        }

        void Cell_Pinching(object sender, MR.Gestures.PinchEventArgs e)
        {
            ((TextOnlyViewModel)BindingContext).AddText("Cell_Pinching method called");
        }

        void Cell_Pinched(object sender, MR.Gestures.PinchEventArgs e)
        {
            ((TextOnlyViewModel)BindingContext).AddText("Cell_Pinched method called");
        }

        void Cell_Rotating(object sender, MR.Gestures.RotateEventArgs e)
        {
            ((TextOnlyViewModel)BindingContext).AddText("Cell_Rotating method called");
        }

        void Cell_Rotated(object sender, MR.Gestures.RotateEventArgs e)
        {
            ((TextOnlyViewModel)BindingContext).AddText("Cell_Rotated method called");
        }
    }
}
