// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace TipCalc.iOS.Views
{
	[Register ("TipView")]
	partial class TipView
	{
		[Outlet]
		MonoTouch.UIKit.UISlider Generosity { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField SubTotal { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel Tip { get; set; }

		
		void ReleaseDesignerOutlets ()
		{
			if (SubTotal != null) {
				SubTotal.Dispose ();
				SubTotal = null;
			}

			if (Generosity != null) {
				Generosity.Dispose ();
				Generosity = null;
			}

			if (Tip != null) {
				Tip.Dispose ();
				Tip = null;
			}
		}
	}
}
