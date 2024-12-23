namespace ScrollToControl
{
	public partial class MainPage : ContentPage
	{

		private bool _firstTime = true;

		public MainPage()
		{
			InitializeComponent();
		}

		private async void TopButton_Clicked(object sender, EventArgs e)
		{
			await MyScrollView.ScrollToAsync(BottomButton, ScrollToPosition.MakeVisible, true);
		}

		private async void BottomButton_Clicked(object sender, EventArgs e)
		{
			await MyScrollView.ScrollToAsync(TopButton, ScrollToPosition.MakeVisible, true);
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			if (_firstTime)
			{
					await MyScrollView.ScrollToAsync(BottomButton, ScrollToPosition.MakeVisible, true);
				_firstTime = false;
			}

		}

	}

}