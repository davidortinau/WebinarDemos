using System;

using Xamarin.Forms;

namespace WebinarDemos
{
	public class CsPage : ContentPage
	{
		public CsPage()
		{
			Content = new Label { 
				Text = "This is a CS Page!" ,
				HorizontalOptions = LayoutOptions.Fill,
				VerticalOptions = LayoutOptions.Center,
				FontSize = 48,
				HorizontalTextAlignment= TextAlignment.Center
			
			};
		}
	}
}

