namespace GestureSample.Views.Tests
{
    public class CustomListView : MR.Gestures.ListView
    {
        public CustomListView() : base(ListViewCachingStrategy.RecycleElement)
        {
        }
    }
}
