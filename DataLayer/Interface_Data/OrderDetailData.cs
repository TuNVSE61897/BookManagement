using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Data
{
    public class OrderDetailData
    {
        public int ID { get; set; }
        public Nullable<int> book_ID { get; set; }
        public Nullable<int> order_ID { get; set; }
        public Nullable<int> quantity { get; set; }
    }
}
