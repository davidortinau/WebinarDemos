using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebinarDemos.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebinarDemos.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerEffect : ContentPage
	{
		public PickerEffect ()
		{
			InitializeComponent ();
            BindingContext = new DemoViewModel();
        }
	}
}
