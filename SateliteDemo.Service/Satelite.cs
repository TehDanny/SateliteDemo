using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SateliteDemo.Service
{
    public class Satelite
    {
        public int Hours { get; set; }

        public int GetData()
        {
            int data = Hours * 5;
            return data;
        }
    }
}
