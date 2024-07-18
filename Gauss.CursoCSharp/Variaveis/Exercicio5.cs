double nota1;
double nota2;
double nota3;   
int peso1 = 2;
int peso2 = 3;
int peso3 = 5;

Console.WriteLine("Digite a primeira nota: ");  
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());   

Console.WriteLine("Digite a terceira nota: ");
nota3 = Convert.ToDouble(Console.ReadLine());

double somaPesos = peso1 + peso2 + peso3;   
double mediaPonderada = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / somaPesos;

Console.WriteLine($"A média ponderada é: {mediaPonderada}");