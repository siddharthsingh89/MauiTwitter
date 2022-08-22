namespace MauiTwitter;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        FlyoutIcon = new UriImageSource()
        {
            Uri = new Uri("https://pbs.twimg.com/profile_images/645601415973355521/No1ZTxyn_400x400.jpg")
        };
    }
}
