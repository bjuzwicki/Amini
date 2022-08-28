using Syncfusion.SfSchedule.XForms;
using Syncfusion.XForms.PopupLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AMINI
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string eventName = string.Empty;
        string eventShortName = string.Empty;
        int eventRoomNumber;
        TimeSpan eventFromTime;
        TimeSpan eventToTime;
        DateTime eventFromDate;
        DateTime eventToDate;
        ScheduleAppointmentCollection scheduleAppointmentCollection;
        bool isEditing = true;
        string title = string.Empty;
        AppearanceMode appearanceMode; // TwoButton, OneButton
        string acceptButtonText = string.Empty;
        string cancelButtonText = string.Empty;
        Employee employee;
        Employee eventEmployee;
        List<Client> clientList;
        Client client;

        public MainViewModel(MainViewModel mainView)
        {
            if(mainView != null)
            {
                EventName = mainView.EventName;
                EventShortName = mainView.EventShortName;
                EventRoomNumber = mainView.EventRoomNumber;
                EventFromDate = mainView.EventFromDate;
                EventFromTime = mainView.EventFromTime;
                EventToDate = mainView.EventToDate;
                EventToTime = mainView.EventToTime;
                IsEditing = mainView.IsEditing;
                ScheduleAppointmentCollection = mainView.ScheduleAppointmentCollection;
                Employee = mainView.Employee;
            }
        }

        public MainViewModel(Employee employee)
        {
            Employee = employee;
        }

        public void GenerateEventsMap()
        {
            ScheduleAppointmentCollection = new ScheduleAppointmentCollection
            {
                new Event("Meeting","Meeting", 2, new Employee("Stachu", "Motyka", Color.Red), new DateTime(2020, 09, 26, 10, 0, 0), new DateTime(2020, 09, 26, 14, 0, 0)),
                new Event("Meeting2","Meeting2", 3, new Employee("Stachu", "Motyka", Color.Red), new DateTime(2020, 09, 26, 09, 0, 0), new DateTime(2020, 09, 26, 12, 0, 0)),
                new Event("Meeting3","Meeting3", 5, new Employee("Andrzej", "Wus", Color.Green), new DateTime(2020, 10, 12, 8, 0, 0), new DateTime(2020, 10, 12, 9, 0, 0)),
                new Event("Meeting4","Meeting4", 7, new Employee("Andrzej", "Wus", Color.Green), new DateTime(2020, 10, 12, 11, 0, 0), new DateTime(2020, 10, 12, 15, 0, 0))
            };
        }
        public string EventName
        {
            get => eventName;
            set
            {
                if(eventName == value)
                {
                    return;
                }

                eventName = value;
                OnPropertyChanged(nameof(EventName));
            }
        }

        public string EventShortName
        {
            get => eventShortName;
            set
            {
                if(eventShortName == value)
                {
                    return;
                }

                eventShortName = value;
                OnPropertyChanged(nameof(EventShortName));
            }
        }
        public int EventRoomNumber
        {
            get => eventRoomNumber;
            set
            {
                if(eventRoomNumber == value)
                {
                    return;
                }

                eventRoomNumber = value;
                OnPropertyChanged(nameof(EventRoomNumber));
            }
        }

        public TimeSpan EventFromTime
        {
            get => eventFromTime;
            set
            {
                if(eventFromTime == value)
                {
                    return;
                }

                eventFromTime = value;
                OnPropertyChanged(nameof(EventFromTime));
            }
        }

        public TimeSpan EventToTime
        {
            get => eventToTime;
            set
            {
                if(eventToTime == value)
                {
                    return;
                }

                eventToTime = value;
                OnPropertyChanged(nameof(EventToTime));
            }
        }

        public DateTime EventFromDate
        {
            get => eventFromDate;
            set
            {
                if(eventFromDate == value)
                {
                    return;
                }

                eventFromDate = value;
                OnPropertyChanged(nameof(EventFromDate));
            }
        }

        public DateTime EventToDate
        {
            get => eventToDate;
            set
            {
                if(eventToDate == value)
                {
                    return;
                }

                eventToDate = value;
                OnPropertyChanged(nameof(EventToDate));
            }
        }

        public bool IsEditing
        {
            get => isEditing;
            set
            {
                if(isEditing == value)
                {
                    return;
                }

                isEditing = value;
                OnPropertyChanged(nameof(IsEditing));
            }
        }

        public bool IsVisible
        {
            get => !isEditing;
            set
            {
                OnPropertyChanged(nameof(IsVisible));
            }
        }

        public string Title
        {
            get => title;
            set
            {
                if(title == value)
                {
                    return;
                }

                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public AppearanceMode AppearanceMode
        {
            get => appearanceMode;
            set
            {
                if(appearanceMode == value)
                {
                    return;
                }

                appearanceMode = value;
                OnPropertyChanged(nameof(AppearanceMode));
            }
        }

        public string AcceptButtonText
        {
            get => acceptButtonText;
            set
            {
                if(acceptButtonText == value)
                {
                    return;
                }

                acceptButtonText = value;
                OnPropertyChanged(nameof(AcceptButtonText));
            }
        }

        public string CancelButtonText
        {
            get => cancelButtonText;
            set
            {
                if(cancelButtonText == value)
                {
                    return;
                }

                cancelButtonText = value;
                OnPropertyChanged(nameof(CancelButtonText));
            }
        }

        public Employee Employee
        {
            get => employee;
            set
            {
                if(employee == value)
                {
                    return;
                }

                employee = value;
                OnPropertyChanged(nameof(Employee));
            }
        }

        public Employee EventEmployee
        {
            get => eventEmployee;
            set
            {
                if(eventEmployee == value)
                {
                    return;
                }

                eventEmployee = value;
                OnPropertyChanged(nameof(Employee));
            }
        }

        public ScheduleAppointmentCollection ScheduleAppointmentCollection
        {
            get => scheduleAppointmentCollection;
            set
            {
                if(scheduleAppointmentCollection == value)
                {
                    return;
                }

                scheduleAppointmentCollection = value;
                OnPropertyChanged(nameof(ScheduleAppointmentCollection));
            }
        }

        public List<Client> ClientList
        {
            get => clientList;
            set
            {
                if(clientList == value)
                {
                    return;
                }

                clientList = value;
                OnPropertyChanged(nameof(ClientList));
            }
        }

        public Client Client
        {
            get => client;
            set
            {
                if(client == value)
                {
                    return;
                }

                client= value;
                OnPropertyChanged(nameof(Client));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void SetEventLayoutPreviewData(Event thisEvent)
        {
            EventName = thisEvent.Name;
            EventShortName = thisEvent.ShortName;
            EventRoomNumber = thisEvent.Room;
            EventFromTime = thisEvent.StartTime.TimeOfDay;
            EventFromDate = thisEvent.StartTime.Date;
            EventToTime = thisEvent.EndTime.TimeOfDay;
            EventToDate = thisEvent.EndTime;
            IsEditing = false;
            AppearanceMode = AppearanceMode.OneButton;
            AcceptButtonText = "Ok";
            Title = EventName; 
            EventEmployee = thisEvent.Employee;
        }
        public void SetEventLayoutEditData(CellTappedEventArgs e)
        {
            if(e != null)
            {
                EventFromTime = e.Datetime.TimeOfDay; 
                EventFromDate = e.Datetime.Date;
                EventToDate = e.Datetime.Date;
            }
            else
            {
                EventFromDate = DateTime.Now;
                EventToDate = DateTime.Now;
            }
            
            if(EventFromTime == TimeSpan.Zero)
            {   
                EventFromTime = DateTime.Now.TimeOfDay;
            }

            EventToTime = EventFromTime + TimeSpan.FromHours(1);

            Title = "";

            EventName = "";
            EventShortName = "";
            EventRoomNumber = new Int32();
            IsEditing = true;
            AppearanceMode = AppearanceMode.TwoButton;
            AcceptButtonText = "Dodaj";
            CancelButtonText = "Anuluj";
        }

        public void SetClientLayout(Client thisClient, bool permisions = false)
        {
            if(thisClient != null)
            {
                Client = thisClient;
                IsEditing = permisions;
                AppearanceMode = AppearanceMode.OneButton;
                AcceptButtonText = "Ok";
            }
            else
            {
                Client = new Client();
                IsEditing = true;
                AppearanceMode = AppearanceMode.TwoButton;
                AcceptButtonText = "Dodaj";
                CancelButtonText = "Anuluj";
            }
        }
    }
}
