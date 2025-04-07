using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio07_04
{
    public class Exercicio01
    {
        public void Executar()
        {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome + "!");
            Console.WriteLine(); // linha em branco
        }
    }
}