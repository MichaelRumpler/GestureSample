using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestureSample.Views.Tests;
using Xamarin.Forms;
using GestureSample.Views.AppCompat;

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

				////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

				case "Layouts":
					var layoutsVM = new[] {
						"AbsoluteLayout",
						"ContentView",
						"Frame",
						"Grid",
						"RelativeLayout",
						"ScrollView",
						"StackLayout",
					};
					var layoutsPage = new MainPage { Title = item, BindingContext = layoutsVM };
					await App.MainNavigation.PushAsync(layoutsPage);
					break;

				case "AbsoluteLayout":
					await App.MainNavigation.PushAsync(new AbsoluteLayoutXaml { BindingContext = new ViewModels.MarksViewModel() });
					break;

				case "ContentView":
					await App.MainNavigation.PushAsync(new ContentViewMain { BindingContext = new ViewModels.TransformViewModel() });
					break;

				case "Frame":
					await App.MainNavigation.PushAsync(new FrameXaml { BindingContext = new ViewModels.TransformViewModel() });
					break;

				case "Grid":
					await App.MainNavigation.PushAsync(new GridXaml { BindingContext = new ViewModels.TicTacToeViewModel() });
					break;

				case "RelativeLayout":
					await App.MainNavigation.PushAsync(new RelativeLayoutXaml { BindingContext = new ViewModels.TransformViewModel() });
					break;

				case "ScrollView":
					await App.MainNavigation.PushAsync(new ScrollViewXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() });
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
					var viewsPage = new MainPage { Title = item, BindingContext = viewsVM };
					await App.MainNavigation.PushAsync(viewsPage);
					break;

				case "ActivityIndicator":
					await App.MainNavigation.PushAsync(new ActivityIndicatorXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() });
					break;

				case "BoxView":
					await App.MainNavigation.PushAsync(new BoxViewMain { BindingContext = new ViewModels.TextOnlyViewModel() });
					break;

				case "Button":
					await App.MainNavigation.PushAsync(new ButtonXaml { BindingContext = new ViewModels.ButtonViewModel() });
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
					await App.MainNavigation.PushAsync(new ListViewMain { BindingContext = new ViewModels.ListOfStringsViewModel() });
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
					var cellsPage = new MainPage { Title = item, BindingContext = cellsVM };
					await App.MainNavigation.PushAsync(cellsPage);
					break;

				case "TextCell":
					await App.MainNavigation.PushAsync(new TextCellMain { BindingContext = new ViewModels.ListOfStringsViewModel() });
					break;

				case "ImageCell":
					await App.MainNavigation.PushAsync(new ImageCellMain { BindingContext = new ViewModels.ListOfObjectsViewModel() });
					break;

				case "All Cells":
					await App.MainNavigation.PushAsync(new AllCellsXaml { BindingContext = new ViewModels.AllCellsViewModel() });
					break;

				////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

				case "AppCompat":
					var appCompatVM = new[] {
						"AppCompat Button",
						"AppCompat Frame",
						"AppCompat Picker",
						"AppCompat Switch",
					};
					var appCompatPage = new MainPage { Title = item, BindingContext = appCompatVM };
					await App.MainNavigation.PushAsync(appCompatPage);
					break;

				case "AppCompat Button":
					await App.MainNavigation.PushAsync(new AppCompatButtonXaml { BindingContext = new ViewModels.ButtonViewModel() });
					break;

				case "AppCompat Frame":
					await App.MainNavigation.PushAsync(new AppCompatFrameXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() });
					break;

				case "AppCompat Picker":
					await App.MainNavigation.PushAsync(new AppCompatPickerXaml { BindingContext = new ViewModels.PickerViewModel() });
					break;

				case "AppCompat Switch":
					await App.MainNavigation.PushAsync(new AppCompatSwitchXaml { BindingContext = new ViewModels.ThreeBooleansViewModel() });
					break;

				////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

				case "Tests":
					var testsVM = new[] {
						"MasterDetailPage",
						"Clear in Handler",
						"Horizontal ScrollView",
						"BigButton",
                        "ViewCells",
                        "Custom ListView",
						"ScrollView with Images",
						"InputTransparent",
						"Simple LongPress",
						"Page and ListView",
						"Custom Button",
					};
					var testsPage = new MainPage { Title = item, BindingContext = testsVM };
					await App.MainNavigation.PushAsync(testsPage);
					break;

				case "MasterDetailPage":
					await App.MainNavigation.PushAsync(new FormsGallery.MasterDetailPageDemoPage());
					break;

				case "Clear in Handler":
					await App.MainNavigation.PushAsync(new DisposeInHandlerPage());
					break;

				case "Horizontal ScrollView":
					await App.MainNavigation.PushAsync(new HorizontalScrollViewXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() });
					break;

				case "BigButton":
					await App.MainNavigation.PushAsync(new BigButtonPage());
					break;

				case "ViewCells":
					await App.MainNavigation.PushAsync(new SimpleViewCellsPage());
					break;

                case "Custom ListView":
                    await App.MainNavigation.PushAsync(new CustomListViewPage { BindingContext = new ViewModels.ListOfStringsViewModel() });
                    break;

				case "ScrollView with Images":
					await App.MainNavigation.PushAsync(new ScrollViewWithImages { BindingContext = new ViewModels.CustomEventArgsViewModel() });
					break;

				case "InputTransparent":
					await App.MainNavigation.PushAsync(new InputTransparent { BindingContext = new ViewModels.TextOnlyViewModel() });
					break;

				case "Simple LongPress":
					await App.MainNavigation.PushAsync(new SimpleLongPress());
					break;

				case "Page and ListView":
					await App.MainNavigation.PushAsync(new PageAndListView { BindingContext = new ViewModels.ListOfStringsViewModel() });
					break;

				case "Custom Button":
					await App.MainNavigation.PushAsync(new CustomButtonPage() { BindingContext = new ViewModels.ButtonViewModel() });
					break;

			}
		}
	}
}
