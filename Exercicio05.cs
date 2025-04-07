using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio07_04
{
    public class Exercicio05
    {
        public void Executar()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("O número " + numero + " é par.");
            else
                Console.WriteLine("O número " + numero + " é ímpar.");

            Console.WriteLine();
        }
    }
}