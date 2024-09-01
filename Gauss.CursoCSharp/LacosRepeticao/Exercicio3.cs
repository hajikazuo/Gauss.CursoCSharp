//Crie um programa onde o computador sorteie um número de 1 a 10.

//O programa deve exibir uma mensagem perguntando qual o número, para que o usuário digite.
//Caso a resposta esteja errada, o programa deverá exibir a seguinte mensagem: Infelizmente você errou, tente novamente
//Se a resposta estiver correta, o programa finaliza o loop

int numeroSecreto = (new Random().Next(1, 10));
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