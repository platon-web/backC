using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary
{
    public class Order
    {
        public string Address { set; get; }
        public string City { set; get; }    
        public int Price { set; get; }
        public int Status { set; get; }
        public int Sale { set; get; }
        public int Time { set; get; }
        public int Amount { set; get; } 
        public int PhoneNumber { set; get; }    
        public bool Pay { set; get; }
        public string BankCard { set; get; }
    }

}
