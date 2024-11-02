using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class fruits
    {
        public string[] fruitNames = new string[5];

        public string this[int i]
        {
            get
            {
                return fruitNames[i];
            }
            set
            {
                fruitNames[i] = value;
            }

        }
    }
}