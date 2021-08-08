using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace App1.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            CameraButton.Clicked += CameraButton_Clicked;
        }

        private async void CameraButton_Clicked( object sender, EventArgs e )
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync( new Plugin.Media.Abstractions.StoreCameraMediaOptions() { } );

            if( photo != null )
                PhotoImage.Source = ImageSource.FromStream( () => { return photo.GetStream(); } );
        }

        private void ScanView_OnScanResult(Result result)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await DisplayAlert("Scanned result",
                    "The barcode's text is " + result.Text + ". The barcode's format is " + result.BarcodeFormat, "OK");
            });
        }
    }
}