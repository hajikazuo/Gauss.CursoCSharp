//Crie uma lista de produtos, que inicie vazia, e adicione três itens digitados pelo usuário. 
//Adicione três novos produtos na lista e exiba todos os produtos.


var produtos = new List<string>();

Console.WriteLine("Digite o nome do produto: ");
produtos.Add(Console.ReadLine());

Console.WriteLine("Digite o nome do produto: ");
produtos.Add(Console.ReadLine());

Console.WriteLine("Digite o nome do produto: ");
produtos.Add(Console.ReadLine());

produtos.Add("Computador");
produtos.Add("Celular");
produtos.Add("Tablet");

Console.WriteLine("\nLista de produtos: ");
foreach (var produto in produtos)
{
    Console.WriteLine(produto);
}

//Adicione uma lista de compras e inclua o produto que o usuário desejar.
//Obs, a lista de produtos deverá conter um id(número do produto) e o nome do produto

int index = 1;

Console.WriteLine("\nLista de produtos: ");
foreach (var produto in produtos)
{
    Console.WriteLine($"{index} - {produto}");
    index++;
}

var compras = new List<string>();

Console.WriteLine("\nDigite o número do produto que deseja comprar: ");
int escolha = int.Parse(Console.ReadLine());

string produtoEscolhido = produtos[escolha - 1];
compras.Add(produtoEscolhido);

Console.WriteLine("\nLista de compras: ");
foreach (var compra in compras)
{
    Console.WriteLine(compra);
}