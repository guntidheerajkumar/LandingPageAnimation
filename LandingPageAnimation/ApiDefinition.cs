using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace LandingPageAnimation
{
	// @protocol SKSplashDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface SKSplashDelegate
	{
		// @optional -(void)splashView:(SKSplashView *)splashView didBeginAnimatingWithDuration:(float)duration;
		[Export("splashView:didBeginAnimatingWithDuration:")]
		void SplashView(SKSplashView splashView, float duration);

		// @optional -(void)splashViewDidEndAnimating:(SKSplashView *)splashView;
		[Export("splashViewDidEndAnimating:")]
		void SplashViewDidEndAnimating(SKSplashView splashView);
	}

	// @interface SKSplashView : UIView
	[BaseType(typeof(UIView))]
	interface SKSplashView
	{
		// @property (nonatomic, strong) UIColor * backgroundViewColor;
		[Export("backgroundViewColor", ArgumentSemantic.Strong)]
		UIColor BackgroundViewColor { get; set; }

		// @property (nonatomic, strong) UIImage * backgroundImage;
		[Export("backgroundImage", ArgumentSemantic.Strong)]
		UIImage BackgroundImage { get; set; }

		// @property (assign, nonatomic) CGFloat animationDuration;
		[Export("animationDuration")]
		nfloat AnimationDuration { get; set; }

		[Wrap("WeakDelegate")]
		SKSplashDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<SKSplashDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype)initWithAnimationType:(SKSplashAnimationType)animationType;
		[Export("initWithAnimationType:")]
		IntPtr Constructor(SKSplashAnimationType animationType);

		// -(instancetype)initWithBackgroundColor:(UIColor *)backgroundColor animationType:(SKSplashAnimationType)animationType;
		[Export("initWithBackgroundColor:animationType:")]
		IntPtr Constructor(UIColor backgroundColor, SKSplashAnimationType animationType);

		// -(instancetype)initWithBackgroundImage:(UIImage *)backgroundImage animationType:(SKSplashAnimationType)animationType;
		[Export("initWithBackgroundImage:animationType:")]
		IntPtr Constructor(UIImage backgroundImage, SKSplashAnimationType animationType);

		// -(instancetype)initWithSplashIcon:(SKSplashIcon *)icon animationType:(SKSplashAnimationType)animationType;
		[Export("initWithSplashIcon:animationType:")]
		IntPtr Constructor(SKSplashIcon icon, SKSplashAnimationType animationType);

		// -(instancetype)initWithSplashIcon:(SKSplashIcon *)icon backgroundColor:(UIColor *)backgroundColor animationType:(SKSplashAnimationType)animationType;
		[Export("initWithSplashIcon:backgroundColor:animationType:")]
		IntPtr Constructor(SKSplashIcon icon, UIColor backgroundColor, SKSplashAnimationType animationType);

		// -(instancetype)initWithSplashIcon:(SKSplashIcon *)icon backgroundImage:(UIImage *)backgroundImage animationType:(SKSplashAnimationType)animationType;
		[Export("initWithSplashIcon:backgroundImage:animationType:")]
		IntPtr Constructor(SKSplashIcon icon, UIImage backgroundImage, SKSplashAnimationType animationType);

		// -(void)setCustomAnimationType:(CAAnimation *)animation;
		[Export("setCustomAnimationType:")]
		void SetCustomAnimationType(CAAnimation animation);

		// -(void)startAnimation;
		[Export("startAnimation")]
		void StartAnimation();

		// -(void)startAnimationWithCompletion:(void (^)())completionHandler;
		[Export("startAnimationWithCompletion:")]
		void StartAnimationWithCompletion(Action completionHandler);

		//// -(void)startAnimationWhileExecuting:(NSURLRequest *)request withCompletion:(void (^)(NSData *, NSURLResponse *, NSError *))completion;
		//[Export("startAnimationWhileExecuting:withCompletion:")]
		//void StartAnimationWhileExecuting(NSUrlRequest request, Action<NSData, NSURLResponse, NSError> completion);
	}

	// @interface SKSplashIcon : UIImageView
	[BaseType(typeof(UIImageView))]
	interface SKSplashIcon
	{
		// @property (nonatomic, strong) UIColor * iconColor;
		[Export("iconColor", ArgumentSemantic.Strong)]
		UIColor IconColor { get; set; }

		// @property (assign, nonatomic) CGSize iconSize;
		[Export("iconSize", ArgumentSemantic.Assign)]
		CGSize IconSize { get; set; }

		// -(instancetype)initWithImage:(UIImage *)iconImage;
		[Export("initWithImage:")]
		IntPtr Constructor(UIImage iconImage);

		// -(instancetype)initWithImage:(UIImage *)iconImage animationType:(SKIconAnimationType)animationType;
		[Export("initWithImage:animationType:")]
		IntPtr Constructor(UIImage iconImage, SKIconAnimationType animationType);

		// -(void)setIconAnimationType:(SKIconAnimationType)animationType;
		[Export("setIconAnimationType:")]
		void SetIconAnimationType(SKIconAnimationType animationType);

		// -(void)setCustomAnimation:(CAAnimation *)animation;
		[Export("setCustomAnimation:")]
		void SetCustomAnimation(CAAnimation animation);
	}
}
