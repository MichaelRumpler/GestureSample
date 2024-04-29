using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestureSample.Views.Tests
{
	public class LifeCyclePage : ContentPage
	{
		private static int Instances = 0;

        public LifeCyclePage()
        {
            Instances++;
        }

		protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			base.OnPropertyChanged(propertyName);

			if (propertyName == ContentPage.TitleProperty.PropertyName)
				Debug.WriteLine($"LifeCyclePage Title set to '{Title}', {Instances} instances alive.");
		}

		~LifeCyclePage()
		{
			Instances--;
			Debug.WriteLine($"LifeCyclePage '{Title}' destroyed, {Instances} instances alive.");
		}
	}
}
