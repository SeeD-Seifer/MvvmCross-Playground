using System;
using UIKit;
using CoreGraphics;
using Playground.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;

namespace Playground.iOS.Views
{
	public class FirstView: MvxViewController<FirstViewModel>
	{
		private UILabel permission;
		private UILabel location;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			permission = new UILabel (new CGRect (20, 80, 200, 20)) {
				TextColor = UIColor.Black,
			};
			location = new UILabel (new CGRect (20, 110, 200, 20)) {
				TextColor = UIColor.Black,
			};

			View.AddSubviews (permission, location);
			View.BackgroundColor = UIColor.White;

			var set = this.CreateBindingSet<FirstView, FirstViewModel> ();
			set.Bind (permission).To (vm => vm.Permission);
			set.Bind (location).To (vm => vm.Location);
			set.Apply ();
		}
	}
}

