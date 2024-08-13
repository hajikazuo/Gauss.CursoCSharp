//Crie um programa que avalie se o aluno passou no TCC. Para passar, ele precisa cumprir os requisitos abaixo:

//Para passar ele precisa ter 100 horas complementares e nota 7.
//Caso não possua as 100 horas ele não estará formado
//Caso a nota seja menor que 7 ele está de exame.


int horasComplementares = 70;
int notaTCC = 5;

if (horasComplementares >= 100)
{
    if (notaTCC >= 7)
    {
        Console.WriteLine("Parabéns, você está formado!");
    }
    else
    {
        Console.WriteLine("Você está de exame");
    }
}
else
{
    Console.WriteLine("Você ainda não está formado.");
}