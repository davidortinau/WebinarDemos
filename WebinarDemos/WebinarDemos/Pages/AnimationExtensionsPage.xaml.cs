using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebinarDemos
{
	public partial class AnimationExtensionsPage : ContentPage
	{
		public AnimationExtensionsPage()
		{
			InitializeComponent();
			Title = "Animations by View Extensions";
		}

		// Blocking for sequence
		//async void Handle_Clicked(object sender, System.EventArgs e)
		//{
		//	await Xamagon.FadeTo(0);
		//	await Username.FadeTo(0);
		//	await Password.FadeTo(0);
		//	await LoginButton.LayoutTo(new Rectangle(this.Width / 2, LoginButton.Y, 0, LoginButton.Height));
		//}

		// Parallel animations
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Xamagon.FadeTo(0);
			Username.FadeTo(0);
			Password.FadeTo(0);
			LoginButton.LayoutTo(new Rectangle(this.Width / 2, LoginButton.Y, 0, LoginButton.Height));
		}
	}
}
