using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestureSample.Views
{
	public partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void ListItem_Tapped(object sender, ItemTappedEventArgs e)
		{
			var item = e.Item.ToString();
			switch(item)
			{
				case "ContentPage":
					await App.MainNavigation.PushAsync(new ContentPageXaml { BindingContext = new ViewModels.TransformImageViewModel() });
					break;

				case "MasterDetailPage":
					await App.MainNavigation.PushAsync(new FormsGallery.MasterDetailPageDemoPage());
					break;

				////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

				case "Layouts":
					var layoutsVM = new[] {
						"ContentView",
						"Frame",
						"ScrollView",
						"AbsoluteLayout",
						"Grid",
						"RelativeLayout",
						"StackLayout",
					};
					var layoutsPage = new MainPage { Title = "Layouts", BindingContext = layoutsVM };
					await App.MainNavigation.PushAsync(layoutsPage);
					break;

				case "ContentView":
					await App.MainNavigation.PushAsync(new ContentViewMain { BindingContext = new ViewModels.TransformViewModel() });
					break;

				case "Frame":
					await App.MainNavigation.PushAsync(new FrameXaml { BindingContext = new ViewModels.TransformViewModel() });
					break;

				case "ScrollView":
					await App.MainNavigation.PushAsync(new ScrollViewXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() });
					break;

				case "AbsoluteLayout":
					await App.MainNavigation.PushAsync(new AbsoluteLayoutXaml { BindingContext = new ViewModels.MarksViewModel() });
					break;

				case "Grid":
					await App.MainNavigation.PushAsync(new GridXaml { BindingContext = new ViewModels.TicTacToeViewModel() });
					break;

				case "RelativeLayout":
					await App.MainNavigation.PushAsync(new RelativeLayoutXaml { BindingContext = new ViewModels.TransformViewModel() });
					break;

				case "StackLayout":
					await App.MainNavigation.PushAsync(new StackLayoutXaml { BindingContext = new ViewModels.TransformViewModel() });
					break;

				////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

				case "Views":
					var viewsVM = new[] {
						"ActivityIndicator",
						"BoxView",
						"Button",
						"DatePicker",
						"Editor",
						"Entry",
						"Image",
						"Label",
						"ListView",
						"Picker",
						"ProgressBar",
						"SearchBar",
						"Slider",
						"Stepper",
						"Switch",
						"TableView",
						"TimePicker",
						"WebView",
					};
					var viewsPage = new MainPage { Title = "Layouts", BindingContext = viewsVM };
					await App.MainNavigation.PushAsync(viewsPage);
					break;

				case "ActivityIndicator":
					await App.MainNavigation.PushAsync(new ActivityIndicatorXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() });
					break;

				case "BoxView":
					await App.MainNavigation.PushAsync(new BoxViewMain { BindingContext = new ViewModels.TextOnlyViewModel() });
					break;

				case "Button":
					await App.MainNavigation.PushAsync(new ButtonXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() });
					break;

				case "DatePicker":
					await App.MainNavigation.PushAsync(new DatePickerXaml { BindingContext = new ViewModels.ThreeDatesViewModel() });
					break;

				case "Editor":
					await App.MainNavigation.PushAsync(new EditorXaml { BindingContext = new ViewModels.ThreeStringsViewModel() });
					break;

				case "Entry":
					await App.MainNavigation.PushAsync(new EntryXaml { BindingContext = new ViewModels.ThreeStringsViewModel() });
					break;

				case "Image":
					await App.MainNavigation.PushAsync(new ImageXaml { BindingContext = new ViewModels.TransformImageViewModel() });
					break;

				case "Label":
					await App.MainNavigation.PushAsync(new LabelXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() });
					break;

				case "ListView":
					await App.MainNavigation.PushAsync(new ListViewXaml { BindingContext = new ViewModels.ListOfStringsViewModel() });
					break;

				case "Picker":
					await App.MainNavigation.PushAsync(new PickerXaml { BindingContext = new ViewModels.PickerViewModel() });
					break;

				case "ProgressBar":
					await App.MainNavigation.PushAsync(new ProgressBarXaml { BindingContext = new ViewModels.ProgressBarViewModel() });
					break;

				case "SearchBar":
					await App.MainNavigation.PushAsync(new SearchBarXaml { BindingContext = new ViewModels.SearchBarViewModel() });
					break;

				case "Slider":
					await App.MainNavigation.PushAsync(new SliderXaml { BindingContext = new ViewModels.ThreeDoublesViewModel() });
					break;

				case "Stepper":
					await App.MainNavigation.PushAsync(new StepperXaml { BindingContext = new ViewModels.ThreeDoublesViewModel() });
					break;

				case "Switch":
					await App.MainNavigation.PushAsync(new SwitchXaml { BindingContext = new ViewModels.ThreeBooleansViewModel() });
					break;

				case "TableView":
					await App.MainNavigation.PushAsync(new TableViewXaml { BindingContext = new ViewModels.AllCellsViewModel() });
					break;

				case "TimePicker":
					await App.MainNavigation.PushAsync(new TimePickerXaml { BindingContext = new ViewModels.ThreeTimesViewModel() });
					break;

				case "WebView":
					await App.MainNavigation.PushAsync(new WebViewXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() });
					break;

				////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

				case "Cells":
					var cellsVM = new[] {
						"TextCell",
						"ImageCell",
						"All Cells",
					};
					var cellsPage = new MainPage { Title = "Cells", BindingContext = cellsVM };
					await App.MainNavigation.PushAsync(cellsPage);
					break;

				////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

				case "TextCell":
					await App.MainNavigation.PushAsync(new TextCellMain { BindingContext = new ViewModels.ListOfStringsViewModel() });
					break;

				case "ImageCell":
					await App.MainNavigation.PushAsync(new ImageCellMain { BindingContext = new ViewModels.ListOfObjectsViewModel() });
					break;

				case "All Cells":
					await App.MainNavigation.PushAsync(new AllCellsXaml { BindingContext = new ViewModels.AllCellsViewModel() });
					break;

			}
		}
	}
}
