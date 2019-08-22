using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlayGrounds
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public Plugin.SimpleAudioPlayer.ISimpleAudioPlayer simpleAudioPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Number_Clicked(object sender, EventArgs e)
        {
            simpleAudioPlayer.Stop();
            await PopupNavigation.Instance.PushAsync(new NumbersRoom());
        }

        private void MyChest_Clicked(object sender, EventArgs e)
        {
            //  await Navigation.PushModalAsync(new SongsPlayer());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //var asssembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            // var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            //var assembly = typeof(App).GetTypeInfo().Assembly;
            var audioStream = assembly.GetManifestResourceStream("PlayGrounds.songs.mp3");

            // var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            simpleAudioPlayer.Load(audioStream);


            //player.Load("songs.mp3");
            simpleAudioPlayer.Play();
        }

        private void BtnPlay_Clicked(object sender, EventArgs e)
        {
            simpleAudioPlayer.Play();
        }

        private void BtnPause_Clicked(object sender, EventArgs e)
        {
            simpleAudioPlayer.Pause();
        }

        private void BtnStop_Clicked(object sender, EventArgs e)
        {
            simpleAudioPlayer.Stop();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            simpleAudioPlayer.Stop();
        }

        private async void Btn_Songs_OnClick(object sender, EventArgs e)
        {
            simpleAudioPlayer.Stop();
            await PopupNavigation.Instance.PushAsync(new SongsPlayer());
        }
    }
}
