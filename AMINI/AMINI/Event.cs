using Syncfusion.SfSchedule.XForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace AMINI
{
    public class Event : ScheduleAppointment
    {
        public string Name {get; set;}
        public string ShortName {get;set;}
        public int Room {get; set;}
        public List<Client> Clients; // klasa Client
        public Employee Employee {get;set;}

        public Event(MainViewModel mainView)
        {   
            Clients = mainView.ClientList;
            Name = mainView.EventName;
            Room = mainView.EventRoomNumber;
            Employee = mainView.Employee;
	        StartTime = mainView.EventFromDate.Date.Add(mainView.EventFromTime);
	        EndTime = mainView.EventToDate.Date.Add(mainView.EventToTime);
            Color = Employee.EventColor;
            SetSubject();
        }

        public Event(string name, string shortName, int room, Employee employee, DateTime startTime, DateTime endTime)
        {
            Name = name;
            ShortName = shortName;
            Room = room;
            Employee = employee;
	        StartTime = startTime;
	        EndTime = endTime;
            Clients = new List<Client>(); // lista klientów
            Color = employee.EventColor;
            SetSubject();
        }

        public Event()
        {
            Color = Employee.EventColor;
            SetSubject();
        }

        private void SetSubject()
        {
            Subject = ShortName + ",\n" + "sala " + Room +",\n" + Employee.FullName;
        }
    }
}
