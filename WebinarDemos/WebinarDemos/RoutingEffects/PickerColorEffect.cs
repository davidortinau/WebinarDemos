using System;
using System.Linq;
using Xamarin.Forms;

namespace WebinarDemos.RoutingEffects
{
	public static class PickerColorEffect
	{
		public static readonly BindableProperty ColorProperty = BindableProperty.CreateAttached("Color", typeof(Color?), typeof(PickerColorEffect), Color.Transparent, propertyChanged: OnColorChanged);

		private static void OnColorChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var control = bindable as Picker;
			if (control == null)
				return;

			var color = (Color)newValue;

			var attachedEffect = control.Effects.FirstOrDefault(e => e is PickerChangeColorEffect);
			if (color != Color.Transparent && attachedEffect == null)
			{
				control.Effects.Add(new PickerChangeColorEffect());
			}
			else if (color == Color.Transparent && attachedEffect != null)
			{
				control.Effects.Remove(attachedEffect);
			}
		}

		public static Color GetColor(BindableObject view)
		{
			return (Color)view.GetValue(ColorProperty);
		}

		public static void SetColor(BindableObject view, string color)
		{
			view.SetValue(ColorProperty, color);
		}

	}

	public class PickerChangeColorEffect : RoutingEffect
	{
		public PickerChangeColorEffect() : base("WebinarDemos.Effects.PickerChangeColorEffect")
		{
		} 
	}
}
