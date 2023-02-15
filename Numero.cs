using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDictionaryType
{
    public class Numero
    {
        private readonly int _inicializaDicionario;
        private IDictionary<int, int> DicionarioDeNumeros { get; set; } = new Dictionary<int, int>();

        public Numero(int inicializaDicionario)
        {
            _inicializaDicionario = inicializaDicionario;
        }
        public void CriarDicionarioDeNumeros()
        {
            var incrementa = _inicializaDicionario;

            for (int i = 0; i < 20; i++)
            {
                DicionarioDeNumeros.Add(incrementa, incrementa * 13);
                incrementa++;
            }
        }

        public override string ToString()
        {
            var retorno = string.Empty;

            foreach (var item in DicionarioDeNumeros)
            {
                retorno += $"Chave: {item.Key} - Valor: {item.Value}\n\r";
            }

            return $"A Lista de número retornou:\n\r{retorno}";
        }
    }
}
