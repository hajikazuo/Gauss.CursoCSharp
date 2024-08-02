//Carrinho de compras

var produtos = new List<string>
{
    "1: Monster - R$ 13.75",
    "2: Red Bull - R$ 9.99",
};

Console.WriteLine("Produtos disponíveis:");
foreach (var produto in produtos)
{
    Console.WriteLine(produto);
}

var carrinho = new List<string>();

Console.WriteLine("\nDigite o número do produto que deseja comprar:");

int numeroProduto = int.Parse(Console.ReadLine());
string produtoSelecionado = produtos[numeroProduto - 1];

carrinho.Add(produtoSelecionado);

Console.WriteLine("\nProdutos no carrinho:");
foreach (var produto in carrinho)
{
    Console.WriteLine(produto);
}

// Exibindo duas listas

var produtos = new List<string>
        {
            "1: Monster",
            "2: Red Bull",
        };

var precos = new List<double>
        {
            13.75,
            9.99
        };

int index = 0;

Console.WriteLine("\nProdutos disponíveis:");
foreach (var produto in produtos)
{
    Console.WriteLine($"{produto} - {precos[index]:C}");
}