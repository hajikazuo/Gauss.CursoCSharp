//Crie uma lista de 5 frutas e uma lista de quantidades, e exiba as frutas ao lado da quantidade.
//Ex: Maçã - 12

var frutas = new List<string> { "Banana", "Melão", "Abacaxi", "Limão", "Goiaba" };
var quantidades = new List<int> { 10, 12, 5, 3, 1 };

int index = 0;
foreach (var fruta in frutas)
{
    Console.WriteLine($"{index + 1}. {fruta} - {quantidades[index]}");
    index++;
}

//Adicione uma forma de o usuário selecionar uma fruta e uma quantidade, e altera-los.
//Após alterar, exiba a lista atualizada.


Console.Write("Digite o número da fruta que deseja alterar: ");
int escolha = int.Parse(Console.ReadLine()) - 1;

Console.Write("Digite a nova quantidade: ");
int novaQuantidade = int.Parse(Console.ReadLine());

quantidades[escolha] = novaQuantidade;

Console.WriteLine("\nLista atualizada de frutas e quantidades:");
index = 0;
foreach (var fruta in frutas)
{
    Console.WriteLine($"{index + 1}. {fruta} - {quantidades[index]}");
    index++;
}