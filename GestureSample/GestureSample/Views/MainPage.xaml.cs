using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using GestureSample.Views.Tests;
using GestureSample.Views.Legacy;


namespace GestureSample.Views
{
	public partial class MainPage
	{
		private PageConfig[] AllPages = new PageConfig[]
		{
			// main page
			new PageConfig(null, "ContentPage", () => new ContentPageXaml { BindingContext = new ViewModels.TransformImageViewModel() }),
			new PageConfig(null, "Layouts", null),
			new PageConfig(null, "Views", null),
			new PageConfig(null, "Cells", null),
			new PageConfig(null, "Legacy", null),
			new PageConfig(null, "Tests", null),

			// Layouts
			new PageConfig("Layouts", "AbsoluteLayout", () => new AbsoluteLayoutXaml { BindingContext = new ViewModels.MarksViewModel() }),
			new PageConfig("Layouts", "ContentView", () => new ContentViewMain { BindingContext = new ViewModels.TransformViewModel() }),
			new PageConfig("Layouts", "FlexLayout", () => new FlexLayoutXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() }),
			new PageConfig("Layouts", "Frame", () => new FrameXaml { BindingContext = new ViewModels.TransformViewModel() }),
			new PageConfig("Layouts", "Grid", () => new GridXaml { BindingContext = new ViewModels.TicTacToeViewModel() }),
			new PageConfig("Layouts", "RelativeLayout", () => new RelativeLayoutXaml { BindingContext = new ViewModels.TransformViewModel() }),
			new PageConfig("Layouts", "ScrollView", () => new ScrollViewXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() }),
			new PageConfig("Layouts", "StackLayout", () => new StackLayoutXaml { BindingContext = new ViewModels.TransformViewModel() }),
			new PageConfig("Layouts", "TabbedPage", () => new TabbedPageXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() }),

			// Views
			new PageConfig("Views", "ActivityIndicator", () => new ActivityIndicatorXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() }),
			new PageConfig("Views", "BoxView", () => new BoxViewMain { BindingContext = new ViewModels.TextOnlyViewModel() }),
			new PageConfig("Views", "Button", () => new ButtonXaml { BindingContext = new ViewModels.ButtonViewModel() }),
			new PageConfig("Views", "DatePicker", () => new DatePickerXaml { BindingContext = new ViewModels.ThreeDatesViewModel() }),
			new PageConfig("Views", "Editor", () => new EditorXaml { BindingContext = new ViewModels.ThreeStringsViewModel() }),
			new PageConfig("Views", "Entry", () => new EntryXaml { BindingContext = new ViewModels.ThreeStringsViewModel() }),
			new PageConfig("Views", "Image", () => new ImageXaml { BindingContext = new ViewModels.TransformImageViewModel() }),
			new PageConfig("Views", "Label", () => new LabelXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() }),
			new PageConfig("Views", "ListView", () => new ListViewMain { BindingContext = new ViewModels.ListOfStringsViewModel() }),
			new PageConfig("Views", "Picker", () => new PickerXaml { BindingContext = new ViewModels.PickerViewModel() }),
			new PageConfig("Views", "ProgressBar", () => new ProgressBarXaml { BindingContext = new ViewModels.ProgressBarViewModel() }),
			new PageConfig("Views", "SearchBar", () => new SearchBarXaml { BindingContext = new ViewModels.SearchBarViewModel() }),
			new PageConfig("Views", "Slider", () => new SliderXaml { BindingContext = new ViewModels.ThreeDoublesViewModel() }),
			new PageConfig("Views", "Stepper", () => new StepperXaml { BindingContext = new ViewModels.ThreeDoublesViewModel() }),
			new PageConfig("Views", "Switch", () => new SwitchXaml { BindingContext = new ViewModels.ThreeBooleansViewModel() }),
			new PageConfig("Views", "TableView", () => new TableViewXaml { BindingContext = new ViewModels.AllCellsViewModel() }),
			new PageConfig("Views", "TimePicker", () => new TimePickerXaml { BindingContext = new ViewModels.ThreeTimesViewModel() }),
			new PageConfig("Views", "WebView", () => new WebViewXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() }),

			// Cells
			new PageConfig("Cells", "TextCell", () => new TextCellMain { BindingContext = new ViewModels.ListOfStringsViewModel() }),
			new PageConfig("Cells", "ImageCell", () => new ImageCellMain { BindingContext = new ViewModels.ListOfObjectsViewModel() }),
			new PageConfig("Cells", "All Cells", () => new AllCellsXaml { BindingContext = new ViewModels.AllCellsViewModel() }),

			// Legacy
			new PageConfig("Legacy", "Legacy Button", () => new LegacyButtonXaml { BindingContext = new ViewModels.ButtonViewModel() }),
			new PageConfig("Legacy", "Legacy Frame", () => new LegacyFrameXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() }),
			new PageConfig("Legacy", "Legacy Picker", () => new LegacyPickerXaml { BindingContext = new ViewModels.PickerViewModel() }),
			new PageConfig("Legacy", "Legacy Switch", () => new LegacySwitchXaml { BindingContext = new ViewModels.ThreeBooleansViewModel() }),

			// Tests
			new PageConfig("Tests", "MasterDetailPage", () => new FormsGallery.MasterDetailPageDemoPage()),
			new PageConfig("Tests", "Clear in Handler", () => new DisposeInHandlerPage()),
			new PageConfig("Tests", "Horizontal ScrollView", () => new HorizontalScrollViewXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() }),
			new PageConfig("Tests", "BigButton", () => new BigButtonPage()),
			new PageConfig("Tests", "ViewCells", () => new SimpleViewCellsPage()),
			new PageConfig("Tests", "Custom ListView", () => new CustomListViewPage { BindingContext = new ViewModels.ListOfStringsViewModel() }),
			new PageConfig("Tests", "ScrollView with Images", () => new ScrollViewWithImages { BindingContext = new ViewModels.CustomEventArgsViewModel() }),
			new PageConfig("Tests", "InputTransparent", () => new InputTransparent { BindingContext = new ViewModels.TextOnlyViewModel() }),
			new PageConfig("Tests", "Simple LongPress", () => new SimpleLongPress()),
			new PageConfig("Tests", "Page and ListView", () => new PageAndListView { BindingContext = new ViewModels.ListOfStringsViewModel() }),
			new PageConfig("Tests", "Custom Button", () => new CustomButtonPage() { BindingContext = new ViewModels.ButtonViewModel() }),
			new PageConfig("Tests", "Nested Controls", () => new NestedControls()),
			new PageConfig("Tests", "BottomTabbedPage", () => new BottomTabbedPageXaml { BindingContext = new ViewModels.CustomEventArgsViewModel() }),
			new PageConfig("Tests", "Delete Bound Items", () => new DeleteBoundItems { BindingContext = new ViewModels.Tests.DeleteBoundItemsViewModel() }),
			new PageConfig("Tests", "Scaling X and Y seperately", () => new FrameScaleXYXaml { BindingContext = new ViewModels.TransformViewModel() }),
			new PageConfig("Tests", "Dynamically add Event handler", () => new DynamicallyAddHandler { BindingContext = new ViewModels.CustomEventArgsViewModel() }),
			new PageConfig("Tests", "Test first panning args", () => new PrintFirstPanning { BindingContext = new ViewModels.CustomEventArgsViewModel() }),
		};


		#region MainPage code

		public MainPage(string title, IEnumerable<PageConfig> contents)
		{
			Title = title;
			if (contents == null)
				contents = AllPages.Where(pc => pc.Parent == null);
			BindingContext = contents;

			InitializeComponent();
		}

		private async void ListItem_Tapped(object sender, ItemTappedEventArgs e)
		{
			var item = (PageConfig)e.Item;

			if(item.PageConstructor != null)
			{
				// a sample page
				var page = item.PageConstructor.Invoke();
				await App.MainNavigation.PushAsync(page);
			}
			else
			{
				// a menu page
				var subpage = item.Title;
				var contents = AllPages.Where(pc => pc.Parent == subpage);
				var page = new MainPage(subpage, contents);
				await App.MainNavigation.PushAsync(page);
			}
		}

		#endregion

		#region class PageConfig

		public class PageConfig
		{
			public string Parent { get; }
			public string Title { get; }
			public Func<Page> PageConstructor { get; }

			public PageConfig(string parent, string title, Func<Page> pageConstructor)
			{
				Parent = parent;
				Title = title;
				PageConstructor = pageConstructor;
			}
		}

		#endregion class PageConfig
	}
}
