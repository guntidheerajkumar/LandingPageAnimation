# LandingPageAnimation

This is a Obj-C Binding Project based on https://github.com/sachinkesiraju/SKSplashView

```
SKSplashView sView = new SKSplashView(UIImage.FromBundle("uber screen"), SKSplashAnimationType.Zoom);
sView.AnimationDuration = 3.0f;
sView.Delegate = new SplashDelegate();
this.View.AddSubview(sView);
sView.StartAnimationWithCompletion(() => {
	Debug.WriteLine("Completed");
});
```
