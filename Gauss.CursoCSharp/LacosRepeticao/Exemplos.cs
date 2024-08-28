//Exemplo 1
var contador = 0;
string resposta;
do
{
    Console.WriteLine(contador++);
    Console.Write("Deseja continuar? (S/N): ");
    resposta = Console.ReadLine().ToUpper();
}
while (resposta == "S");

//Exemplo 2
string senha;

do
{
    Console.WriteLine("Crie uma senha com pelo menos 8 caracteres:");
    senha = Console.ReadLine();

    if (senha.Length < 8)
    {
        Console.WriteLine("A senha deve ter pelo menos 8 caracteres.");
    }
}
while (senha.Length < 8);

Console.WriteLine("Senha criada com sucesso!");