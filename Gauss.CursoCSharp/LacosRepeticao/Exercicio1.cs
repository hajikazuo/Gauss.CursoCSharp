//Crie a tabuada do 1 ao 10, separe cada tabuada com um texto.

for (int numero = 1; numero <= 10; numero++)
{
    Console.WriteLine($"\nTabuada do {numero}:\n");

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}

//Fazer a tabuada ao contrário.

for (int numero = 1; numero <= 10; numero++)
{
    Console.WriteLine($"\nTabuada do {numero}:\n");

    for (int i = 10; i >= 0; i--)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}