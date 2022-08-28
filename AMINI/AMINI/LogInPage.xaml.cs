using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AMINI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzE4MjI3QDMxMzgyZTMyMmUzMENrb1ArTjZjakV5MTdhbTZJd09wS2hhSkZNQzBtUGovVVBSRlpXNUtxZmc9");
            InitializeComponent();
        }

        private void LogInButton_Clicked(object sender, EventArgs e)
        {
            if(loginText.Text == "a" && passwordText.Text == "b")
            {
                passwordText.Text = "";
                var menu = new Menu();
                Application.Current.MainPage = new NavigationPage(menu);
            }
            else
            {
                passwordText.Text = "";
                DisplayAlert("Błąd identyfikacji","Podany login lub hasło są błędne.","Ok");
            }
        }      
    }
}