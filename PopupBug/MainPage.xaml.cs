namespace PopupBug;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Window window = new(new SecondaryWindow());

		Application.Current.OpenWindow(window);
	}
}


