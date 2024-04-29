using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestureSample.ViewModels
{
	public class TransformViewModel : CustomEventArgsViewModel
	{
		#region Properties

		protected double anchorX = 0.5;
		public double AnchorX
		{
			get { return anchorX; }
			set { SetProperty(ref anchorX, value); }
		}

		protected double anchorY = 0.5;
		public double AnchorY
		{
			get { return anchorY; }
			set { SetProperty(ref anchorY, value); }
		}

		protected double rotation = 0;
		public double Rotation
		{
			get { return rotation; }
			set { SetProperty(ref rotation, value); }
		}

		protected double scale = 1;
		public double Scale
		{
			get { return scale; }
			set { SetProperty(ref scale, value); }
		}

		protected double scaleX = 1;
		public double ScaleX
		{
			get { return scaleX; }
			set { SetProperty(ref scaleX, value); }
		}

		protected double scaleY = 1;
		public double ScaleY
		{
			get { return scaleY; }
			set { SetProperty(ref scaleY, value); }
		}

		protected double translationX = 0;
		public double TranslationX
		{
			get { return translationX; }
			set { SetProperty(ref translationX, value); }
		}

		protected double translationY = 0;
		public double TranslationY
		{
			get { return translationY; }
			set { SetProperty(ref translationY, value); }
		}

		public double ViewX { get; set; }
		public double ViewY { get; set; }
		public double ViewWidth { get; set; }
		public double ViewHeight { get; set; }

		#endregion

		protected override void OnPanning(MR.Gestures.PanEventArgs e)
		{
			base.OnPanning(e);

			TranslationX += e.DeltaDistance.X;
			TranslationY += e.DeltaDistance.Y;
		}
		protected override void OnPinching(MR.Gestures.PinchEventArgs e)
		{
			base.OnPinching(e);

			SetAnchor(e.Center);
			var newScale = Scale * e.DeltaScale;
			Scale = Math.Min(5, Math.Max(0.1, newScale));
			var newScaleX = ScaleX * e.DeltaScaleX;
			ScaleX = Math.Min(5, Math.Max(0.1, newScaleX));
			var newScaleY = ScaleY * e.DeltaScaleY;
			ScaleY = Math.Min(5, Math.Max(0.1, newScaleY));
		}

		protected override void OnRotating(MR.Gestures.RotateEventArgs e)
		{
			base.OnRotating(e);

			SetAnchor(e.Center);
			Rotation += e.DeltaAngle;
		}

		protected void SetAnchor(Point center)
		{
			// in AnchorX/Y 0.0 means the top left corner and 1.0 means the bottom right
			// unfortunately I don't know how to calculate this correct if Translation, Scale and Rotation is used

			//var xWithinView = center.X - ViewX;
			//var yWithinView = center.Y - ViewY;
			//AnchorX = ViewWidth / xWithinView;
			//AnchorY = ViewHeight / yWithinView;
		}
	}
}
