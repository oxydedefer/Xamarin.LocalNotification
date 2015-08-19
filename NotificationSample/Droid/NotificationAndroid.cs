using System;
using Android.Support.V4.App;
using Android.App;
using Android.Content;
using Android.OS;
using Xamarin.Forms;
using NotificationSample.Droid;


[assembly: Xamarin.Forms.Dependency (typeof (NotificationAndroid))]
namespace NotificationSample.Droid
{
	public class NotificationAndroid : ILocalNotificationDependency
	{
		private static readonly int notificationId = 1000;

		public NotificationAndroid (){}

		#region ILocalNotificationDependency implementation

		public void ShowLocalNotification ()
		{
			// Pass value to the next form:
			// Bundle valuesForActivity = new Bundle();
			// valuesForActivity.PutInt("count", count);

			// When the user clicks the notification, SecondActivity will start up.
			//Intent resultIntent = new Intent(this, typeof(SecondActivity));

			// Pass some values to SecondActivity:
			//resultIntent.PutExtras(valuesForActivity); 

			var ctx = Forms.Context;

			// Build the notification:
			NotificationCompat.Builder builder = new NotificationCompat.Builder(ctx)
				.SetAutoCancel(true)                    // Dismiss the notification from the notification area when the user clicks on it

				.SetContentTitle("Title Notification")      // Set the title
				.SetSmallIcon(Resource.Drawable.icon) // This is the icon to display
				.SetContentText(String.Format("Message Notification")); // the message to display.

			// Finally, publish the notification:
			NotificationManager notificationManager = (NotificationManager)ctx.GetSystemService(Context.NotificationService);
			notificationManager.Notify(notificationId, builder.Build());
		}

		#endregion
	}
}

