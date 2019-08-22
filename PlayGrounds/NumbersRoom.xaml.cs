using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlayGrounds
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NumbersRoom : PopupPage
    {
        public NumbersRoom()
        {
            InitializeComponent();
        }

        private void BtnPause_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnPlay_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnStop_Clicked(object sender, EventArgs e)
        {

        }

        private void PlayMusic(object sender, EventArgs e)
        {
            var _btn = (Behavior)sender;
        }
    }
}