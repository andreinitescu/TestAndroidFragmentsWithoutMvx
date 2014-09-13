using System;
using Android.Views;
using Android.OS;
using Android.Widget;
using Android.App;

namespace TestAndroidFragmentsWithoutMvx
{
	public abstract class BaseFragment : Fragment
	{
		protected abstract int LayoutId { get; }
		protected abstract Func<Fragment> NextViewType { get; }

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			return inflater.Inflate(this.LayoutId, container, false);
		}

		public override void OnViewCreated (View view, Bundle savedInstanceState)
		{
			base.OnViewCreated (view, savedInstanceState);

			var button = this.View.FindViewById<Button> (Resource.Id.myButton);
			button.Click += delegate {
				((MainActivity)this.Activity).ShowFragment(this.NextViewType());
			};
		}
		/*
		public override void OnCreate (Bundle savedInstanceState)
		{
			Console.WriteLine ("OnCreate fragment {0}", this.GetType ());
			base.OnCreate (savedInstanceState);
		}

		public override void OnPause ()
		{
			Console.WriteLine ("OnPause fragment {0}", this.GetType ());
			base.OnDestroy ();
		}

		public override void OnDestroy ()
		{
			Console.WriteLine ("OnDestroy fragment {0}", this.GetType ());
			base.OnDestroy ();
		}

		public override void OnDetach ()
		{
			Console.WriteLine ("OnDetach fragment {0}", this.GetType ());
			base.OnDetach ();
		}

		public override void OnDestroyView ()
		{
			Console.WriteLine ("OnDestroyView fragment {0}", this.GetType ());
			base.OnDestroyView ();
		}*/
	}
}

