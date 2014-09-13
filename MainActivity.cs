using System;

using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.App;

namespace TestAndroidFragmentsWithoutMvx
{
	[Activity (Label = "TestAndroidFragmentsWithoutMvx", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// show first fragment
			this.ShowFragment(new FirstChildView());
		}

		public void ShowFragment(Fragment fragment) 
		{
			// add fragment to activity
			var ft = this.FragmentManager.BeginTransaction ()
				.Replace (Resource.Id.content_frame, fragment);

			if (!(fragment is ThirdChildView)) {
				ft = ft.AddToBackStack (null);
			}

			ft.Commit ();
		}
	}
}


