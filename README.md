TestAndroidFragmentsWithoutMvx
==============================

why when hitting back key in an activity with a fragment which was not added to the back stack (AddToBackStack not called), the fragment is not being removed from layout ?

    public void ShowFragment(Fragment fragment) 
	{
		// add fragment to activity
		var ft = this.FragmentManager.BeginTransaction ().Replace (Resource.Id.content_frame, fragment);
		
		if (!(fragment is ThirdChildView)) {
			ft = ft.AddToBackStack (null);
		}

		ft.Commit ();
	}
	
if I hit the back key when ThirdChildView is displayed, it remains visible in the layout
