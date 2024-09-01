//Criar um programa que receba um número do usuário, e crie um triangulo retângulo.
//Cada linha do triângulo deve conter números em sequência.


Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"\n");

for (int i = 1; i <= numero; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}