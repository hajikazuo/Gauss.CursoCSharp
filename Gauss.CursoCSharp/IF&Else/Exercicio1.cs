//Crie uma lista de números e verifique se são positivos, negativos ou neutros (zero).  
var numeros = new List<int> { 5, -3, 0, 7, -2, 8, -1 };

foreach (var numero in numeros)
{
    if (numero > 0)
    {
        Console.WriteLine($"Número positivo:{numero}");
    }
    else if (numero < 0)
    {
        Console.WriteLine($"Número negativo:{numero}");
    }
    else
    {
        Console.WriteLine($"Número neutro:{numero}");
    }
}

