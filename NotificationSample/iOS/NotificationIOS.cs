using System;
using NotificationSample.iOS;
using UIKit;
using Foundation;

[assembly: Xamarin.Forms.Dependency (typeof (NotificationIOS))]
namespace NotificationSample.iOS
{
	public class NotificationIOS : ILocalNotificationDependency
	{
		public NotificationIOS ()
		{
		}

		#region ILocalNotificationDependency implementation

		public void ShowLocalNotification ()
		{
			// create the notification
			var notification = new UILocalNotification ();

			// configure the alert
			notification.AlertAction = "Alert Action";
			notification.AlertBody = "Notification message here !";

			// modify the badge
			notification.ApplicationIconBadgeNumber = 1;

			// set the sound to be the default sound
			notification.SoundName = UILocalNotification.DefaultSoundName;

			// schedule it
			UIApplication.SharedApplication.ScheduleLocalNotification (notification);
		}

		#endregion
	}
}

