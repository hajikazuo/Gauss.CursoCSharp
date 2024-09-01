//Crie um programa que simula o aumento da temperatura de um ambiente de 0°C até 20°C.

//Deve exibir a temperatura subindo de 1 em 1 graus.

//Quando atingir 20°C, o loop deve parar e exibir "Temperatura ideal atingida."


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