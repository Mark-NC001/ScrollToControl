namespace ScrollToControl
{
	public partial class MainPage : ContentPage
	{

		private Element _scrollToElement = null;

		public MainPage()
		{
			InitializeComponent();
		}

		private async void TopButton_Clicked(object sender, EventArgs e)
		{
			_scrollToElement = BottomButton;
			await Navigation.PushModalAsync(new NavigationPage(new MyPage()));
		}

		private async void BottomButton_Clicked(object sender, EventArgs e)
		{

			_scrollToElement = TopButton;
			await Navigation.PushModalAsync(new NavigationPage(new MyPage()));
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			if (_scrollToElement != null)
			{
				{
					await MyScrollView.ScrollToAsync(_scrollToElement, ScrollToPosition.MakeVisible, true);
					_scrollToElement = null;
				}
			}

		}

	}

}