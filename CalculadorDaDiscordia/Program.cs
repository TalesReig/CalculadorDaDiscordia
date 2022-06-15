using System;
using System.Collections.Generic;

namespace CalculadorDaDiscordia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> historico = new List<string>();

            string historicoDeCalculos;

            char operacao;
            char teste;
            double valor1 = 0;
            double valor2 = 0;
            double resultado = 0;

            do
            {
                do
                {
                    Console.Write("Escolha a operação que deseja realizar(+),(-),(*),(:) e (H para visualizar historico): ");
                    operacao = Convert.ToChar(Console.ReadLine().ToUpper());
                } while (operacao != '+' && operacao != '-' && operacao != '*' && operacao != ':' && operacao != 'H');

                if (operacao != 'H')
                {
                    Console.Write("Digite o primeiro valor: ");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                    do
                    {
                        Console.Write("Digite o segundo valor: ");
                        valor2 = Convert.ToInt32(Console.ReadLine());
                        if (operacao == ':' && valor2 == 0)
                        {
                            Console.WriteLine("Não é possível dividir por 0");
                        }
                    } while (operacao == ':' && valor2 == 0);

                }

                switch (operacao)
                {
                    case '+':
                        resultado = valor1 + valor2;
                        AdicionaOperacoesNoHistorico(historico, operacao, valor1, valor2, resultado);
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case '-':
                        resultado = valor1 - valor2;
                        AdicionaOperacoesNoHistorico(historico, operacao, valor1, valor2, resultado);
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case '*':
                        resultado = valor1 * valor2;
                        AdicionaOperacoesNoHistorico(historico, operacao, valor1, valor2, resultado);
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case ':':
                        resultado = (valor1 / valor2) + (valor1 % valor2);
                        AdicionaOperacoesNoHistorico(historico, operacao, valor1, valor2, resultado);
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case 'H':
                        Console.WriteLine("\nVisualização de historico \n");

                        if (historico.Count != 0)
                        {
                            foreach (var item in historico)
                            {
                                Console.WriteLine(item);
                            }
                            Console.ReadLine();
                        }
                        else
                            Console.WriteLine("Historico Vazio");
                        Console.ReadLine();

                        break;
                }
               

                do
                {
                    Console.WriteLine("Deseja efetuar mais uma operação (s) (n):");
                    teste = Convert.ToChar(Console.ReadLine().ToUpper());
                } while (teste != 'S' && teste != 'N');

            } while (teste == 'S');
            
        }

        private static string AdicionaOperacoesNoHistorico(List<string> historico, char operacao, double valor1, double valor2, double resultado)
        {
            string historicoDeCalculos = valor1 + " " + operacao + " " + valor2 + " = " + resultado;
            historico.Add(historicoDeCalculos);
            return historicoDeCalculos;
        }
    }
}
