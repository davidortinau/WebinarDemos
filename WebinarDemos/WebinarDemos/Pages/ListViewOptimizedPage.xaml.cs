using System;
using System.Collections.Generic;
using WebinarDemos.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Platform = Xamarin.Forms.PlatformConfiguration;

namespace WebinarDemos
{
	public partial class ListViewOptimizedPage : ContentPage
	{
		public ListViewOptimizedPage()
		{
			InitializeComponent();

			BindingContext = new DemoViewModel();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            listView.On<Platform::Android>().SetIsFastScrollEnabled(true);
        }
    }
}
