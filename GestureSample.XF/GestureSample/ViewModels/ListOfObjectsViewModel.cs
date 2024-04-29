using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestureSample.ViewModels
{
	public class ListOfObjectsViewModel : TextOnlyViewModel
	{
		public class TextAndImage
		{
			public string Text { get; set; }
			public string Image { get; set; }

			public TextAndImage(string text, string image)
			{
				Text = text;
				Image = ImagePath + image;
			}
		}

		public readonly TextAndImage[] objects = new[] {
			new TextAndImage("One", "Pic1.png"),
			new TextAndImage("Two", "Pic2.png"),
			new TextAndImage("Three", "Pic3.png"),
			new TextAndImage("Four", "Pic4.png"),
			new TextAndImage("Five", "Pic5.png"),
			new TextAndImage("Six", "Pic6.png"),
			new TextAndImage("Seven", "Pic7.png"),
			new TextAndImage("Eight", "Pic8.png"),
			new TextAndImage("Nine", "Pic9.png"),
			new TextAndImage("Ten", "Pic10.png"),
			new TextAndImage("Eleven", "Pic11.png"),
			new TextAndImage("Twelve", "Pic12.png"),
			new TextAndImage("Thirteen", "Pic13.png"),
			new TextAndImage("Fourteen", "Pic14.png"),
			new TextAndImage("Fifteen", "Pic15.png"),
			new TextAndImage("Sixteen", "Pic16.png"),
			new TextAndImage("Seventeen", "Pic17.png"),
			new TextAndImage("Eightteen", "Pic18.png"),
			new TextAndImage("Nineteen", "Pic19.png"),
			new TextAndImage("Twenty", "Pic20.png"),
		};

		public TextAndImage[] Objects
		{
			get { return objects; }
		}

		private TextAndImage item = null;
		public TextAndImage Item
		{
			get { return item; }
			set
			{
				AddText("ListOfObjectsViewModel.Item set to " + (value == null ? "NULL" : value.Text));
				item = value;
			}
		}

		public ListOfObjectsViewModel() : base()
		{
		}
	}
}
