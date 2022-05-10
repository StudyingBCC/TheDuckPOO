using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuck
{
    class Marreco : Pato
    {
        public Marreco(string nome) : base(nome)
        {
            this.comerBehavor = new ComerRacao(); 
            this.voarBehavor = new VoarAsas();

        }

        public override void Falar()
        {
            Console.WriteLine("Quá Quá");
        }
    }
}
