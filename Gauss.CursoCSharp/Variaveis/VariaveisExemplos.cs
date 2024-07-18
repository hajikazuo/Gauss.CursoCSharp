//Exemplos de Operadores aritméticos

var numero1 = 10;
var numero2 = 20;

var soma = numero1 + numero2;
var subtracao = numero1 - numero2;
var multiplicacao = numero1 * numero2;
var divisao = numero1 / numero2;

Console.WriteLine(soma);
Console.WriteLine(subtracao);
Console.WriteLine(multiplicacao);
Console.WriteLine(divisao);

//Exemplos de Variáveis

string nome = "João";
int idade = 20;
double altura = 1.80;
bool vivo = true;

Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine(altura);
Console.WriteLine(vivo);

//Solicitando dados ao usuário

string nome;

Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();

//Conversão de variáveis

string texto1 = "1";
string texto2 = "2";
string resultado = texto1 + texto2;

Console.WriteLine(resultado);

int numero1 = int.Parse(texto1);
int numero2 = int.Parse(texto2);
int resultado = numero1 + numero2;

Console.WriteLine(resultado);

//Concatenação de variáveis 

string nome;
int idade;

Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Bem vindo: " + nome + ", sua idade é: " + idade);
Console.WriteLine($"Bem vindo: {nome}, sua idade é: {idade}");


