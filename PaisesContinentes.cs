using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDictionaryType
{
    public class PaisesContinentes
    {
        private Dictionary<string, string> DicionarioPaisesEContinentes { get; set; } = new Dictionary<string, string>();

        private readonly string _filtro;

        public PaisesContinentes(string filtro)
        {
            _filtro = filtro;
        }

        public void PreencherDicionarioDePaisesEContinentes()
        {
            DicionarioPaisesEContinentes.Add("África do Sul", "África");
            DicionarioPaisesEContinentes.Add("Angola", "África");
            DicionarioPaisesEContinentes.Add("Argélia", "África");
            DicionarioPaisesEContinentes.Add("Benim", "África");
            DicionarioPaisesEContinentes.Add("Botsuana", "África");
            DicionarioPaisesEContinentes.Add("Burquina Faso", "África");
            DicionarioPaisesEContinentes.Add("Burúndi", "África");
            DicionarioPaisesEContinentes.Add("Cabo Verde", "África");
            DicionarioPaisesEContinentes.Add("Camarões", "África");
            DicionarioPaisesEContinentes.Add("Chade", "África");
            DicionarioPaisesEContinentes.Add("Comores", "África");
            DicionarioPaisesEContinentes.Add("Congo-Brazzaville", "África");
            DicionarioPaisesEContinentes.Add("Costa do Marfim", "África");
            DicionarioPaisesEContinentes.Add("Egito", "África");
            DicionarioPaisesEContinentes.Add("Eritreia", "África");
            DicionarioPaisesEContinentes.Add("Essuatíni", "África");
            DicionarioPaisesEContinentes.Add("Etiópia", "África");
            DicionarioPaisesEContinentes.Add("Gabão", "África");
            DicionarioPaisesEContinentes.Add("Gâmbia", "África");
            DicionarioPaisesEContinentes.Add("Gana", "África");
            DicionarioPaisesEContinentes.Add("Guiné", "África");
            DicionarioPaisesEContinentes.Add("Guiné Equatorial", "África");
            DicionarioPaisesEContinentes.Add("Guiné-Bissau", "África");
            DicionarioPaisesEContinentes.Add("Jibuti", "África");
            DicionarioPaisesEContinentes.Add("Lesoto", "África");
            DicionarioPaisesEContinentes.Add("Libéria", "África");
            DicionarioPaisesEContinentes.Add("Líbia", "África");
            DicionarioPaisesEContinentes.Add("Madagáscar", "África");
            DicionarioPaisesEContinentes.Add("Maláui", "África");
            DicionarioPaisesEContinentes.Add("Mali", "África");
            DicionarioPaisesEContinentes.Add("Marrocos", "África");
            DicionarioPaisesEContinentes.Add("Maurícia", "África");
            DicionarioPaisesEContinentes.Add("Mauritânia", "África");
            DicionarioPaisesEContinentes.Add("Moçambique", "África");
            DicionarioPaisesEContinentes.Add("Namíbia", "África");
            DicionarioPaisesEContinentes.Add("Níger", "África");
            DicionarioPaisesEContinentes.Add("Nigéria", "África");
            DicionarioPaisesEContinentes.Add("Quénia", "África");
            DicionarioPaisesEContinentes.Add("República Centro-Africana", "África");
            DicionarioPaisesEContinentes.Add("República Democrática do Congo", "África");
            DicionarioPaisesEContinentes.Add("Ruanda", "África");
            DicionarioPaisesEContinentes.Add("São Tomé e Príncipe", "África");
            DicionarioPaisesEContinentes.Add("Seicheles", "África");
            DicionarioPaisesEContinentes.Add("Senegal", "África");
            DicionarioPaisesEContinentes.Add("Serra Leoa", "África");
            DicionarioPaisesEContinentes.Add("Somália", "África");
            DicionarioPaisesEContinentes.Add("Sudão", "África");
            DicionarioPaisesEContinentes.Add("Sudão do Sul", "África");
            DicionarioPaisesEContinentes.Add("Tanzânia", "África");
            DicionarioPaisesEContinentes.Add("Togo", "África");
            DicionarioPaisesEContinentes.Add("Tunísia", "África");
            DicionarioPaisesEContinentes.Add("Uganda", "África");
            DicionarioPaisesEContinentes.Add("Zâmbia", "África");
            DicionarioPaisesEContinentes.Add("Zimbábue", "África");
            DicionarioPaisesEContinentes.Add("Antiga e Barbuda", "América");
            DicionarioPaisesEContinentes.Add("Argentina", "América");
            DicionarioPaisesEContinentes.Add("Bahamas", "América");
            DicionarioPaisesEContinentes.Add("Barbados", "América");
            DicionarioPaisesEContinentes.Add("Belize", "América");
            DicionarioPaisesEContinentes.Add("Bolívia", "América");
            DicionarioPaisesEContinentes.Add("Brasil", "América");
            DicionarioPaisesEContinentes.Add("Canadá", "América");
            DicionarioPaisesEContinentes.Add("Chile", "América");
            DicionarioPaisesEContinentes.Add("Colômbia", "América");
            DicionarioPaisesEContinentes.Add("Costa Rica", "América");
            DicionarioPaisesEContinentes.Add("Cuba", "América");
            DicionarioPaisesEContinentes.Add("Dominica", "América");
            DicionarioPaisesEContinentes.Add("Equador", "América");
            DicionarioPaisesEContinentes.Add("Estados Unidos", "América");
            DicionarioPaisesEContinentes.Add("Granada", "América");
            DicionarioPaisesEContinentes.Add("Guatemala", "América");
            DicionarioPaisesEContinentes.Add("Guiana", "América");
            DicionarioPaisesEContinentes.Add("Haiti", "América");
            DicionarioPaisesEContinentes.Add("Honduras", "América");
            DicionarioPaisesEContinentes.Add("Jamaica", "América");
            DicionarioPaisesEContinentes.Add("México", "América");
            DicionarioPaisesEContinentes.Add("Nicarágua", "América");
            DicionarioPaisesEContinentes.Add("Panamá", "América");
            DicionarioPaisesEContinentes.Add("Paraguai", "América");
            DicionarioPaisesEContinentes.Add("Peru", "América");
            DicionarioPaisesEContinentes.Add("República Dominicana", "América");
            DicionarioPaisesEContinentes.Add("Salvador", "América");
            DicionarioPaisesEContinentes.Add("Santa Lúcia", "América");
            DicionarioPaisesEContinentes.Add("São Cristóvão e Neves", "América");
            DicionarioPaisesEContinentes.Add("São Vicente e Granadinas", "América");
            DicionarioPaisesEContinentes.Add("Suriname", "América");
            DicionarioPaisesEContinentes.Add("Trindade e Tobago", "América");
            DicionarioPaisesEContinentes.Add("Uruguai", "América");
            DicionarioPaisesEContinentes.Add("Venezuela", "América");
            DicionarioPaisesEContinentes.Add("Afeganistão", "Ásia");
            DicionarioPaisesEContinentes.Add("Arábia Saudita", "Ásia");
            DicionarioPaisesEContinentes.Add("Arménia", "Ásia");
            DicionarioPaisesEContinentes.Add("Azerbaijão", "Ásia");
            DicionarioPaisesEContinentes.Add("Bangladexe", "Ásia");
            DicionarioPaisesEContinentes.Add("Barém", "Ásia");
            DicionarioPaisesEContinentes.Add("Brunei", "Ásia");
            DicionarioPaisesEContinentes.Add("Butão", "Ásia");
            DicionarioPaisesEContinentes.Add("Camboja", "Ásia");
            DicionarioPaisesEContinentes.Add("Catar", "Ásia");
            DicionarioPaisesEContinentes.Add("Cazaquistão", "Ásia");
            DicionarioPaisesEContinentes.Add("China", "Ásia");
            DicionarioPaisesEContinentes.Add("Coreia do Norte", "Ásia");
            DicionarioPaisesEContinentes.Add("Coreia do Sul", "Ásia");
            DicionarioPaisesEContinentes.Add("Cuaite", "Ásia");
            DicionarioPaisesEContinentes.Add("Emirados Árabes Unidos", "Ásia");
            DicionarioPaisesEContinentes.Add("Estado da Palestina", "Ásia");
            DicionarioPaisesEContinentes.Add("Filipinas", "Ásia");
            DicionarioPaisesEContinentes.Add("Geórgia", "Ásia");
            DicionarioPaisesEContinentes.Add("Iémen", "Ásia");
            DicionarioPaisesEContinentes.Add("Índia", "Ásia");
            DicionarioPaisesEContinentes.Add("Indonésia", "Ásia");
            DicionarioPaisesEContinentes.Add("Irão", "Ásia");
            DicionarioPaisesEContinentes.Add("Iraque", "Ásia");
            DicionarioPaisesEContinentes.Add("Israel", "Ásia");
            DicionarioPaisesEContinentes.Add("Japão", "Ásia");
            DicionarioPaisesEContinentes.Add("Jordânia", "Ásia");
            DicionarioPaisesEContinentes.Add("Laus", "Ásia");
            DicionarioPaisesEContinentes.Add("Líbano", "Ásia");
            DicionarioPaisesEContinentes.Add("Malásia", "Ásia");
            DicionarioPaisesEContinentes.Add("Maldivas", "Ásia");
            DicionarioPaisesEContinentes.Add("Mianmar", "Ásia");
            DicionarioPaisesEContinentes.Add("Mongólia", "Ásia");
            DicionarioPaisesEContinentes.Add("Nepal", "Ásia");
            DicionarioPaisesEContinentes.Add("Omã", "Ásia");
            DicionarioPaisesEContinentes.Add("Paquistão", "Ásia");
            DicionarioPaisesEContinentes.Add("Quirguistão", "Ásia");
            DicionarioPaisesEContinentes.Add("Singapura", "Ásia");
            DicionarioPaisesEContinentes.Add("Síria", "Ásia");
            DicionarioPaisesEContinentes.Add("Sri Lanca", "Ásia");
            DicionarioPaisesEContinentes.Add("Tailândia", "Ásia");
            DicionarioPaisesEContinentes.Add("Taiuã", "Ásia");
            DicionarioPaisesEContinentes.Add("Tajiquistão", "Ásia");
            DicionarioPaisesEContinentes.Add("Turcomenistão", "Ásia");
            DicionarioPaisesEContinentes.Add("Turquia", "Ásia");
            DicionarioPaisesEContinentes.Add("Usbequistão", "Ásia");
            DicionarioPaisesEContinentes.Add("Vietname", "Ásia");
            DicionarioPaisesEContinentes.Add("Albânia", "Europa");
            DicionarioPaisesEContinentes.Add("Alemanha", "Europa");
            DicionarioPaisesEContinentes.Add("Andorra", "Europa");
            DicionarioPaisesEContinentes.Add("Áustria", "Europa");
            DicionarioPaisesEContinentes.Add("Bélgica", "Europa");
            DicionarioPaisesEContinentes.Add("Bielorrússia", "Europa");
            DicionarioPaisesEContinentes.Add("Bósnia e Herzegovina", "Europa");
            DicionarioPaisesEContinentes.Add("Bulgária", "Europa");
            DicionarioPaisesEContinentes.Add("Chipre", "Europa");
            DicionarioPaisesEContinentes.Add("Cosovo", "Europa");
            DicionarioPaisesEContinentes.Add("Croácia", "Europa");
            DicionarioPaisesEContinentes.Add("Dinamarca", "Europa");
            DicionarioPaisesEContinentes.Add("Eslováquia", "Europa");
            DicionarioPaisesEContinentes.Add("Eslovénia", "Europa");
            DicionarioPaisesEContinentes.Add("Espanha", "Europa");
            DicionarioPaisesEContinentes.Add("Estónia", "Europa");
            DicionarioPaisesEContinentes.Add("Finlândia", "Europa");
            DicionarioPaisesEContinentes.Add("França", "Europa");
            DicionarioPaisesEContinentes.Add("Grécia", "Europa");
            DicionarioPaisesEContinentes.Add("Hungria", "Europa");
            DicionarioPaisesEContinentes.Add("Irlanda", "Europa");
            DicionarioPaisesEContinentes.Add("Islândia", "Europa");
            DicionarioPaisesEContinentes.Add("Itália", "Europa");
            DicionarioPaisesEContinentes.Add("Letónia", "Europa");
            DicionarioPaisesEContinentes.Add("Listenstaine", "Europa");
            DicionarioPaisesEContinentes.Add("Lituânia", "Europa");
            DicionarioPaisesEContinentes.Add("Luxemburgo", "Europa");
            DicionarioPaisesEContinentes.Add("Macedónia do Norte", "Europa");
            DicionarioPaisesEContinentes.Add("Malta", "Europa");
            DicionarioPaisesEContinentes.Add("Moldávia", "Europa");
            DicionarioPaisesEContinentes.Add("Mónaco", "Europa");
            DicionarioPaisesEContinentes.Add("Montenegro", "Europa");
            DicionarioPaisesEContinentes.Add("Noruega", "Europa");
            DicionarioPaisesEContinentes.Add("Países Baixos", "Europa");
            DicionarioPaisesEContinentes.Add("Polónia", "Europa");
            DicionarioPaisesEContinentes.Add("Portugal", "Europa");
            DicionarioPaisesEContinentes.Add("Reino Unido", "Europa");
            DicionarioPaisesEContinentes.Add("República Checa", "Europa");
            DicionarioPaisesEContinentes.Add("Roménia", "Europa");
            DicionarioPaisesEContinentes.Add("Rússia", "Europa");
            DicionarioPaisesEContinentes.Add("São Marinho", "Europa");
            DicionarioPaisesEContinentes.Add("Sérvia", "Europa");
            DicionarioPaisesEContinentes.Add("Suécia", "Europa");
            DicionarioPaisesEContinentes.Add("Suíça", "Europa");
            DicionarioPaisesEContinentes.Add("Ucrânia", "Europa");
            DicionarioPaisesEContinentes.Add("Vaticano", "Europa");
            DicionarioPaisesEContinentes.Add("Austrália", "Oceania");
            DicionarioPaisesEContinentes.Add("Fiji", "Oceania");
            DicionarioPaisesEContinentes.Add("Ilhas Marechal", "Oceania");
            DicionarioPaisesEContinentes.Add("Micronésia", "Oceania");
            DicionarioPaisesEContinentes.Add("Nauru", "Oceania");
            DicionarioPaisesEContinentes.Add("Nova Zelândia", "Oceania");
            DicionarioPaisesEContinentes.Add("Palau", "Oceania");
            DicionarioPaisesEContinentes.Add("Papua Nova Guiné", "Oceania");
            DicionarioPaisesEContinentes.Add("Quiribáti", "Oceania");
            DicionarioPaisesEContinentes.Add("Salomão", "Oceania");
            DicionarioPaisesEContinentes.Add("Samoa", "Oceania");
            DicionarioPaisesEContinentes.Add("Timor-Leste", "Oceania");
            DicionarioPaisesEContinentes.Add("Tonga", "Oceania");
            DicionarioPaisesEContinentes.Add("Tuvalu", "Oceania");
            DicionarioPaisesEContinentes.Add("Vanuatu", "Oceania");
        }

        public override string ToString()
        {
            var retorno = string.Empty;

            if (DicionarioPaisesEContinentes.ContainsValue(_filtro))
            {
                var dicionarioFiltrado = DicionarioPaisesEContinentes
                                            .Where(pc => pc.Value == _filtro)
                                            .ToDictionary(pc => pc.Key, pc => pc.Value);

                foreach (var item in dicionarioFiltrado)
                {
                    retorno += $"País: {item.Key} - Continente: {item.Value}\n\r";
                }

                return $"Lista de países e continentes filtrados:\n\r{retorno}";
            }

            foreach (var item in DicionarioPaisesEContinentes)
            {
                retorno += $"País: {item.Key} - Continente: {item.Value}\n\r";
            }

            return $"Lista de países e continentes:\n\r{retorno}";
        }
    }
}
