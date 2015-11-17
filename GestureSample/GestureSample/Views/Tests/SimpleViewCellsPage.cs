using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestureSample.Views.Tests
{
	public class SimpleViewCellsPage : ContentPage
	{
		public SimpleViewCellsPage()
		{
			Content = new TableView
			{
				BackgroundColor = Color.White,
				Intent = TableIntent.Form,
				Root = new TableRoot() 
				{ 
					new TableSection ("Test") 
					{
						new KeyValueCell ("ViewCell", "highlights when tapped"),
						new MRKeyValueCell ("MR.Gestures.ViewCell", "no highlight"),
					},
				}
			};
		}
	}
}
