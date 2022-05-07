using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class BatchInformation1
    {
        public int BatchId { get; set; }
        public String BatchName { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public String Location { get; set; }
        public String TrainerName { get; set; }

    }
}
