# ScrollToControl

Run the app.

If the button at the bottom is visible, reduce the height of the app window until you can't see it.

Click the button at the top.

This button sets a member variable, _scrollToElement, to contain the button at the bottom of the screen (BottomButton).

The app will then pop up another page (MyMainPage). Click the Close button to close it.

Code execution then goes back to MainPage.OnAppearing - where code does a ScrollView.ScrollToAsync to the control stored in _scrollToElement.
ScrollToPoistion is MakeVisible, but the scrollview does not scroll to that control, and the button remains off-screen.
