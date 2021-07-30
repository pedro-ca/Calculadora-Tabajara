using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Tabajara
{
    class Operacao
    {
        public double NumeroA;
        public double NumeroB;
        public char TipoOperacao;
        public double Resultado;

        public Operacao(double numeroA, double numeroB)
        {
            NumeroA = numeroA;
            NumeroB = numeroB;
        }

        public void Adicao()
        {
            Resultado = NumeroA + NumeroB;
            TipoOperacao = '+';
        }
        public void Subtracao()
        {
            Resultado = NumeroA - NumeroB;
            TipoOperacao = '-';
        }

        public void Multiplicacao()
        {
            Resultado = NumeroA * NumeroB;
            TipoOperacao = '*';
        }

        public void Divisao()
        {
            if (NumeroB == 0)
            {
                throw new DivideByZeroException();

                Resultado = NumeroA / NumeroB;
                TipoOperacao = '/';
            }
        }
        public string AtributosToString()
        {
            return $"`{this.NumeroA} {this.TipoOperacao} {this.NumeroB} = {this.Resultado}";
        }
    }
}
