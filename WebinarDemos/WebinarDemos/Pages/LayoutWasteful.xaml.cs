using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using System.Linq;
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
			var result = native.ViewGroup.GetAllChildren();
			Debug.WriteLine("babies " + result.Count);
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


#if __ANDROID__
	/// <summary>
	/// View group extension.
	/// </summary>
	public static class ViewGroupExtension
	{
		/// <summary>
		/// Gets all children.
		/// </summary>
		/// <returns>The all children.</returns>
		/// <param name="viewGroup">View group.</param>
		public static IList<Android.Views.View> GetAllChildren(this ViewGroup viewGroup)
		{
			var children = new List<Android.Views.View>();

			for (var index = 0; index < viewGroup.ChildCount; index++)
			{
				var view = viewGroup.GetChildAt(index);
				if (view is ViewGroup)
				{
					children.AddRange((view as ViewGroup).GetAllChildren());
				}
				else
				{
					children.Add(view);
				}
			}

			return children;
		}

		/// <summary>
		/// Determines if is editable the specified viewGroup.
		/// </summary>
		/// <returns><c>true</c> if is editable the specified viewGroup; otherwise, <c>false</c>.</returns>
		/// <param name="viewGroup">View group.</param>
		public static bool IsEditable(this ViewGroup viewGroup)
		{
			return viewGroup.GetAllChildren().Where(v => v is Android.Widget.EditText && v.Focusable).Any();
		}
	}
#endif
}