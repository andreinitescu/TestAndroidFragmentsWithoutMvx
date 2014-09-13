package testandroidfragmentswithoutmvx;


public class SecondChildView
	extends testandroidfragmentswithoutmvx.BaseFragment
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("TestAndroidFragmentsWithoutMvx.SecondChildView, TestAndroidFragmentsWithoutMvx, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SecondChildView.class, __md_methods);
	}


	public SecondChildView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SecondChildView.class)
			mono.android.TypeManager.Activate ("TestAndroidFragmentsWithoutMvx.SecondChildView, TestAndroidFragmentsWithoutMvx, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
