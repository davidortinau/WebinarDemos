using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebinarDemos
{
	[XamlCompilation(XamlCompilationOptions.Skip)]
	public partial class XamlPage : ContentPage
	{
		public XamlPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			var tr = new TapGestureRecognizer();
			tr.Command = new Command(async (obj) =>
			{
				await Navigation.PushModalAsync(new NavigationPage(new ViewSourcePage { SourcePageType = typeof(XamlPage) }));
			});

			label.GestureRecognizers.Add(tr);
		}
	}
}