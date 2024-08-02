//Crie uma lista de números inteiros vazia e adicione os números de 1 a 5.
//Em seguida, exiba todos os números.

var numeros = new List<int>();
numeros.Add(1);
numeros.Add(2);
numeros.Add(3);
numeros.Add(4);
numeros.Add(5);

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

//Adicione os números de 6 a 10 nas posições impares da lista, e exiba todos os números.
// Ex: 1, 10, 2, 9, 3, 8, 4, 7, 5, 6

numeros.Insert(1, 10);
numeros.Insert(3, 9);
numeros.Insert(5, 8);
numeros.Insert(7, 7);
numeros.Insert(9, 6);

Console.WriteLine("\nNúmeros: ");
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}