using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Product1
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Price { get; set; }
        public String Category { get; set; }

    }
}
