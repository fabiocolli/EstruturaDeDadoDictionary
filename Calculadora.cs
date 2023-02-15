using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDictionaryType
{
    public class Calculadora
    {
        private void Somar(int numeroUm, int numeroDois)
        {
            Console.WriteLine("Soma : " + (numeroDois + numeroUm));
        }

        private void Multiplicar(int numeroUm, int numeroDois)
        {
            Console.WriteLine("Multiplicação : " + (numeroDois * numeroUm));
        }
        private void Subtrair(int numeroUm, int numeroDois)
        {
            Console.WriteLine("Subtração : " + (numeroUm - numeroDois));
        }
        private void Dividir(int numeroUm, int numeroDois)
        {
            Console.WriteLine("Divisão: " + (numeroUm / numeroDois));
        }

        public void Faca(string parametro, int numeroUm, int numeroDois)
        {
            var acoes = new Dictionary<string, Action<int, int>>()
            {
                {"+", Somar },
                {"-", Subtrair },
                {"*", Multiplicar },
                {"/", Dividir }
            };

            acoes[parametro].Invoke(numeroUm, numeroDois);
        }
    }
}
