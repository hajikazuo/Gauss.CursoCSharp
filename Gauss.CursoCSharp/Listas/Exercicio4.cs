//Crie uma lista com o nome de três alunos, e uma lista com três notas vazias.
//Solicite ao usuário que digite a nota de cada aluno e exiba a nota junto com o nome.

var alunos = new List<string> { "Alice", "Bob", "Carol" };
var notas = new List<double> { 0.0, 0.0, 0.0 };

Console.WriteLine($"Digite a nota de {alunos[0]}: ");
notas[0] = double.Parse(Console.ReadLine());

Console.WriteLine($"Digite a nota de {alunos[1]}: ");
notas[1] = double.Parse(Console.ReadLine());

Console.WriteLine($"Digite a nota de {alunos[2]}: ");
notas[2] = double.Parse(Console.ReadLine());

Console.WriteLine("\nLista de alunos e suas notas:");
int index = 0;
foreach (var aluno in alunos)
{
    Console.WriteLine($"{aluno}: {notas[index]}");
    index++;
}