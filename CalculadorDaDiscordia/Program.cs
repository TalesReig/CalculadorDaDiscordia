using System;

namespace CalculadorDaDiscordia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char operacao;
            char teste;
            double valor1 = 0;
            double valor2 = 0;
            double resultado = 0;

            do
            {
                do
                {
                    Console.Write("Escolha a operação que deseja realizar(+),(-),(*) ou (:): ");
                    operacao = Convert.ToChar(Console.ReadLine());
                } while (operacao != '+' && operacao != '-' && operacao != '*' && operacao != ':');

                Console.Write("Digite o primeiro valor: ");
                valor1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                valor2 = Convert.ToInt32(Console.ReadLine());

                switch (operacao)
                {
                    case '+':
                        resultado = valor1 + valor2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case '-':
                        resultado = valor1 - valor2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case '*':
                        resultado = valor1 * valor2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                }

                do
                {
                    Console.Write("Deseja efetuar mais uma operação (s) (n):");
                    teste = Convert.ToChar(Console.ReadLine().ToUpper());
                } while (teste != 'S' && teste != 'N');

            } while(teste == 'S');

        }
    }
}
