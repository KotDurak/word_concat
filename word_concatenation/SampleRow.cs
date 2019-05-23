using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word_concatenation
{
    class SampleRow
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }


        public string Hidden = ""; 
    
        public SampleRow(string name, float price, int count)
        {
            this.Name = name;
            this.Price = price;
            this.Count = count; 
        }
    }
}
