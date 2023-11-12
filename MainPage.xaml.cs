using System;

namespace MauiActionLabel;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnUrlClicked(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://www.androidmads.info/search/label/.net%20maui");
    }
}

