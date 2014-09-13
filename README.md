TestAndroidFragmentsWithoutMvx
==============================

It's a small sample with an activity showing 3 fragments, each fragment has a button on which we call display of next fragment.

For the 3rd fragment (ThirdChildView), it's not added to backstack. 

If you now hit back key, it remains visible.

Why is that?


    public void ShowFragment(Fragment fragment) 
	{
		// add fragment to activity
		var ft = this.FragmentManager.BeginTransaction ().Replace (Resource.Id.content_frame, fragment);
		
		if (!(fragment is ThirdChildView)) {
			ft = ft.AddToBackStack (null); 
		}

		ft.Commit ();
	}
	

