using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio07_04
{
    public class Exercicio04
    {
        public void Executar()
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("O maior número é: " + num1);
            else if (num2 > num1)
                Console.WriteLine("O maior número é: " + num2);
            else
                Console.WriteLine("Os dois números são iguais.");

            Console.WriteLine();
        }
    }
}