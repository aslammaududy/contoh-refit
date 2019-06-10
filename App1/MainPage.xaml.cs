using App1.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClickedAsync(object sender, EventArgs e)
        {
            var loginInfo = new Dictionary<string, string> {
                {"username", username.Text },
                {"password", password.Text }
            };
            var apiService = NetworkService.GetEndpoint();

            await apiService.Login(loginInfo).ContinueWith(post =>
            {
                if (post.IsCompleted && post.Status == TaskStatus.RanToCompletion)
                {
                    success.Text = "Login Berhasil";
                }
            }, TaskScheduler.FromCurrentSynchronizationContext()).ConfigureAwait(false);
        }

    }
}
