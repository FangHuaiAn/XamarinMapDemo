// WARNING
//
// This file has been generated automatically by Xamarin Studio Community to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace XamarinMapDemo.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton Button { get; set; }

		[Outlet]
		MapKit.MKMapView myMapView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (myMapView != null) {
				myMapView.Dispose ();
				myMapView = null;
			}

			if (Button != null) {
				Button.Dispose ();
				Button = null;
			}
		}
	}
}
