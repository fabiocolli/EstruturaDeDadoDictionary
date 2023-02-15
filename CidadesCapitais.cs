using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDictionaryType
{
    public class CidadesCapitais
    {
        private Dictionary<string, string> DicionarioCidadesECapitais { get; set; } = new Dictionary<string, string>();

        private readonly string _filtro;

        public CidadesCapitais(string filtro)
        {
            _filtro = filtro;
        }

        public void PreencheDicionarioDeCidadesECapitais()
        {
            DicionarioCidadesECapitais.Add("África do Sul", "Pretória");
            DicionarioCidadesECapitais.Add("Angola", "Luanda");
            DicionarioCidadesECapitais.Add("Argélia", "Argel");
            DicionarioCidadesECapitais.Add("Benim", "Porto Novo");
            DicionarioCidadesECapitais.Add("Botsuana", "Gaborone");
            DicionarioCidadesECapitais.Add("Burquina Faso", "Uagadugu");
            DicionarioCidadesECapitais.Add("Burúndi", "Bujumbura");
            DicionarioCidadesECapitais.Add("Cabo Verde", "Praia");
            DicionarioCidadesECapitais.Add("Camarões", "Iaundé");
            DicionarioCidadesECapitais.Add("Chade", "Jamena");
            DicionarioCidadesECapitais.Add("Comores", "Moroni");
            DicionarioCidadesECapitais.Add("Congo-Brazzaville", "Brazavile");
            DicionarioCidadesECapitais.Add("Costa do Marfim", "Iamussucro");
            DicionarioCidadesECapitais.Add("Egito", "Cairo");
            DicionarioCidadesECapitais.Add("Eritreia", "Asmara");
            DicionarioCidadesECapitais.Add("Essuatíni", "Lobamba");
            DicionarioCidadesECapitais.Add("Etiópia", "Adis Abeba");
            DicionarioCidadesECapitais.Add("Gabão", "Libreville");
            DicionarioCidadesECapitais.Add("Gâmbia", "Banjul");
            DicionarioCidadesECapitais.Add("Gana", "Acra");
            DicionarioCidadesECapitais.Add("Guiné", "Conacri");
            DicionarioCidadesECapitais.Add("Guiné Equatorial", "Malabo");
            DicionarioCidadesECapitais.Add("Guiné-Bissau", "Bissau");
            DicionarioCidadesECapitais.Add("Jibuti", "Jibuti");
            DicionarioCidadesECapitais.Add("Lesoto", "Maseru");
            DicionarioCidadesECapitais.Add("Libéria", "Monróvia");
            DicionarioCidadesECapitais.Add("Líbia", "Trípoli");
            DicionarioCidadesECapitais.Add("Madagáscar", "Antananarivo");
            DicionarioCidadesECapitais.Add("Maláui", "Lilôngue");
            DicionarioCidadesECapitais.Add("Mali", "Bamaco");
            DicionarioCidadesECapitais.Add("Marrocos", "Rebate");
            DicionarioCidadesECapitais.Add("Maurícia", "Porto Luís");
            DicionarioCidadesECapitais.Add("Mauritânia", "Nuaquechote");
            DicionarioCidadesECapitais.Add("Moçambique", "Maputo");
            DicionarioCidadesECapitais.Add("Namíbia", "Vinduque");
            DicionarioCidadesECapitais.Add("Níger", "Niamei");
            DicionarioCidadesECapitais.Add("Nigéria", "Abuja");
            DicionarioCidadesECapitais.Add("Quénia", "Nairóbi");
            DicionarioCidadesECapitais.Add("República Centro-Africana", "Bangui");
            DicionarioCidadesECapitais.Add("República Democrática do Congo", "Quinxassa");
            DicionarioCidadesECapitais.Add("Ruanda", "Quigali");
            DicionarioCidadesECapitais.Add("São Tomé e Príncipe", "São Tomé");
            DicionarioCidadesECapitais.Add("Seicheles", "Vitória");
            DicionarioCidadesECapitais.Add("Senegal", "Dacar");
            DicionarioCidadesECapitais.Add("Serra Leoa", "Freetown");
            DicionarioCidadesECapitais.Add("Somália", "Mogadíscio");
            DicionarioCidadesECapitais.Add("Sudão", "Cartum");
            DicionarioCidadesECapitais.Add("Sudão do Sul", "Juba");
            DicionarioCidadesECapitais.Add("Tanzânia", "Dodoma");
            DicionarioCidadesECapitais.Add("Togo", "Lomé");
            DicionarioCidadesECapitais.Add("Tunísia", "Tunes");
            DicionarioCidadesECapitais.Add("Uganda", "Campala");
            DicionarioCidadesECapitais.Add("Zâmbia", "Lusaca");
            DicionarioCidadesECapitais.Add("Zimbábue", "Harare");
            DicionarioCidadesECapitais.Add("Antiga e Barbuda", "São João");
            DicionarioCidadesECapitais.Add("Argentina", "Buenos Aires");
            DicionarioCidadesECapitais.Add("Bahamas", "Nassau");
            DicionarioCidadesECapitais.Add("Barbados", "Bridgetown");
            DicionarioCidadesECapitais.Add("Belize", "Belmopã");
            DicionarioCidadesECapitais.Add("Bolívia", "Sucre");
            DicionarioCidadesECapitais.Add("Brasil", "Brasília");
            DicionarioCidadesECapitais.Add("Canadá", "Otava");
            DicionarioCidadesECapitais.Add("Chile", "Santiago");
            DicionarioCidadesECapitais.Add("Colômbia", "Bogotá");
            DicionarioCidadesECapitais.Add("Costa Rica", "São José");
            DicionarioCidadesECapitais.Add("Cuba", "Havana");
            DicionarioCidadesECapitais.Add("Dominica", "Roseau");
            DicionarioCidadesECapitais.Add("Equador", "Quito");
            DicionarioCidadesECapitais.Add("Estados Unidos", "Washington, D.C.");
            DicionarioCidadesECapitais.Add("Granada", "São Jorge");
            DicionarioCidadesECapitais.Add("Guatemala", "Cidade da Guatemala");
            DicionarioCidadesECapitais.Add("Guiana", "Georgetown");
            DicionarioCidadesECapitais.Add("Haiti", "Porto Príncipe");
            DicionarioCidadesECapitais.Add("Honduras", "Tegucigalpa");
            DicionarioCidadesECapitais.Add("Jamaica", "Kingston");
            DicionarioCidadesECapitais.Add("México", "Cidade do México");
            DicionarioCidadesECapitais.Add("Nicarágua", "Manágua");
            DicionarioCidadesECapitais.Add("Panamá", "Cidade do Panamá");
            DicionarioCidadesECapitais.Add("Paraguai", "Assunção");
            DicionarioCidadesECapitais.Add("Peru", "Lima");
            DicionarioCidadesECapitais.Add("República Dominicana", "São Domingos");
            DicionarioCidadesECapitais.Add("Salvador", "São Salvador");
            DicionarioCidadesECapitais.Add("Santa Lúcia", "Castries");
            DicionarioCidadesECapitais.Add("São Cristóvão e Neves", "Basseterre");
            DicionarioCidadesECapitais.Add("São Vicente e Granadinas", "Kingstown");
            DicionarioCidadesECapitais.Add("Suriname", "Paramaribo");
            DicionarioCidadesECapitais.Add("Trindade e Tobago", "Porto de Espanha");
            DicionarioCidadesECapitais.Add("Uruguai", "Montevideu");
            DicionarioCidadesECapitais.Add("Venezuela", "Caracas");
            DicionarioCidadesECapitais.Add("Afeganistão", "Cabul");
            DicionarioCidadesECapitais.Add("Arábia Saudita", "Riade");
            DicionarioCidadesECapitais.Add("Arménia", "Erevã");
            DicionarioCidadesECapitais.Add("Azerbaijão", "Bacu");
            DicionarioCidadesECapitais.Add("Bangladexe", "Daca");
            DicionarioCidadesECapitais.Add("Barém", "Manama");
            DicionarioCidadesECapitais.Add("Brunei", "Bandar Seri Begauã");
            DicionarioCidadesECapitais.Add("Butão", "Timbu");
            DicionarioCidadesECapitais.Add("Camboja", "Pnom Pene");
            DicionarioCidadesECapitais.Add("Catar", "Doa");
            DicionarioCidadesECapitais.Add("Cazaquistão", "Astana");
            DicionarioCidadesECapitais.Add("China", "Pequim");
            DicionarioCidadesECapitais.Add("Coreia do Norte", "Pionguiangue");
            DicionarioCidadesECapitais.Add("Coreia do Sul", "Seul");
            DicionarioCidadesECapitais.Add("Cuaite", "Cidade do Cuaite");
            DicionarioCidadesECapitais.Add("Emirados Árabes Unidos", "Abu Dabi");
            DicionarioCidadesECapitais.Add("Estado da Palestina", "Jerusalém Oriental");
            DicionarioCidadesECapitais.Add("Filipinas", "Manila");
            DicionarioCidadesECapitais.Add("Geórgia", "Tebilíssi");
            DicionarioCidadesECapitais.Add("Iémen", "Saná");
            DicionarioCidadesECapitais.Add("Índia", "Nova Déli");
            DicionarioCidadesECapitais.Add("Indonésia", "Jacarta");
            DicionarioCidadesECapitais.Add("Irão", "Teerão");
            DicionarioCidadesECapitais.Add("Iraque", "Bagdade");
            DicionarioCidadesECapitais.Add("Israel", "Jerusalém");
            DicionarioCidadesECapitais.Add("Japão", "Tóquio");
            DicionarioCidadesECapitais.Add("Jordânia", "Amã");
            DicionarioCidadesECapitais.Add("Laus", "Vienciana");
            DicionarioCidadesECapitais.Add("Líbano", "Beirute");
            DicionarioCidadesECapitais.Add("Malásia", "Cuala Lumpur");
            DicionarioCidadesECapitais.Add("Maldivas", "Malé");
            DicionarioCidadesECapitais.Add("Mianmar", "Nepiedó");
            DicionarioCidadesECapitais.Add("Mongólia", "Ulã Bator");
            DicionarioCidadesECapitais.Add("Nepal", "Catmandu");
            DicionarioCidadesECapitais.Add("Omã", "Mascate");
            DicionarioCidadesECapitais.Add("Paquistão", "Islamabade");
            DicionarioCidadesECapitais.Add("Quirguistão", "Bisqueque");
            DicionarioCidadesECapitais.Add("Singapura", "Singapura");
            DicionarioCidadesECapitais.Add("Síria", "Damasco");
            DicionarioCidadesECapitais.Add("Sri Lanca", "Sri Jaiavardenapura-Cota");
            DicionarioCidadesECapitais.Add("Tailândia", "Banguecoque");
            DicionarioCidadesECapitais.Add("Taiuã", "Taipé");
            DicionarioCidadesECapitais.Add("Tajiquistão", "Duchambé");
            DicionarioCidadesECapitais.Add("Turcomenistão", "Asgabate");
            DicionarioCidadesECapitais.Add("Turquia", "Ancara");
            DicionarioCidadesECapitais.Add("Usbequistão", "Tasquente");
            DicionarioCidadesECapitais.Add("Vietname", "Hanói");
            DicionarioCidadesECapitais.Add("Albânia", "Tirana");
            DicionarioCidadesECapitais.Add("Alemanha", "Berlim");
            DicionarioCidadesECapitais.Add("Andorra", "Andorra-a-Velha");
            DicionarioCidadesECapitais.Add("Áustria", "Viena");
            DicionarioCidadesECapitais.Add("Bélgica", "Bruxelas");
            DicionarioCidadesECapitais.Add("Bielorrússia", "Minsque");
            DicionarioCidadesECapitais.Add("Bósnia e Herzegovina", "Saraievo");
            DicionarioCidadesECapitais.Add("Bulgária", "Sófia");
            DicionarioCidadesECapitais.Add("Chipre", "Nicósia");
            DicionarioCidadesECapitais.Add("Cosovo", "Pristina");
            DicionarioCidadesECapitais.Add("Croácia", "Zagrebe");
            DicionarioCidadesECapitais.Add("Dinamarca", "Copenhaga");
            DicionarioCidadesECapitais.Add("Eslováquia", "Bratislava");
            DicionarioCidadesECapitais.Add("Eslovénia", "Liubliana");
            DicionarioCidadesECapitais.Add("Espanha", "Madrid");
            DicionarioCidadesECapitais.Add("Estónia", "Talim");
            DicionarioCidadesECapitais.Add("Finlândia", "Helsínquia");
            DicionarioCidadesECapitais.Add("França", "Paris");
            DicionarioCidadesECapitais.Add("Grécia", "Atenas");
            DicionarioCidadesECapitais.Add("Hungria", "Budapeste");
            DicionarioCidadesECapitais.Add("Irlanda", "Dublim");
            DicionarioCidadesECapitais.Add("Islândia", "Reiquiavique");
            DicionarioCidadesECapitais.Add("Itália", "Roma");
            DicionarioCidadesECapitais.Add("Letónia", "Riga");
            DicionarioCidadesECapitais.Add("Listenstaine", "Vaduz");
            DicionarioCidadesECapitais.Add("Lituânia", "Vílnius");
            DicionarioCidadesECapitais.Add("Luxemburgo", "Luxemburgo");
            DicionarioCidadesECapitais.Add("Macedónia do Norte", "Escópia");
            DicionarioCidadesECapitais.Add("Malta", "Valeta");
            DicionarioCidadesECapitais.Add("Moldávia", "Quixinau");
            DicionarioCidadesECapitais.Add("Mónaco", "Mónaco");
            DicionarioCidadesECapitais.Add("Montenegro", "Podgoritsa");
            DicionarioCidadesECapitais.Add("Noruega", "Oslo");
            DicionarioCidadesECapitais.Add("Países Baixos", "Amesterdão");
            DicionarioCidadesECapitais.Add("Polónia", "Varsóvia");
            DicionarioCidadesECapitais.Add("Portugal", "Lisboa");
            DicionarioCidadesECapitais.Add("Reino Unido", "Londres");
            DicionarioCidadesECapitais.Add("República Checa", "Praga");
            DicionarioCidadesECapitais.Add("Roménia", "Bucareste");
            DicionarioCidadesECapitais.Add("Rússia", "Moscovo");
            DicionarioCidadesECapitais.Add("São Marinho", "São Marinho");
            DicionarioCidadesECapitais.Add("Sérvia", "Belgrado");
            DicionarioCidadesECapitais.Add("Suécia", "Estocolmo");
            DicionarioCidadesECapitais.Add("Suíça", "Berna");
            DicionarioCidadesECapitais.Add("Ucrânia", "Quieve");
            DicionarioCidadesECapitais.Add("Vaticano", "Vaticano");
            DicionarioCidadesECapitais.Add("Austrália", "Camberra");
            DicionarioCidadesECapitais.Add("Fiji", "Suva");
            DicionarioCidadesECapitais.Add("Ilhas Marechal", "Majuro");
            DicionarioCidadesECapitais.Add("Micronésia", "Paliquir");
            DicionarioCidadesECapitais.Add("Nauru", "Iarém");
            DicionarioCidadesECapitais.Add("Nova Zelândia", "Wellington");
            DicionarioCidadesECapitais.Add("Palau", "Ngerulmud");
            DicionarioCidadesECapitais.Add("Papua Nova Guiné", "Porto Moresby");
            DicionarioCidadesECapitais.Add("Quiribáti", "Taraua do Sul");
            DicionarioCidadesECapitais.Add("Salomão", "Honiara");
            DicionarioCidadesECapitais.Add("Samoa", "Apia");
            DicionarioCidadesECapitais.Add("Timor-Leste", "Díli");
            DicionarioCidadesECapitais.Add("Tonga", "Nucualofa");
            DicionarioCidadesECapitais.Add("Tuvalu", "Funafuti");
            DicionarioCidadesECapitais.Add("Vanuatu", "Porto Vila");
        }

        public override string ToString()
        {
            var retorno = string.Empty;
            if (DicionarioCidadesECapitais.ContainsValue(_filtro))
            {
                var dicionarioFiltrado = DicionarioCidadesECapitais
                                            .Where(cc => cc.Value == _filtro)
                                            .ToDictionary(cc => cc.Key, cc => cc.Value);

                foreach (var item in dicionarioFiltrado)
                {
                    retorno += $"Cidade: {item.Key} - Capital: {item.Value}\n\r";
                }

                return $"Lista de países e continentes filtrados:\n\r{retorno}";
            }

            foreach (var item in DicionarioCidadesECapitais)
            {
                retorno += $"Cidade: {item.Key} - Capital: {item.Value}\n\r";
            }
            return $"Lista de cidades e capitais:\n\r{retorno}"; ;
        }
    }
}
