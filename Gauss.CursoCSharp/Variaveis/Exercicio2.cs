int num1;
int num2;

Console.WriteLine("Digite o primeiro número: ");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
num2 = int.Parse(Console.ReadLine());

var resultado = num1 + num2;    

Console.WriteLine($"O resultado da soma é: {resultado}");