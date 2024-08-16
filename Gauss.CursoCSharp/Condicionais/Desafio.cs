public class Avaliacao
{
    public int Bimestre { get; set; }
    public int Nota { get; set; }
    public bool Recuperacao { get; set; }
}

public class Program
{
    public static void Main()
    {
        var avaliacoes = new List<Avaliacao>
        {
            new Avaliacao { Bimestre = 1, Nota = 10, Recuperacao = false },
            new Avaliacao { Bimestre = 1, Nota = 10, Recuperacao = false },
            new Avaliacao { Bimestre = 1, Nota = 6, Recuperacao = true },
            new Avaliacao { Bimestre = 2, Nota = 6, Recuperacao = false },
            new Avaliacao { Bimestre = 2, Nota = 3, Recuperacao = false },
            new Avaliacao { Bimestre = 2, Nota = 5, Recuperacao = true }
        };

        // Avaliações SOMENTE do bimestre 1.
        var avaliacoesPorBimestre = avaliacoes.Where(x => x.Bimestre == 1).ToList();

        // Vamos filtrar por avaliações SÓ do segundo bimestre.
        if (avaliacoesPorBimestre.Any())
        {
            var mediaDoBimestre = avaliacoesPorBimestre
                .Where(avaliacao => !avaliacao.Recuperacao)
                .Average(avaliacao => avaliacao.Nota);

            mediaDoBimestre = Math.Round(mediaDoBimestre);

            // Definir agora o resultado do aluno
            if (mediaDoBimestre >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (mediaDoBimestre == 6)
            {
                Console.WriteLine("Exame");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}