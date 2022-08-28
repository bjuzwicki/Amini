using System;
using System.Collections.Generic;
using System.Text;

namespace AMINI
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int PhoneNumber { get; set; }

        public Client(string firstName, string lastName, int phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            SetFullName();
        }
        public Client()
        {
            
        }

        public void SetFullName()
        {
            FullName = FirstName + " " + LastName;
        }
    }
}
