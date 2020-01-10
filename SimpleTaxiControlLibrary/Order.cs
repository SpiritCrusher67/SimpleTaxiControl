using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaxiControlLibrary
{
    public class Order
    {
        public string AddressFrom { get; set; }

        public string NumberFrom { get; set; }

        public string AddressTo { get; set; }

        public string NumberTo { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime Date { get; set; }

        public string Comment { get; set; }


    }
}
