using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using WebinarDemos.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace WebinarDemos
{
	public partial class App : Application
	{
		public static string AppName = "WebinarDemo";

		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new WebinarDemos.MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
			RegisterAppLinks();
		}

		void RegisterAppLinks()
		{
			Application.Current.AppLinks.RegisterLink(MakeAppLink("Picker", "Demonstrates a basic Picker", 0));
			Application.Current.AppLinks.RegisterLink(MakeAppLink("Picker with Effect", "Demonstrates customizing a Picker with a Platform Effect", 1));
			Application.Current.AppLinks.RegisterLink(MakeAppLink("Picker with Renderer", "Demonstrates customizing a Picker with a Custom Renderer", 2));
			Application.Current.AppLinks.RegisterLink(MakeAppLink("Animation Extensions", "Demonstrates animating views with extension methods", 3));
			Application.Current.AppLinks.RegisterLink(MakeAppLink("Compound Animations", "Demonstrates compound animations", 4));
			Application.Current.AppLinks.RegisterLink(MakeAppLink("Layout Wasteful", "Demonstrates a wasteful Layout", 5));
			Application.Current.AppLinks.RegisterLink(MakeAppLink("Layout Optimized", "Demonstrates an optimized Layout", 6));
			Application.Current.AppLinks.RegisterLink(MakeAppLink("ListView", "Demonstrates a basic ListView", 7));
			Application.Current.AppLinks.RegisterLink(MakeAppLink("ListView Optimized", "Demonstrates an optimized ListView", 8));
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

		protected override async void OnAppLinkRequestReceived(Uri uri)
		{
			string appDomain = "http://" + App.AppName.ToLowerInvariant() + "/";
			if (!uri.ToString().ToLowerInvariant().StartsWith(appDomain))
			{
				return;
			}

			string pageUrl = uri.ToString().Replace(appDomain, string.Empty).Trim();
			var parts = pageUrl.Split('?');
			string page = parts[0];
			int pageParameter = Int16.Parse(parts[1].Replace("id=", string.Empty));

			switch (pageParameter)
			{
				case 0:
					await MainPage.Navigation.PushAsync(new PickerStandard());
					break;
				case 1:
					await MainPage.Navigation.PushAsync(new PickerEffect());
					break;
				case 2:
					await MainPage.Navigation.PushAsync(new PickerCustom());
					break;
				case 3:
					await MainPage.Navigation.PushAsync(new AnimationExtensionsPage());
					break;
				case 4:
					await MainPage.Navigation.PushAsync(new CompoundAnimationPage());
					break;
				case 5:
					await MainPage.Navigation.PushAsync(new LayoutWasteful());
					break;
				case 6:
					await MainPage.Navigation.PushAsync(new LayoutOptimized());
					break;
				case 7:
					await MainPage.Navigation.PushAsync(new ListViewPage());
					break;
				case 8:
					await MainPage.Navigation.PushAsync(new ListViewOptimizedPage());
					break;
			}

			base.OnAppLinkRequestReceived(uri);
	  	}

		AppLinkEntry MakeAppLink(string title, string description, int id)
		{
			var pageType = GetType().ToString();
			var pageLink = new AppLinkEntry
			{
						Title = title,
						Description = description,
						AppLinkUri = new Uri(string.Format("http://{0}/{1}?id={2}", App.AppName, pageType, id), UriKind.RelativeOrAbsolute),
				IsLinkActive = true,
				Thumbnail = ImageSource.FromFile("Xamagon.png")
			};

			pageLink.KeyValues.Add("contentType", "ContentPage");
			pageLink.KeyValues.Add("appName", App.AppName);
			pageLink.KeyValues.Add("companyName", "Xamarin");

			return pageLink;
		}
	}
}
