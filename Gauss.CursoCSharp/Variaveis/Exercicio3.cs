string nome;
double salario;

Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Digite seu salário: ");
salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Olá {nome}, seu salário atua é de: {salario}");