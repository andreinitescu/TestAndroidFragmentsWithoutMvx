using System;
using Android.Views;
using Android.OS;
using Android.App;

namespace TestAndroidFragmentsWithoutMvx
{
	public class FirstChildView : BaseFragment
	{
		protected override int LayoutId { get { return Resource.Layout.FirstChildView; } }
		protected override Func<Fragment> NextViewType { get { return ()=> new SecondChildView(); } }
	}
}

