using Xamarin.Forms;

namespace NativeViewBindingSample
{
	public partial class NativeViewBindingSamplePage : ContentPage
	{
		public NativeViewBindingSamplePage()
		{
			InitializeComponent();
            this.BindingContext = new SampleViewModel();
		}
	}
}
