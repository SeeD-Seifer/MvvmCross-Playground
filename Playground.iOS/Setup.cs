using System;
using UIKit;
using MvvmCross.iOS.Platform;
using MvvmCross.Core.ViewModels;

namespace Playground.iOS
{
	public class Setup : MvxIosSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
			: base(applicationDelegate, window)
		{
		}

		protected override IMvxApplication CreateApp ()
		{
			return new App();
		}
	}
}

