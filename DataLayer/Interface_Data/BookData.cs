using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Data
{
    public class BookData
    {
        public int ID { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Thumnail { get; set; }
        public string Status { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Year { get; set; }
        public int Publisher_ID { get; set; }
        public List<CategoryData> Category { get; set; }
        public List<AuthorData> Author { get; set; }
        
    }
}
