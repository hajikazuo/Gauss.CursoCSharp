string nome;
int anoNascimento;
int anoAtual = 2024;

Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Digite o ano de nascimento: ");
anoNascimento = Convert.ToInt32(Console.ReadLine());  

int idade = anoAtual - anoNascimento;   

Console.WriteLine($"Olá {nome}! Sua idade é aproximadamente: {idade} anos.");