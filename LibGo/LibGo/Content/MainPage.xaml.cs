using System;
using Xamarin.Forms;

namespace LibGo
{
    public partial class MainPage : ContentPage
    {
        public bool isFirstTimeLoaded;
        public MainPage()
        {
            InitializeComponent();

            if (Device.OS == TargetPlatform.iOS)
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
        }

        private void webView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            if (e.Result == WebNavigationResult.Success)
            {
                LoadingGif.IsRunning = false;
                LoadingGif.IsVisible = false;
                NoInternet.IsVisible = false;
                webBrowser.IsVisible = true;
            }
            else if(!isFirstTimeLoaded)
            {
                LoadingGif.IsRunning = false;
                LoadingGif.IsVisible = false;
                webBrowser.IsVisible = false;
                NoInternet.IsVisible = true;
            }
            isFirstTimeLoaded = true;
        }

        private void WebBrowser_OnNavigating(object sender, WebNavigatingEventArgs e)
        {
            if (!e.Url.Contains("54.169.27.64") && !e.Url.Contains("youtube.com/embed"))
            {
                try
                {
                    var uri = new Uri(e.Url);
                    Device.OpenUri(uri);
                }
                catch (Exception)
                { }

                e.Cancel = true;
            }

        }
    }
}
