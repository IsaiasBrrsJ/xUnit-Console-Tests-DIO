using Calculadora.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Operacoes.Calculadora
{
    public class OperacoesCalculadora
    {
        private readonly  List<string>  historicoResultado;

       
        public OperacoesCalculadora()
        {
            historicoResultado = new List<string>();
        }


        public List<string> RetornaLista()
        {
            return historicoResultado;
        }

        public int Somar(int x, int y)
        {   
            var resultado =  x + y;
            historicoResultado.Add( Util.ConverteParaString(resultado));

            return resultado;
        }

        public int Multiplicar(int x, int y)
        {
            var resultado = x * y;
            historicoResultado.Add( Util.ConverteParaString(resultado));

            return resultado;
        }

        public int Dividir(int x, int y)
        {
            var resultado = x / y;

            if(resultado > 0)
            {
                historicoResultado.Add(Util.ConverteParaString(resultado));
            }
         

            return resultado;
        }

        public int Subtrair(int x, int y)
        {
            var resultado = x - y;
            historicoResultado.Add(Util.ConverteParaString(resultado));

            return resultado;
        }



    }
}
