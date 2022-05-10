using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuck
{
    class PatoDeBorracha : Pato
    {
        public PatoDeBorracha(string nome) : base(nome)
        {
            this.comerBehavor = new NaoComer(); //faz com que o pato não coma
            this.voarBehavor = new NaoVoa(); 
        }

        public override void Nadar()
        {
            Console.WriteLine("O pato " + this.Nome + " só sabe boiar"); 
        }

        public override void Falar()
        {
            Console.WriteLine("O pato " + this.Nome + " não sabe falar"); 
        }
    }
}
