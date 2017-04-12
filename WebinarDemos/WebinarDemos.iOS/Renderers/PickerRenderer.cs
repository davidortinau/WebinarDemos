using System;
using UIKit;
using WebinarDemos;
using WebinarDemos.iOS;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(PickerRenderer))]
namespace WebinarDemos.iOS
{
	public class PickerRenderer : Xamarin.Forms.Platform.iOS.PickerRenderer
	{
		protected override void OnElementChanged(Xamarin.Forms.Platform.iOS.ElementChangedEventArgs<Picker> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				var bar = (UIToolbar)Control.InputAccessoryView;
				bar.BarTintColor = UIColor.Black;
				bar.Items[1].SetTitleTextAttributes(new UITextAttributes { TextColor = UIColor.White }, UIControlState.Normal);
			}
		}

		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
		}
	}
}
