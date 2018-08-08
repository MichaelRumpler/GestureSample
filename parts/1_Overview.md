## Overview
{: #Overview }

Xamarin Forms is great if you want to develop apps for different mobile platforms. But when it comes to touch gestures, it is still very limited.  
For more than a year they only had the TapGestureRecognizer. Although they did add some others lately, they still don't provide all information which you need. Furthermore the API which they use has been copied from iOS and is not what a .NET developer would expect.

MR.Gestures tries to close that gap.

It adds `Down`, `Up`, `Tapping`, `Tapped`, `DoubleTapped`, `LongPressing`, `LongPressed`, `Panning`, `Panned`, `Swiped`, `Pinching`, `Pinched`, `Rotating` and `Rotated` events to each and every layout, cell and view and to the `ContentPage`. These events will be raised when the user performs the corresponding touch gesture on the element.

In the `EventArgs` passed to the handlers you can see exactly what happened.

You can work with the touch gestures completely from the .NET Standard / PCL project. The platform specific code is all done in MR.Gestures.
