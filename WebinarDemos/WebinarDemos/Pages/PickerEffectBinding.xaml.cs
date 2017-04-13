using System;
using System.Collections.Generic;
using WebinarDemos.ViewModels;
using Xamarin.Forms;

namespace WebinarDemos
{
	public partial class PickerEffectBinding : ContentPage
	{
		public PickerEffectBinding()
		{
			InitializeComponent();

			BindingContext = new DemoViewModel();
		}
	}
}
