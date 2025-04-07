using System;

class Program
{
    static void Main()
    {
        // 1. Exercício: Nome e Saudação
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Olá, " + nome + "!");
        Console.WriteLine(); // linha em branco
        
        // 2. Exercício: Calculando a Idade
        Console.Write("Digite o seu ano de nascimento: ");
        int anoNascimento = int.Parse(Console.ReadLine());
        int idade = 2024 - anoNascimento;
        Console.WriteLine("Sua idade é: " + idade + " anos.");
        Console.WriteLine(); // linha em branco

        // 3. Exercício: Média de Notas
        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.Write("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());
        Console.Write("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());
        double media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine("A média das notas é: " + media);
        Console.WriteLine(); // linha em branco

        // 4. Exercício: Maior Número
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());
        if (num1 > num2)
        {
            Console.WriteLine("O maior número é: " + num1);
        }
        else if (num2 > num1)
        {
            Console.WriteLine("O maior número é: " + num2);
        }
        else
        {
            Console.WriteLine("Os dois números são iguais.");
        }
        Console.WriteLine(); // linha em branco

        // 5. Exercício: Verificar Par ou Ímpar
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número " + numero + " é par.");
        }
        else
        {
            Console.WriteLine("O número " + numero + " é ímpar.");
        }

        // Para manter o console aberto
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
