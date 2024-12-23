namespace ScrollToControl;

public partial class MyPage : ContentPage
{
	public MyPage()
	{
		InitializeComponent();
	}

	private async void CloseButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopModalAsync();
	}
}