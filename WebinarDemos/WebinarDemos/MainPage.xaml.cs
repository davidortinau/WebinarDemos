using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebinarDemos.Pages;
using Xamarin.Forms;

namespace WebinarDemos
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void PickerStandard_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PickerStandard());
        }

        private async void PickerEffect_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PickerEffect());
        }

		private async void PickerCustom_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new PickerCustom());   
       }

		private async void AnimationViewExtensions_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new AnimationExtensionsPage());
		}

		private async void CompoundAnimations_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new CompoundAnimationPage());
		}
    }
}
