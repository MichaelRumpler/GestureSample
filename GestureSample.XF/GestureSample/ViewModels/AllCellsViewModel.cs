using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestureSample.ViewModels
{
	public class AllCellsViewModel : CustomEventArgsViewModel
	{
		public string Icon1 { get { return ImagePath + "Pic1.png"; } }
		public string Icon2 { get { return ImagePath + "Pic2.png"; } }
		public string Icon3 { get { return ImagePath + "Pic3.png"; } }
		public string Icon4 { get { return ImagePath + "Pic4.png"; } }
		public string Icon5 { get { return ImagePath + "Pic5.png"; } }

		public string EntryValue { get; set; }

		private bool switchValue = true;
		public bool SwitchValue
		{
			get { return switchValue; }
			set
			{
				SetProperty(ref switchValue, value);
			}
		}
	}
}
