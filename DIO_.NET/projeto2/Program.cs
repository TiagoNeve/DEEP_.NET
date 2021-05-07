using System;

namespace projeto2
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            string opcaoUsuario = Cabecalho();

            while (opcaoUsuario.ToUpper() != "X") // Irá executar o loop enquanto o usuário não digita o X ou x.
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");

                        // Tenta passar o input para decimal e atribui o conteudo na variável nota, return bool.
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal");
                        };

                        // Atribuindo o objeto aluno ao array de alunos
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;
                    case "2":
                        foreach (Aluno aluno_ in alunos)
                        {
                            if (!String.IsNullOrEmpty(aluno_.Nome))
                            {
                                Console.WriteLine($"Nome do aluno: {aluno_.Nome}");
                                Console.WriteLine($"Nota do aluno: {aluno_.Nota}");
                                Console.WriteLine("============================");
                            }
                        }
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
                        Console.ReadLine();
                        break;
                    case "3":
                        // TODO: Calcular a média geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                        // Se for digitado uma opção inválida irá retornar um erro de argumento fora do range.
                }

                Console.WriteLine();

                // Chama o cabeçalho novamente.
                opcaoUsuario = Cabecalho();
            }

        }

        private static string Cabecalho()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Lista alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Para sair");
            Console.WriteLine(); // Linha em branco para ficar mais legível

            string opcaoUsuario = Console.ReadLine(); // Vai ler o teclado do usuário e retornar uma string	
            return opcaoUsuario;
        }
    }
}
