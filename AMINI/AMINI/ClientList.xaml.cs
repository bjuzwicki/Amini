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
    public partial class ClientList : ContentPage
    {
        MainViewModel mainView;
        List<Client> clientList;
        public ClientList(MainViewModel mainView)
        {
            InitializeComponent();
            clientList = new List<Client>
            {
                new Client("Bartłomiej", "Juźwicki", 123456789),
                new Client("Mateusz", "Janczura", 987654321),
                new Client("Arkadiusz", "Milik", 123456789),
                new Client("Ewelina", "Osochocka", 987654321),
                new Client("Patrycja", "Malarz", 123456789),
                new Client("Krzysztof", "Wysocki", 987654321),
                new Client("Martyna", "Dziwirz", 123456789),
                new Client("Piotr", "Wafun", 987654321),
                new Client("Sebastian", "Makłowicz", 123456789),
                new Client("Marcin", "Zawidow", 987654321),
                new Client("Elena", "Tsatsiki", 987654321),
                new Client("Mateusz", "Pater", 123456789),
                new Client("Anastazja", "Kałasznikow-Zarebecka", 123456789)
            };
            this.mainView = new MainViewModel(mainView.Employee);
            mainView.ClientList = clientList;
            BindingContext = this.mainView;
            listView.ItemsSource =  clientList;
            popupLayoutEdit.PopupView.AcceptCommand = new Command(AddNewClient);
        }

        private void NewClient_Clicked(object sender, EventArgs e)
        {
            mainView.SetClientLayout(null,true); // tu zaleznie od employera
            BindingContext = mainView;
            popupLayoutEdit.Show();
        }

        private void listView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            var thisClient = (e.ItemData as Client);
            mainView.SetClientLayout(thisClient);
            BindingContext = mainView;
            popupLayoutEdit.Show();
        }

        private void AddNewClient()
        {
            mainView.Client.SetFullName();
            clientList.Add(mainView.Client);
            listView.ItemsSource = null;
            listView.ItemsSource = clientList;
        }
    }
}