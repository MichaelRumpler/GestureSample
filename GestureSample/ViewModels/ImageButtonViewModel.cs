using System;
using System.Collections.Generic;
using System.Text;

namespace GestureSample.ViewModels
{
	public class ImageButtonViewModel : ButtonViewModel
	{
		public string Pic1 { get; } = ImagePath + "flusi1.jpg";
		public string Pic2 { get; } = ImagePath + "flusi2.jpg";
		public string Pic3 { get; } = ImagePath + "flusi3.jpg";
	}
}
