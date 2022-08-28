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
    public partial class Menu : ContentPage
    {
        MainViewModel mainView;
        Employee employee;
        public Menu()
        {
            InitializeComponent();
            employee = new Employee("Bartłomiej","Juźwicki",Color.Blue);
            mainView = new MainViewModel(employee);
            mainView.GenerateEventsMap();
            employee.Events.Add(new Event("Badanie laserowe opuszka migdałowego prawej ręki metodą Gridenhorfa","Prawy opuszek - Gri", 1, employee, new DateTime(2020, 09, 26, 10, 0, 0), new DateTime(2020, 09, 26, 14, 0, 0)));
            employee.Events.Add(new Event("Korepetycje z matematyki", "Matma", 112, employee, new DateTime(2020, 09, 26, 09, 0, 0), new DateTime(2020, 09, 26, 12, 0, 0)));
            employee.Events.Add(new Event("Badanie oczodołu wewnętrznego laserem opływowym", "Oczoduł - laser opływowy", 2, employee, new DateTime(2020, 09, 26, 10, 0, 0), new DateTime(2020, 09, 26, 14, 0, 0)));
            employee.Events.Add(new Event("Korepetycje z biologii", "Biola", 8, employee, new DateTime(2020, 09, 26, 10, 0, 0), new DateTime(2020, 09, 26, 14, 0, 0)));
            employee.Events.Add(new Event("Treninig umiejętności społecznych", "Skille społeczne" ,12, employee, new DateTime(2020, 09, 26, 10, 0, 0), new DateTime(2020, 09, 26, 14, 0, 0)));
            employee.Events.Add(new Event("Badanie laserowe opuszka migdałowego prawej ręki metodą Gridenhorfa dla ubogich", "Prawy opuszek - Gri UB", 12, employee, new DateTime(2020, 09, 26, 10, 0, 0), new DateTime(2020, 09, 26, 14, 0, 0)));
            employee.Events.Add(new Event("Badanie laserowe opuszka migdałowego prawej ręki metodą Gridenhorfa dla niepełnosprytnych","Prawy opuszek - Gri NS",12, employee, new DateTime(2020, 09, 26, 10, 0, 0), new DateTime(2020, 09, 26, 14, 0, 0)));
        }

        async private void CalendarButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SchedulerTest(mainView));
        }

        private void LogOutButton_Clicked(object sender, EventArgs e)
        {
             var loginpage = new LogInPage();
             Application.Current.MainPage = new NavigationPage(loginpage);
        }

        async private void EmployeeEventsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EmployeeEvents(mainView));
        }

        async private void ClientButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientList(mainView));
        }
    }
}