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
                Console.WriteLine("1 - Adição ");
                string inputUsuario = Console.ReadLine();

                switch (inputUsuario)
                {
                    case "1":
                        operacao = new Operacao(3, 4);
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
