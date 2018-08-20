using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.DF
{
    public class Associate
    {
        public string Remarks { get; set; }
        public List<Exam> schedule = new List<Exam>();
    }
}