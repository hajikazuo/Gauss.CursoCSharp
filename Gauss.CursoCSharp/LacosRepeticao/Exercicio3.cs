﻿Random random = new Random();

int numeroSecreto = random.Next(1, 10);
int palpite;

do
{
    Console.WriteLine("Tente adivinhar o número secreto (entre 1 e 10 ):");
    palpite = int.Parse(Console.ReadLine());

    if (palpite == numeroSecreto)
    {
        Console.WriteLine("Parabéns!! Seu palpite estava correto");
    }
}
while (palpite != numeroSecreto);

Console.WriteLine("Infelizmente você errou, tente novamente");