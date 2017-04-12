using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WebinarDemos
{
	public partial class CompoundAnimationPage : ContentPage
	{
		public CompoundAnimationPage()
		{
			InitializeComponent();
			Title = "Compound Animations";
		}

		private void Handle_Clicked(object sender, System.EventArgs e)
		{
			var storyboard = new Animation();
			var xamagonOut = new Animation(callback: d => Xamagon.Scale = d,
										  start: 1,
										  end: 0,
										  easing: Easing.SpringOut);


			var usernameOut = new Animation(callback: d => Username.TranslationX = d,
										   	start: 0,
			                                end: this.Width,
										   	easing: Easing.SpringIn);

			var passwordOut = new Animation(callback: d => Password.TranslationX = d,
										   	start: 0,
											end: this.Width,
										   	easing: Easing.SpringIn);
			
			var buttonRadiusOut = new Animation(callback: d => LoginButton.BorderRadius = (int)d,
										   		start: 0,
												end: LoginButton.Height/2,
			                                    easing: Easing.Linear);

			//var buttonWidthOut = new Animation(callback: d => LoginButton.WidthRequest = d,
			//                                   start: 400,
			//									end: 40,
			//									easing: Easing.Linear);

			var buttonOut = new Animation(callback: d => LoginButton.Scale = d,
										  start: 1,
										  end: 0,
			                              easing: Easing.SpringIn);



			storyboard.Add (0, 0.5, xamagonOut);
		    storyboard.Add (0.1, 0.5, usernameOut);
		    storyboard.Add (0.2, 0.6, passwordOut);
			storyboard.Add (0.5, 0.7, buttonRadiusOut);
			//storyboard.Add (0.3, 0.5, buttonWidthOut);
			storyboard.Add (0.7, 1, buttonOut);

			storyboard.Commit (LoginButton, "out", length: 2000);
		}
	}
}
