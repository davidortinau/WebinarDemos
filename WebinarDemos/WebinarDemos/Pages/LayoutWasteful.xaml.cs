using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
#if __ANDROID__
using Xamarin.Forms.Platform.Android;
using Android.Views;
#endif
#if __IOS__
using Xamarin.Forms.Platform.iOS;
#endif

namespace WebinarDemos
{
	public partial class LayoutWasteful : ContentPage
	{
		public LayoutWasteful()
		{
			InitializeComponent();

			Title = "Layout Wasteful";
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

#if __IOS__
			System.Diagnostics.Debug.WriteLine("I'm in iOS");
			var native = Platform.GetRenderer(this);
			var myBabies = native.NativeView.Descendants();
			var enumerator = myBabies.GetEnumerator();
			var counter = 0;
			while (enumerator.MoveNext())
			{
				counter++;
			}
			Debug.WriteLine("babies " + counter);
#endif

#if __ANDROID__
			System.Diagnostics.Debug.WriteLine("I'm in Android");
			var native = Platform.GetRenderer(this);
			//var result = getAllChildren(native.ViewGroup.GetChildAt(0));
			//Debug.WriteLine("babies " + result.Count);
#endif

		}
	

#if __ANDROID__
		//private List<Android.Views.View> getAllChildren(Android.Views.View v)
		//{

		//	if (v.GetType() == typeof(ViewGroup)) {
		//		List<Android.Views.View> viewArrayList = new List<Android.Views.View>();
		//		viewArrayList.Add(v);
		//		return viewArrayList;
		//	}

		//	List<Android.Views.View> result = new List<Android.Views.View>();

		//	ViewGroup viewGroup = (ViewGroup)v;
		//	for (int i = 0; i < viewGroup.ChildCount; i++)
		//	{

		//		Android.Views.View child = viewGroup.GetChildAt(i);

		//		List<Android.Views.View> viewArrayList = new List<Android.Views.View>();
		//		viewArrayList.Add(v);
		//		viewArrayList.AddRange(getAllChildren(child));

		//		result.AddRange(viewArrayList);
		//	}
		//	return result;
		//}
#endif

		}
}