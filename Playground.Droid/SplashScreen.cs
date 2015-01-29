using System;
using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Droid.Views;

namespace Playground.Droid
{
	[Activity(
		Label = "Playground"
		, MainLauncher = true
		, Icon = "@drawable/icon"
		, NoHistory = true
		, ScreenOrientation = ScreenOrientation.Portrait)]
	public class SplashScreen : MvxSplashScreenActivity
	{
		public SplashScreen()
			: base(Resource.Layout.SplashScreen)
		{
		}
	}
}

