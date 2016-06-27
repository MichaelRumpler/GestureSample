using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsGallery
{
    // Used in:
    //      MasterDetailPageDemoPage (as a page)
    //      TabbedPageDemoPage (as a page template)
    //      CarouselPageDemoPage (as a page template)
    //
    //  Expects BindingContext to be of type NamedColor!
	class NamedColorPage : MR.Gestures.ContentPage
    {
        public NamedColorPage()
        {
            // This binding is necessary to label the tabs in 
            //      the TabbedPage.
            this.SetBinding(ContentPage.TitleProperty, "Name");

            // BoxView to show the color.
            var boxView = new MR.Gestures.BoxView
            {
                WidthRequest = 200,
                HeightRequest = 100,
                HorizontalOptions = LayoutOptions.Center
            };
            boxView.SetBinding(BoxView.ColorProperty, "Color");
			boxView.Tapping += (s, e) => Debug.WriteLine("BoxView Tapping {0} times", e.NumberOfTaps);
			boxView.Tapped += (s, e) => Debug.WriteLine("BoxView Tapped");
			boxView.DoubleTapped += (s, e) => Debug.WriteLine("BoxView DoubleTapped");
			boxView.LongPressing += (s, e) => Debug.WriteLine("BoxView LongPressing");
			boxView.LongPressed += (s, e) => Debug.WriteLine("BoxView LongPressed for {0} ms", e.Duration);
			boxView.Panning += (s, e) => Debug.WriteLine("BoxView Panning {0}/{1}", e.TotalDistance.X, e.TotalDistance.Y);
			boxView.Panned += (s, e) => Debug.WriteLine("BoxView Panned {0}/{1}", e.TotalDistance.X, e.TotalDistance.Y);
			boxView.Swiped += (s, e) => Debug.WriteLine("BoxView Swiped {0}", e.Direction);
			boxView.Pinching += (s, e) => Debug.WriteLine("BoxView Pinching TotalScale={0}", e.TotalScale);
			boxView.Pinched += (s, e) => Debug.WriteLine("BoxView Pinched TotalScale={0}", e.TotalScale);
			boxView.Rotating += (s, e) => Debug.WriteLine("BoxView Rotating Angle={0}", e.Angle);
			boxView.Rotated += (s, e) => Debug.WriteLine("BoxView Rotated Angle={0}", e.Angle);

            // Build the page
            this.Content = new StackLayout
            {
                Children = 
                {
                    new StackLayout
                    {   
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        Children = 
                        {
                            CreateLabel("Color.R", "R = {0:F2}"),
                            CreateLabel("Color.G", "G = {0:F2}"),
                            CreateLabel("Color.B", "B = {0:F2}"),
                        }
                    },
                    boxView,
                    new StackLayout
                    {   
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        Children = 
                        {
                            CreateLabel("Color.Hue", "Hue = {0:F2}"),
                            CreateLabel("Color.Saturation", "Saturation = {0:F2}"),
                            CreateLabel("Color.Luminosity", "Luminosity = {0:F2}")
                        }
                    }
                }
            };

			this.Tapping += (s, e) => Debug.WriteLine("Detail Page Tapping {0} times", e.NumberOfTaps);
			this.Tapped += (s, e) => Debug.WriteLine("Detail Page Tapped");
			this.DoubleTapped += (s, e) => Debug.WriteLine("Detail Page DoubleTapped");
			this.LongPressing += (s, e) => Debug.WriteLine("Detail Page LongPressing");
			this.LongPressed += (s, e) => Debug.WriteLine("Detail Page LongPressed for {0} ms", e.Duration);
			//this.Panning += (s, e) => Debug.WriteLine("Detail Page Panning {0}/{1}", e.TotalDistance.X, e.TotalDistance.Y);
			//this.Panned += (s, e) => Debug.WriteLine("Detail Page Panned {0}/{1}", e.TotalDistance.X, e.TotalDistance.Y);
			//this.Swiped += (s, e) => Debug.WriteLine("Detail Page Swiped {0}", e.Direction);
			this.Pinching += (s, e) => Debug.WriteLine("Detail Page Pinching TotalScale={0}", e.TotalScale);
			this.Pinched += (s, e) => Debug.WriteLine("Detail Page Pinched TotalScale={0}", e.TotalScale);
			this.Rotating += (s, e) => Debug.WriteLine("Detail Page Rotating Angle={0}", e.Angle);
			this.Rotated += (s, e) => Debug.WriteLine("Detail Page Rotated Angle={0}", e.Angle);
        }

		private Label CreateLabel(string source, string fmt)
		{
			Label label = new Label
			{
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalTextAlignment = TextAlignment.End
			};
			label.SetBinding(Label.TextProperty,
				new Binding(source, BindingMode.OneWay, null, null, fmt));

			return label;
		}
    }
}
