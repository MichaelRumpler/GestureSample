﻿namespace GestureSample.Views.Tests
{
	public partial class PrintFirstPanning
	{
		MR.Gestures.PanEventArgs last;

		public PrintFirstPanning ()
		{
			InitializeComponent ();
		}

		private void ContentPage_Panning(object sender, MR.Gestures.PanEventArgs e)
		{
			if (last == null)
				((ViewModels.CustomEventArgsViewModel)BindingContext).AddText($"starting pan gesture, DeltaDistance={e.DeltaDistance.X}/{e.DeltaDistance.Y}, TotalDistance={e.TotalDistance.X}/{e.TotalDistance.Y}, Velocity={e.Velocity.X}/{e.Velocity.Y}");
			last = e;
		}

		private void ContentPage_Panned(object sender, MR.Gestures.PanEventArgs e)
		{
			last = null;
		}
	}
}