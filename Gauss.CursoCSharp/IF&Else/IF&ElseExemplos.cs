//Tela de Login
var usuarios = new List<string> { "João", "Maria", "José", "Ana", "Nilton" };

Console.WriteLine("Bem vindo! Para acessar nosso sistema, por favor, digite seu nome de usuário ");
Console.Write("Login: ");
string nomeUsuario = Console.ReadLine();

if (nomeUsuario == "")
{
    Console.WriteLine("Usuário não informado, por favor, tente novamente.");
}
else if (usuarios.Contains(nomeUsuario))
{
    Console.WriteLine($"Usuário {nomeUsuario} logado com sucesso.");
}
else
{
    Console.WriteLine("Usuário não cadastrado, por favor, verifique o nome e tente novamente.");
}

// Criação de um sistema de login
var usuarios = new List<string> { "João", "Maria", "José", "Ana", "Nilton" };

Console.WriteLine("Bem vindo! Para acessar nosso sistema, por favor, digite seu nome de usuário ");
Console.Write("Login: ");
string nomeUsuario = Console.ReadLine();
bool usuarioLogado = false;

if (usuarios.Contains(nomeUsuario))
{
    Console.WriteLine($"Usuário {nomeUsuario} logado com sucesso.");
    usuarioLogado = true;
}
else if (nomeUsuario == "")
{
    Console.WriteLine("Usuário não informado, por favor, tente novamente.");
}
else
{
    Console.WriteLine("Usuário não cadastrado, por favor, verifique o nome e tente novamente.");
}

// Sistema de caixa eletrônico


if (usuarioLogado)
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("\n 1 - Verificar meu saldo\n 2 - Sacar\n 3 - Depositar \n");
    int opcao = int.Parse(Console.ReadLine());
    decimal saldo = 1000;
    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Seu saldo é de {saldo:C}");
            break;
        case 2:
            Console.Write("Digite o valor que deseja sacar: ");
            var valorSaque = decimal.Parse(Console.ReadLine());
            if (valorSaque > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                saldo -= valorSaque;
                Console.WriteLine($"Saque realizado com sucesso. Seu saldo atual é de {saldo:C}");
            }
            break;
        case 3:
            Console.WriteLine("Digite o valor que deseja depositar: ");
            var valorDeposito = decimal.Parse(Console.ReadLine());
            saldo += valorDeposito;
            Console.WriteLine($"Depósito realizado com sucesso. Seu saldo atual é de {saldo:C}");
            break;
        default:
            Console.WriteLine("Opção inválida, por favor, tente novamente.");
            break;
    }

}
