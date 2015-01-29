using System;
using Cirrious.MvvmCross.Droid.Platform;
using Android.Content;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore.IoC;

namespace Playground.Droid
{
	public class Setup : MvxAndroidSetup
	{
		public Setup(Context applicationContext) : base(applicationContext)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();

			return new App();
		}
	}
}

