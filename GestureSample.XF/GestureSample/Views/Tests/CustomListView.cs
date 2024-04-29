using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestureSample.Views.Tests
{
    public class CustomListView : MR.Gestures.ListView
    {
        public CustomListView() : base(Xamarin.Forms.ListViewCachingStrategy.RecycleElement)
        {
        }
    }
}
