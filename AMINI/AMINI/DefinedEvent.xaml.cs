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
    public partial class DefinedEvent : ContentPage
    {
        MainViewModel mainView;
        List<Client> clientList;
        public DefinedEvent(MainViewModel mainView, Event thisEvent = null)
        {
            InitializeComponent();
            clientList = new List<Client>
            {
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Bartłomiej", "Juźwicki", 123456789),
            };
            this.mainView = new MainViewModel(mainView.Employee);
            mainView.ClientList = clientList;
            BindingContext = thisEvent;

            ListView.ItemsSource =  clientList;

            if(thisEvent == null)
            {
                ListViewFrame.IsVisible = false;

                AddOrEditClientListButton.Text = "Dodaj klientów do zajęć";
            }
           

            if(clientList.Count == 0)
            {
                clientListHeaderTitle.IsVisible = false;
            }
        }

        private void AddOrEditClientListButton_Clicked(object sender, EventArgs e)
        {
             ListViewFrame.IsVisible = true;

             AddOrEditClientListButton.Text = "Edytuj listę klientów";
        }
    }
}