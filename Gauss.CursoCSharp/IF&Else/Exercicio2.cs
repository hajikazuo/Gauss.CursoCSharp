Console.WriteLine("Digite a nota do produto (1 a 5): ");
int nota = Convert.ToInt32(Console.ReadLine());

string avaliacao;

switch (nota)
{
    case 1:
        avaliacao = "Muito ruim";
        break;
    case 2:
        avaliacao = "Ruim";
        break;
    case 3:
        avaliacao = "Regular";
        break;
    case 4:
        avaliacao = "Bom";
        break;
    case 5:
        avaliacao = "Excelente";
        break;
    default:
        avaliacao = "Nota inválida";
        break;
}

Console.WriteLine($"Avaliação: {avaliacao}");