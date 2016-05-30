using System;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Collections.Generic;

using UIKit;
using MapKit;
using Foundation;
using CoreGraphics;
using CoreLocation;

using Debug = System.Diagnostics.Debug ;

namespace XamarinMapDemo.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;

		public ViewController (IntPtr handle) : base (handle)
		{		
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var mapCenter = new CLLocationCoordinate2D (
				23.9737437408,120.981806398);
			myMapView.CenterCoordinate = mapCenter;


			var mapRegion = MKCoordinateRegion.FromDistance (mapCenter, 4000, 4000);
			myMapView.Region = mapRegion;

			myMapView.ShowsUserLocation = true;

		}

		public override void DidReceiveMemoryWarning ()
		{		
			base.DidReceiveMemoryWarning ();		
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
