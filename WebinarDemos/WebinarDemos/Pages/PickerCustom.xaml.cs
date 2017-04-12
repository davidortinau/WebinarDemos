using System;
using System.Collections.Generic;
using WebinarDemos.ViewModels;
using Xamarin.Forms;

namespace WebinarDemos
{
	public partial class PickerCustom : ContentPage
	{
		public PickerCustom()
		{
			InitializeComponent();
			BindingContext = new DemoViewModel();
		}
	}
}
