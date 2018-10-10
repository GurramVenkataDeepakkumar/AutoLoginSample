using Plugin.AutoLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutoLoginSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnLoginClicked(object sender, EventArgs e)
        {
            if (!CrossAutoLogin.Current.UserIsSaved)
            {
                CrossAutoLogin.Current.SaveUserInfos(UserNameOrEmailEntry.Text, PasswordEntry.Text);

                Navigation.PushAsync(new Page1());
            }
        }
    }
}
