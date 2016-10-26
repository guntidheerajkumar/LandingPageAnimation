using System;
using ObjCRuntime;

namespace LandingPageAnimation
{
	public enum SKSplashAnimationType : int
	{
		Fade = 0,
		Bounce,
		Shrink,
		Zoom,
		None,
		Custom
	}

	public enum SKIconAnimationType : int
	{
		Bounce,
		Grow,
		Shrink,
		Fade,
		Ping,
		Blink,
		None,
		Custom
	}
}
