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
    }
}
