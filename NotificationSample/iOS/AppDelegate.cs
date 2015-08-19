using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace NotificationSample.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{

			if (UIDevice.CurrentDevice.CheckSystemVersion (8, 0)) {
				var notificationSettings = UIUserNotificationSettings.GetSettingsForTypes (
					UIUserNotificationType.Alert | UIUserNotificationType.Badge | UIUserNotificationType.Sound, null
				);

				app.RegisterUserNotificationSettings (notificationSettings);
			} 

			global::Xamarin.Forms.Forms.Init ();

			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}


		/*public override void ReceivedLocalNotification(UIApplication application, UILocalNotification notification)
		{
			var window= UIApplication.SharedApplication.KeyWindow;
			var vc = window.RootViewController;
			while (vc.PresentedViewController != null)
			{
				vc = vc.PresentedViewController;
			}
			UIViewController *rootViewController = window.RootViewController;
			// show an alert
			UIAlertController okayAlertController = UIAlertController.Create (notification.AlertAction, notification.AlertBody, UIAlertControllerStyle.Alert);
			okayAlertController.AddAction (UIAlertAction.Create ("OK", UIAlertActionStyle.Default, null));
			rootViewController.PresentViewController (okayAlertController, true, null);

			// reset our badge
			UIApplication.SharedApplication.ApplicationIconBadgeNumber = 0;
		}*/
	}
}

