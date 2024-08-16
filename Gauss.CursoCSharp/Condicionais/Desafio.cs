//Crie um programa em C# que calcule a média das notas de um aluno no primeiro bimestre, excluindo as notas de recuperação, e determine o resultado final do aluno (Aprovado, Exame ou Reprovado).
//Determinar o resultado final do aluno com base na média calculada:
//Aprovado: Se a média for maior ou igual a 7.
//Exame: Se a média for igual a 6.
//Reprovado: Se a média for menor que 6.


namespace ConsoleApp1
{
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

            //Versão utilizando LINQ

            var avaliacoesPorBimestre = avaliacoes.Where(x => x.Bimestre == 1).ToList();

            if (avaliacoesPorBimestre.Any())
            {
                var mediaDoBimestre = avaliacoesPorBimestre
                    .Where(avaliacao => !avaliacao.Recuperacao)
                    .Average(avaliacao => avaliacao.Nota);

                mediaDoBimestre = Math.Round(mediaDoBimestre);

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

            //Versão utilizando if 

            int bimestreDesejado = 1;
            double somaNotas = 0;
            int quantidadeNotas = 0;

            foreach (var avaliacao in avaliacoes)
            {
                if (avaliacao.Bimestre == bimestreDesejado && !avaliacao.Recuperacao)
                {
                    somaNotas += avaliacao.Nota;
                    quantidadeNotas++;
                }
            }

            if (quantidadeNotas > 0)
            {
                var mediaDoBimestre = Math.Round(somaNotas / quantidadeNotas);

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
            else
            {
                Console.WriteLine("Nenhuma nota encontrada para o bimestre especificado.");
            }
        }
    }
}
