using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuck
{
    class NaoComer : IComer
    {
        public void Comer()
        {
            Console.WriteLine("Tô de dieta, não como não"); 
        }
    }
}
