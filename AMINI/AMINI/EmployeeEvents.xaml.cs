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
    public partial class EmployeeEvents : ContentPage
    {
        MainViewModel mainView;
        public EmployeeEvents(MainViewModel mainView)
        {
            InitializeComponent();
            this.mainView = new MainViewModel(mainView);
            BindingContext = mainView;
        }

        async private void DefineEventButton_Clicked(object sender, EventArgs e)
        {
            BindingContext = mainView;
            
            await Navigation.PushAsync(new DefinedEvent(mainView));
        }

        private void listView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            var thisEvent = (e.ItemData as Event);
            Navigation.PushAsync(new DefinedEvent(mainView, thisEvent));
        }
    }
}