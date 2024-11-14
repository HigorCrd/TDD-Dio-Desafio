using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace NewTalent
{
    public class Calculadora
    {
      private List<string> historicoLista;
        private string data;

        public Calculadora(string data) 
        {
            historicoLista = new List<string>();
            this.data = data;
        }

        public int somar(int val1, int val2) 
        {
            int resultadoSoma = val1 + val2;

            historicoLista.Insert(0, "Res: " + resultadoSoma + " - data: " + data);

            return resultadoSoma;
        }

        public int subtrair(int val1, int val2)
        {
            int resultadoSubtracao = val1 - val2;

            historicoLista.Insert(0, "Res: " + resultadoSubtracao + " - data: " + data);

            return resultadoSubtracao;
        }

        public int multiplicar(int val1, int val2)
        {
            int resultadoMult = val1 * val2;

            historicoLista.Insert(0, "Res: " + resultadoMult + " - data: " + data);

            return resultadoMult;
        }

        public int dividir(int val1, int val2)
        {
            int resultadoDiv = val1 / val2;

            historicoLista.Insert(0, "Res: " + resultadoDiv + " - data: " + data);

            return resultadoDiv;
        }

        public List<string> historico() 
        {

            historicoLista.RemoveRange(3, historicoLista.Count - 3);
            return historicoLista;
        }
    }
}