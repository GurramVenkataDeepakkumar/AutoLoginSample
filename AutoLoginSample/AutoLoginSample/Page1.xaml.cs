using Plugin.AutoLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoLoginSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        public void OnRemoveLoginData(object sender, EventArgs e)
        {
            if (CrossAutoLogin.Current.UserIsSaved)
            {
                CrossAutoLogin.Current.DeleteUserInfos();
            }
        }
    }
}