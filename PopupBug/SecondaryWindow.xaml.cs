using CommunityToolkit.Maui.Views;

namespace PopupBug;

public partial class SecondaryWindow : ContentPage
{
	public SecondaryWindow()
	{
		InitializeComponent();
	}

    void btnPopup_Clicked(System.Object sender, System.EventArgs e)
    {
        var popup = new PopupContent();
        this.ShowPopup(popup);
    }

    async void btnPopupAsync_Clicked(System.Object sender, System.EventArgs e)
    {
        var popup = new PopupContent();
        await this.ShowPopupAsync(popup);
    }
}
