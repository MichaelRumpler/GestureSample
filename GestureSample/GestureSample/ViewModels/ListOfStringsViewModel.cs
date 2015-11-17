using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestureSample.ViewModels
{
	public class ListOfStringsViewModel : TextOnlyViewModel
	{
		public readonly string[] strings = new[] {
			"One",
			"Two",
			"Three",
			"Four",
			"Five",
			"Six",
			"Seven",
			"Eight",
			"Nine",
			"Ten",
			"Eleven",
			"Twelve",
			"Thirteen",
			"Fourteen",
			"Fifteen",
			"Sixteen",
			"Seventeen",
			"Eightteen",
			"Nineteen",
			"Twenty",
			"Twentyone",
			"Twentytwo",
			"Twentythree",
			"Twentyfour",
			"Twentyfive",
			"Twentysix",
			"Twentyseven",
			"Twentyeight",
			"Twentynine",
			"Thirty",
			"Thirtyone",
			"Thirtytwo",
			"Thirtythree",
			"Thirtyfour",
			"Thirtyfive",
			"Thirtysix",
			"Thirtyseven",
			"Thirtyeight",
			"Thirtynine",
			"Fourty",
		};

		public string[] Strings
		{
			get
			{
				return strings;
			}
		}

		public ListOfStringsViewModel() : base()
		{
		}
	}
}
