using System;
using Android.Views;
using Android.OS;
using Android.App;

namespace TestAndroidFragmentsWithoutMvx
{
	public class SecondChildView : BaseFragment
	{
		protected override int LayoutId { get { return Resource.Layout.SecondChildView; } }
		protected override Func<Fragment> NextViewType { get { return ()=> new ThirdChildView(); } }
	}
}	

