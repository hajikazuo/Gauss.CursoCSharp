Console.WriteLine("Digite a nota do aluno");
int nota = int.Parse(Console.ReadLine());


if (nota >= 90)
{
    Console.WriteLine("Excelente");
}
else if (nota >= 70)
{
    Console.WriteLine("Bom");
}
else if (nota >= 50)
{
    Console.WriteLine("Regular");
}
else
{
    Console.WriteLine("Insuficiente");
}