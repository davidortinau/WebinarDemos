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
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}

		public MainPage()
		{
			InitializeComponent();
		}

		private async void XamlPage_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new XamlPage());
		}

		private async void CsPage_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new CsPage());
		}

        private async void PickerStandard_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PickerStandard());
        }

        private async void PickerEffect_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PickerEffect());
        }

		private async void PickerEffect2_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new PickerEffectBinding());
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

		private async void LayoutWasteful_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new LayoutWasteful());
		}

		private async void LayoutOptimized_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new LayoutOptimized());
		}

		void Special_Clicked(object sender, System.EventArgs e)
		{
			// do something
		}
    }
}
