using System;
using System.Collections.Generic;
using WebinarDemos.ViewModels;
using Xamarin.Forms;

namespace WebinarDemos
{
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage()
		{
			InitializeComponent();
			BindingContext = new DemoViewModel();
		}
	}
}
