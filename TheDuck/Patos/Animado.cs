using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuck
{
    class Animado : Pato
    {
        public Animado(string nome) : base(nome)
        {
            this.comerBehavor = new ComidaAnimada();
            this.voarBehavor = new VoarAviao();
        }

        public override void Falar()
        {
            Console.WriteLine("Eu sou o " + this.Nome + " e sei falar muito bem :)");
        }


    }
}
