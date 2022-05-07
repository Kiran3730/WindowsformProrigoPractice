using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
     public class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
    }
}
