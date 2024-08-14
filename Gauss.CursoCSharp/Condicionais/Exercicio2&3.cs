using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1 - Adicionar horas complementares");
        Console.WriteLine("2 - Adicionar nota");
        Console.WriteLine("0 - Sair");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: AddHoras(); break;
            case 2: AddNota(); break;
            default: Menu(); break;
        }
    }

    //Implemente a seguinte função:

    //O usuário precisa digitar as horas complementares.
    //Caso tenha mais de 100 horas, exibe a mensagem: Horas finalizadas.
    //Caso tenha menos, exibe a quantidade que falta para atingir 100 horas.


    static void AddHoras()
    {
        Console.WriteLine("Digite a quantidade de horas: ");
        int horas = int.Parse(Console.ReadLine());
        if (horas >= 100)
        {
            Console.WriteLine("Horas finalizadas.");
        }
        else
        {
            int horasFaltando = 100 - horas;
            Console.WriteLine($"Faltam {horasFaltando} horas para atingir 100 horas.");
        }
        Menu(); //Volta para o menu
    }


    //Implemente a seguinte função:

    //O usuário precisa digitar a nota.
    //Caso a nota seja maior que 7, o usuário passou.
    //Caso a nota seja menor que 7 e maior que 5, o usuário está de exame.
    //Caso a nota seja abaixo de 5 o usuário está reprovado.

    static void AddNota()
    {
        Console.WriteLine("Digite a nota: ");
        int nota = int.Parse(Console.ReadLine());
        if (nota >= 7)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (nota >= 5)
        {
            Console.WriteLine("Aluno está de exame.");
        }
        else
        {
            Console.WriteLine("Aluno reprovado.");
        }
        Menu(); //Volta para o menu
    }
}
