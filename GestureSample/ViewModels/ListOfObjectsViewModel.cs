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
			new TextAndImage("One", "pic1.png"),
			new TextAndImage("Two", "pic2.png"),
			new TextAndImage("Three", "pic3.png"),
			new TextAndImage("Four", "pic4.png"),
			new TextAndImage("Five", "pic5.png"),
			new TextAndImage("Six", "pic6.png"),
			new TextAndImage("Seven", "pic7.png"),
			new TextAndImage("Eight", "pic8.png"),
			new TextAndImage("Nine", "pic9.png"),
			new TextAndImage("Ten", "pic10.png"),
			new TextAndImage("Eleven", "pic11.png"),
			new TextAndImage("Twelve", "pic12.png"),
			new TextAndImage("Thirteen", "pic13.png"),
			new TextAndImage("Fourteen", "pic14.png"),
			new TextAndImage("Fifteen", "pic15.png"),
			new TextAndImage("Sixteen", "pic16.png"),
			new TextAndImage("Seventeen", "pic17.png"),
			new TextAndImage("Eightteen", "pic18.png"),
			new TextAndImage("Nineteen", "pic19.png"),
			new TextAndImage("Twenty", "pic20.png"),
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
