using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NotificationSample
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
			myButton.Clicked += delegate(object sender, EventArgs e) {
				DependencyService.Get<ILocalNotificationDependency>().ShowLocalNotification();
			};
		}
	}
}

