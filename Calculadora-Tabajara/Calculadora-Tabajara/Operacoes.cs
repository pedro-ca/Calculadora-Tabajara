using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Tabajara
{
    class Operacoes
    {
        public double NumeroA;
        public double NumeroB;
        public char TipoOperacao;
        public double Resultado;

        public Operacoes(double numeroA, double numeroB, char tipoOperacao, double resultado)
        {
            NumeroA = numeroA;
            NumeroB = numeroB;
            TipoOperacao = tipoOperacao;
            Resultado = resultado;
        }
    }
}
