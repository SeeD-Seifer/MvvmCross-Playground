using System;
using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

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

