using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuck
{
    abstract class Pato
    {
        //protected - só pode ser acessada por tipos dele, que herdem de pato
        protected IComer comerBehavor;
        protected IVoar voarBehavor; 


        public void executaComer()
        {
            comerBehavor.Comer(); 
        }

        public void executaVoar()
        {
            voarBehavor.Voar();
        }

        public void setVoarBehavor(IVoar newVoarBehavor)
        {
            this.voarBehavor = newVoarBehavor; //faz com que algo aconteça e um tempo e depois pare de acontecer
        }

        public string Nome { get; private set; }

        public Pato(string nome)
        {
            this.Nome = nome;
        }

        public abstract void Falar();
        public virtual void Nadar()
        {
            Console.WriteLine("O pato " + this.Nome + " está nadando :)");
        }
    }
}
