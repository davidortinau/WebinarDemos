using System;
using System.Collections.Generic;
using WebinarDemos.ViewModels;
using Xamarin.Forms;

namespace WebinarDemos
{
	public partial class ListViewOptimizedPage : ContentPage
	{
		public ListViewOptimizedPage()
		{
			InitializeComponent();

			BindingContext = new DemoViewModel();
		}
	}
}
