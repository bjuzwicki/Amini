using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Text;
using Xamarin.Forms;

namespace AMINI
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public Image Photo { get; set; }
        public Xamarin.Forms.Color EventColor { get; set; }
        public List<Event> Events {get;set;}

        public Employee(string name, string surname, Xamarin.Forms.Color eventColor, Image photo = null)
        {
            Name = name;
            Surname = surname;
            FullName = Name + " " + Surname;
            EventColor = eventColor;
            Photo = photo;
            Events = new List<Event>();
        }
    }
}
