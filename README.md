# ScrollToControl

Run the app.

You will see a button (ButtonTop) at the top of the screen with a caption "Jump to Bottom"
Lots of labels filling up the rest of the screen,
and if you scroll down, you'll see another button called BottomButton with text "Jump to Top".

If you examine the code, you'll see that in OnAppearing, when it runs for the first time,
it should scroll to BottomButton, ensuring it is visible. That code executes, but
does not seem to have any effect on the display.
