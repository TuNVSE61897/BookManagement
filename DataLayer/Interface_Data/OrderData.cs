using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Data
{
    public class OrderData
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string status { get; set; }
        public Nullable<int> account_ID { get; set; }
        public string customer_name { get; set; }
    }
}
