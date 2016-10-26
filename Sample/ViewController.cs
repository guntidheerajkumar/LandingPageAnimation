using System;
using LandingPageAnimation;
using UIKit;
using System.Diagnostics;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			SKSplashIcon icon = new SKSplashIcon(UIImage.FromBundle("twitterIcon"), SKIconAnimationType.None);
			SKSplashView sView = new SKSplashView(UIImage.FromBundle("uber screen"), SKSplashAnimationType.Zoom);
			sView.AnimationDuration = 3.0f;
			sView.Delegate = new SplashDelegate();
			this.View.AddSubview(sView);
			//sView.StartAnimation();
			sView.StartAnimationWithCompletion(() => {
				Debug.WriteLine("Completed");
			});
		}
	}

	class SplashDelegate : SKSplashDelegate
	{
		public override void SplashView(SKSplashView splashView, float duration)
		{

		}

		public override void SplashViewDidEndAnimating(SKSplashView splashView)
		{

		}
	}
}
