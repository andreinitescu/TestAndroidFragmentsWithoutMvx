using System;
using Android.Views;
using Android.OS;
using Android.App;

namespace TestAndroidFragmentsWithoutMvx
{
	public class ThirdChildView : BaseFragment
	{
		protected override int LayoutId { get { return Resource.Layout.ThirdChildView; } }
		protected override Func<Fragment> NextViewType { get { return ()=> new FirstChildView(); } }
	}
}

