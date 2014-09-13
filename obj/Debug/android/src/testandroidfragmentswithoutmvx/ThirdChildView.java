package testandroidfragmentswithoutmvx;


public class ThirdChildView
	extends testandroidfragmentswithoutmvx.BaseFragment
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("TestAndroidFragmentsWithoutMvx.ThirdChildView, TestAndroidFragmentsWithoutMvx, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ThirdChildView.class, __md_methods);
	}


	public ThirdChildView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ThirdChildView.class)
			mono.android.TypeManager.Activate ("TestAndroidFragmentsWithoutMvx.ThirdChildView, TestAndroidFragmentsWithoutMvx, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
