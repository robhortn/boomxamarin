using System;

using UIKit;

namespace BoomXamarin
{
	public partial class ViewController : UIViewController
	{ 
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		
			// Initial control setup.
			SetupControls();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		void SetupControls(){
			imageTitle.Hidden = true;
			imageBackground.Hidden = true;
			btnReset.Hidden = true;
			btnAwesome.Hidden = false;
		}

		partial void UIButton5_TouchUpInside (UIButton sender)
		{
			imageTitle.Hidden = false;
			imageBackground.Hidden = false;
			btnAwesome.Hidden = true;
			btnReset.Hidden = false;
		}

		partial void BtnReset_TouchUpInside (UIButton sender)
		{
			btnAwesome.Hidden = false;

			btnReset.Hidden = true;
			imageTitle.Hidden = true;
			imageBackground.Hidden = true;
		}
	}
}

