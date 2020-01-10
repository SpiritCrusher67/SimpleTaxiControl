using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaxiControlLibrary
{
    public class Call
    {
        public string Number { get; set; }

        public User ResponsibleUser  { get; set; }

        public DateTime Date { get; set; }

        public Call(string number, User user)
        {
            Number = number;
            ResponsibleUser = user;
        }

        public void SaveCall()
        {

        }
    }
}
