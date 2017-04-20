using System;
using System.Collections.Generic;
using WebinarDemos.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace WebinarDemos
{
	public partial class PickerSpecific : ContentPage
	{
		public PickerSpecific()
		{
			InitializeComponent();
			BindingContext = new DemoViewModel();

			Title = "Picker - Platform Specifics";
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			picker.On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUpdateMode(UpdateMode.WhenFinished);
		}


	}
}
