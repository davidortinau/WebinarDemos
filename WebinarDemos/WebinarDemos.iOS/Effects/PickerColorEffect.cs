using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using WebinarDemos.Effects.iOS;

[assembly: ResolutionGroupName("WebinarDemos.Effects")]
[assembly: ExportEffect(typeof(PickerChangeColorEffect), nameof(PickerChangeColorEffect))]
namespace WebinarDemos.Effects.iOS
{
	public class PickerChangeColorEffect : PlatformEffect
	{
		private Color _color;

		protected override void OnAttached()
		{
			System.Diagnostics.Debug.WriteLine("attached");
		}

		protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
		{
			base.OnElementPropertyChanged(args);
			UpdateColor();
		}

		void UpdateColor()
		{
			var newColor = (Color)Element.GetValue(RoutingEffects.PickerColorEffect.ColorProperty);
			if (newColor == _color)
				return;

			_color = newColor;
			(Control as UITextField).AttributedPlaceholder = new Foundation.NSAttributedString((Control as UITextField).AttributedPlaceholder.Value, foregroundColor: _color.ToUIColor());
			(Control as UITextField).TextColor = _color.ToUIColor();
		}

		protected override void OnDetached()
		{
		}
	}
}
