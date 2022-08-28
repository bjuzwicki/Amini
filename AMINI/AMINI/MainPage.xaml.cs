using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;

namespace AMINI
{
    public partial class MainPage : ContentPage
    {
        bool wasActive = false;
        public MainPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(5),
            () =>
                {
                    wasActive = true;
                    var loginpage = new LogInPage();
                    //Navigation.PushModalAsync(loginpage);
                    Application.Current.MainPage = new NavigationPage(loginpage);
                    return false;
                }
            );
        }

        protected override void OnAppearing()
        {
            if(wasActive)
            {
                System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
            }
        }
    }
}
