int temperatura = 0;

while (temperatura < 20)
{
    Console.WriteLine($"Temperatura atual: {temperatura}°C");
    temperatura++;

    if (temperatura >= 20)
    {
        Console.WriteLine("Temperatura ideal atingida.");
    }
}