using System;
using Cirrious.MvvmCross.Touch.Platform;
using UIKit;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Touch.Views.Presenters;

namespace Playground.iOS
{
	public class Setup : MvxTouchSetup
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

