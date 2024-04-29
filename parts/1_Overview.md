## Overview
{: #Overview }

Xamarin.Forms did not handle touch gestures very well. They only had the `TapGestureRecognizer` in the beginning. This is not enough to write advanced mobile apps. .NET MAUI added some more gesture recognizers but they still don't provide all information you need.
Furthermore the API which they use (the `GestureRecognizers` collection) has been copied from iOS and is not what a .NET developer would expect.

MR.Gestures tries to close that gap.

It adds `Down`, `Up`, `Tapping`, `Tapped`, `DoubleTapped`, `LongPressing`, `LongPressed`, `Panning`, `Panned`, `Swiped`, `Pinching`, `Pinched`, `Rotating`, `Rotated`, `MouseEntered`, `MouseMoved`, `MouseExited` and `ScrollWheelChanged` events to each and every layout, cell and view and to the `ContentPage`. These events will be raised when the user performs the corresponding gesture on the element.

In the [EventArgs](#Events) passed to the handlers you get all the information you need about the gesture.

You can work with the gestures completely from shared code. The platform specific code is all done in MR.Gestures.
