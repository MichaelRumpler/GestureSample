using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestureSample.Views.Tests
{
	public partial class TappedViewCellPage : ContentPage
	{
		public TappedViewCellPage()
		{
			InitializeComponent();

            MyTableView.Root = new TableRoot();
            var tableSection = new TableSection("Table Section");
            MyTableView.Root.Add(tableSection);
            for (int i = 0; i < 20; i++)
            {
                var cell = new MR.Gestures.ViewCell();
                tableSection.Add(cell);
                var layout = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    VerticalOptions = LayoutOptions.Center,

                };
                var cellName = "Cell " + i;
                var label = new Label
                {
                    Text = cellName
                };

                layout.Children.Add(label);
                cell.View = layout;
                cell.Tapped += (s,e) =>
                {
                    DisplayAlert("", cellName + " Tapped, Cancelled = " + e.Cancelled, "OK");
                };
            }
        }
    }
}