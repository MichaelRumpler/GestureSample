namespace GestureSample.Views.Tests
{
	public class SimpleViewCellsPage : ContentPage
	{
		public SimpleViewCellsPage()
		{
			Content = new TableView
			{
				BackgroundColor = Colors.White,
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
