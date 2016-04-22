// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BoomXamarin
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnAwesome { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnReset { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imageBackground { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imageTitle { get; set; }

		[Action ("BtnReset_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BtnReset_TouchUpInside (UIButton sender);

		[Action ("UIButton5_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton5_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnAwesome != null) {
				btnAwesome.Dispose ();
				btnAwesome = null;
			}
			if (btnReset != null) {
				btnReset.Dispose ();
				btnReset = null;
			}
			if (imageBackground != null) {
				imageBackground.Dispose ();
				imageBackground = null;
			}
			if (imageTitle != null) {
				imageTitle.Dispose ();
				imageTitle = null;
			}
		}
	}
}
