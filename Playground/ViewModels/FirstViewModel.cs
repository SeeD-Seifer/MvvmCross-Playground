using System;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Plugins.Location;
using System.Diagnostics;
using Cirrious.CrossCore.Core;

namespace Playground.ViewModels
{
	public class FirstViewModel: MvxViewModel
	{
		// Permission and Location properties should be converted with ValueConverters
		// instead of being strings

		#region NotifyProperty Permission

		private string _Permission;

		public string Permission {
			get { return _Permission; }
			set {
				_Permission = value;
				RaisePropertyChanged (() => this.Permission);
			}
		}

		#endregion

		#region NotifyProperty Location

		private string _Location;

		public string Location {
			get { return _Location; }
			set {
				_Location = value;
				RaisePropertyChanged (() => this.Location);
			}
		}

		#endregion

		private readonly IMvxLocationWatcher locationWatcher;

		public FirstViewModel (IMvxLocationWatcher locationWatcher)
		{
			this.locationWatcher = locationWatcher;

			Permission = "not specified";
			Location = "zero";

			locationWatcher.OnPermissionChanged += OnPermissionChanged;
			locationWatcher.Start (new MvxLocationOptions (), OnLocationUpdated, OnLocationError);
		}

		private void OnPermissionChanged (object sender, MvxValueEventArgs<MvxLocationPermission> args)
		{
			Permission = args.Value.ToString ();
		}

		private void OnLocationUpdated (MvxGeoLocation location)
		{
			Location = string.Format ("({0:##.#}, {1:##.#})", location.Coordinates.Latitude, location.Coordinates.Longitude);
		}

		private void OnLocationError (MvxLocationError error)
		{
			Debug.WriteLine ("Location error: " + error.Code);
		}
	}
}

