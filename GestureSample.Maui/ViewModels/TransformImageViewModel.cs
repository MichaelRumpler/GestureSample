namespace GestureSample.ViewModels
{
	public class TransformImageViewModel : TransformViewModel
	{
		protected string[] images = new[] { "flusi1.jpg", "flusi2.jpg", "flusi3.jpg" };
		protected int currentImage = 0;
		public string ImageSource
		{
			get { return ImagePath + images[currentImage]; }
		}

		protected override void OnSwiped(MR.Gestures.SwipeEventArgs e)
		{
			base.OnSwiped(e);

			if (e.Direction == MR.Gestures.Direction.Right)
			{
				currentImage--;
				if (currentImage < 0)
					currentImage = images.Length - 1;
				NotifyPropertyChanged(() => ImageSource);
			}
			else if (e.Direction == MR.Gestures.Direction.Left)
			{
				currentImage++;
				if (currentImage >= images.Length)
					currentImage = 0;
				NotifyPropertyChanged(() => ImageSource);
			}
		}



		public TransformImageViewModel()
			: base()
		{
		}
	}
}
