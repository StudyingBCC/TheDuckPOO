using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindos ao The Duck Brasil \n \n");
            PatoDeBorracha borracha = new PatoDeBorracha("Jorge");
            Marreco marreco = new Marreco("João");
            Animado animado = new Animado("Tio Patinhas");


            Console.WriteLine("Olá eu sou o " + marreco.Nome); 
            marreco.Falar();
            marreco.executaComer();
            marreco.executaVoar();
            Console.WriteLine("\n");

            Console.WriteLine("Olá eu sou o " + borracha.Nome);
            borracha.Falar();
            borracha.executaComer();
            borracha.executaVoar();
            Console.WriteLine("\n");

            Console.WriteLine("Olá eu sou o " + animado.Nome);
            animado.Falar();
            animado.executaComer();
            animado.executaVoar();

        }
    }
}
