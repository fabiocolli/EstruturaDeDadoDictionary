// See https://aka.ms/new-console-template for more information
using IDictionaryType;

Console.WriteLine("Hoje vamos aprender como trabalhar com Dictionary<TKey, TValue>");

Console.WriteLine("Usando o Dicionário de número");
var numero = new Numero(34);
numero.CriarDicionarioDeNumeros();
Console.WriteLine(numero.ToString());

Console.WriteLine("Imprimindo lista de Países e Continentes filtrado por continente");
var paisesContinentes = new PaisesContinentes("Europa");
paisesContinentes.PreencherDicionarioDePaisesEContinentes();
Console.WriteLine(paisesContinentes.ToString());

Console.WriteLine("Imprimindo lista de Países e Continentes sem filtragem");
var paisesContinentesSemFiltrar = new PaisesContinentes(string.Empty);
paisesContinentesSemFiltrar.PreencherDicionarioDePaisesEContinentes();
Console.WriteLine(paisesContinentesSemFiltrar.ToString());

Console.WriteLine("Imprimindo lista de Cidade e Capital filtrado por cidade");
var cidadeCapital = new CidadesCapitais("Brasília");
cidadeCapital.PreencheDicionarioDeCidadesECapitais();
Console.WriteLine(cidadeCapital.ToString());

Console.WriteLine("Imprimindo lista de Cidade e Capital sem filtragem");
var cidadeCapitalSemFiltrar = new CidadesCapitais(string.Empty);
cidadeCapitalSemFiltrar.PreencheDicionarioDeCidadesECapitais();
Console.WriteLine(cidadeCapitalSemFiltrar.ToString());

var calculadora = new Calculadora();
calculadora.Faca("+", 12, 23);
calculadora.Faca("*", 33, 123);

