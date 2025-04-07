using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio07_04
{
    public class Exercicio02
    {
        public void Executar()
        {
            Console.Write("Digite o seu ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());
            int idade = 2024 - anoNascimento;
            Console.WriteLine("Sua idade é: " + idade + " anos.");
            Console.WriteLine();
        }
    }
}