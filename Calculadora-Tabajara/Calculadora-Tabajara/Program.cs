using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Tabajara
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacao operacao = null;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite a Opção desejada: ");
                Console.WriteLine("+ = Adição ");
                string inputOperacao = Console.ReadLine();

                Console.WriteLine("Digite o primeiro numero: ");
                if (!int.TryParse(Console.ReadLine(), out int inputNumeroA)) {
                    Console.WriteLine("O primeiro número deve ser um inteiro valido. Tente novamente.");
                    continue;
                }

                Console.WriteLine("Digite o segundo numero: ");
                if (!int.TryParse(Console.ReadLine(), out int inputNumeroB))
                {
                    Console.WriteLine("O primeiro número deve ser um inteiro valido. Tente novamente.");
                    continue;
                }

                switch (inputOperacao)
                {
                    case "+":
                        operacao = new Operacao(inputNumeroA, inputNumeroB);
                        operacao.Adicao();
                        break;

                    default:
                        Console.WriteLine("Operação invalida. Tente novamente.");
                        continue;
                }

                Console.WriteLine($"{operacao.NumeroA} {operacao.TipoOperacao} {operacao.NumeroB} = {operacao.Resultado}");
                Console.ReadLine();
            }
        }
    }
}
