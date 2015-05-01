using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class MasterDetailPageDemoPage :  MasterDetailPage
    {
		// I only have one MasterDetailPageDemoPage so this is good enough to access it from the Detail pages.
		public static MasterDetailPageDemoPage Instance { get; private set; }

        public MasterDetailPageDemoPage()
        {
			Instance = this;

            Label header = new Label
            {
                Text = "MasterDetailPage",
				FontSize = 30,
				FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

			Button button = new Button { Text = "TabbedPage" };
			button.Clicked += (s, e) => { this.IsPresented = false; };		// Show the detail page on button click.

			Label description = new Label { Text = "In this sample the event data will only show up in the debug window." };

            // Create the master page with the ListView.
            this.Master = new ContentPage
            {
                Title = "Master Page",       // Title required!
                Content = new StackLayout
                {
                    Children = 
                    {
                        header,
                        button,
						description
                    }
                }
            };

			// Create the detail page using TabbedPageDemoPage
            this.Detail = new TabbedPageDemoPage();
        }
    }
}
