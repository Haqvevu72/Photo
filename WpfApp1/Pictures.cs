using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Pictures
    {
        static int id = 0;
        public int ID { get; set; }
        public string Source { get; set; }

        public Pictures(string source)
        {
            ID = ++id;
            Source = source;
        }


    }
}
