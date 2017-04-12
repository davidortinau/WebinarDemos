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
	public partial class PickerStandard : ContentPage
	{
		public PickerStandard ()
		{
			InitializeComponent ();

            BindingContext = new DemoViewModel();

			Title = "Picker";
		}
	}
}
