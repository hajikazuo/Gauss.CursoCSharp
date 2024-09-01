//Crie um programa que tenta realizar uma operação até que seja bem-sucedida ou até alcançar um número máximo de tentativas.

//O programa deve permitir até três tentativas para realizar a operação com sucesso. 
//Utilize o código fornecido como base para verificar se a operação foi bem-sucedida.
// Se o sucesso não for alcançado após as três tentativas, o programa deve exibir a mensagem: "Conta bloqueada, seu dinheiro agora é meu!"

int tentativas = 0;
const int MAX_TENTATIVAS = 3;
bool sucesso = false;

while (!sucesso && tentativas < MAX_TENTATIVAS)
{
    Console.WriteLine($"Tentativa {tentativas + 1}:");
    sucesso = new Random().Next(0, 2) == 1;
    tentativas++;

    if (sucesso)
    {
        Console.WriteLine("Operação bem-sucedida!");
    }
    else
    {
        Console.WriteLine("Falha. Tentando novamente...");
    }
}

if (!sucesso)
{
    Console.WriteLine("Sua conta foi bloqueada. Seu dinheiro agora é meu.");
}