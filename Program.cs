using System;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer? ");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("---------------------");
        Console.WriteLine("Selecione uma opção: ");

        int escolhaDoUsuario = int.Parse(Console.ReadLine());

        switch (escolhaDoUsuario)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break; //sair do console.
            default: Menu(); break;
        }
    }
    static void Soma()
    {
        Console.Clear(); //Limpa a tela

        //Definirmos dois valores na tela e somarmos eles
        Console.WriteLine("Primeiro valor: "); // Dizer para o user o que fazer
        double valor1 = double.Parse(Console.ReadLine()); // Usuario vai digitar algo, armazenando o valor

        Console.WriteLine("Segundo Valor: ");
        double valor2 = double.Parse(Console.ReadLine());

        // Executar a soma de ambos
        Console.WriteLine("");

        double resultado = valor1 + valor2;
        Console.WriteLine($"O resultado da soma é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        double valor1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Segundo Valor: ");
        double valor2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = valor1 - valor2;
        Console.WriteLine($"O Resultado da subtração é: {resultado}");
        Console.ReadKey(); //Não faz o programa fechar
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        double valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = valor1 / valor2;
        Console.WriteLine($"O resultado da divisão é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        double valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = valor1 * valor2;
        Console.WriteLine("O resultado da multiplicação é: " + resultado);
        Console.ReadKey();
        Menu();
    }

}