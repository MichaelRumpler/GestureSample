using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GestureSample.ViewModels
{
	public class SearchBarViewModel : ThreeStringsViewModel
	{
		public ICommand SearchCommand { get; protected set; }

		public SearchBarViewModel()
		{
			SearchCommand = new Command<object>(OnSearch);

		}

		private void OnSearch(object obj)
		{
			// although the SearchBar.SearchCommandParameter is a string, this string is not passed to this method.
			// this is a bug in Xamarin.Forms.

			string parameter = obj as string;

			if (parameter != null)
			{
				AddText("Search button was clicked. Parameter passed to the command is '{0}' - a string as it should be.", parameter);

			}
			else
			{
				AddText("Search button was clicked. Parameter passed to the command is a {0} but it should be a string.", obj.GetType().Name);
			}
		}
	}
}
