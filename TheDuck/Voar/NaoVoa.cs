using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuck
{
    class NaoVoa : IVoar
    {
        public void Voar()
        {
            Console.WriteLine("Eu não posso voar"); 
        }
    }
}
