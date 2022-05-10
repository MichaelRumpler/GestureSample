## Overview
{: #Overview }

.NET MAUI or Xamarin.Forms are great if you want to develop apps for different platforms. But when it comes to touch gestures, they are still very limited.  
For the first year Xamarin.Forms only had the `TapGestureRecognizer`. Although they did add some others later, they still don't provide all information you need.
Furthermore the API which they use has been copied from iOS and is not what a .NET developer would expect.

.NET MAUI tries to position itself to be not only for mobile platforms, but also for Windows and macOS desktop.
For the desktop you also need to know where the mouse pointer is - but they don't have any mouse gesture support.

MR.Gestures tries to close that gap.

It adds `Down`, `Up`, `Tapping`, `Tapped`, `DoubleTapped`, `LongPressing`, `LongPressed`, `Panning`, `Panned`, `Swiped`, `Pinching`, `Pinched`, `Rotating`, `Rotated`, `MouseEntered`, `MouseMoved`, `MouseExited` and `ScrollWheelChanged` events to each and every layout, cell and view and to the `ContentPage`. These events will be raised when the user performs the corresponding gesture on the element.

In the [EventArgs](#Events) passed to the handlers you can see exactly what happened.

You can work with the gestures completely from the shared project. The platform specific code is all done in MR.Gestures.
