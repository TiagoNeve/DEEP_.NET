using System;

namespace Banco
{
    public interface Utilidades
    {

        protected static string ObterOpcaoUsuario()
        {
            LimparTela();

            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine("|    Bank ao seu dispor  |");
            Console.WriteLine("|Informe a opção desejada|");
            Console.WriteLine("==========================");
            Console.WriteLine("| 1 - Listar contas      |");
            Console.WriteLine("| 2 - Inserir nova conta |");
            Console.WriteLine("| 3 - Transferir         |");
            Console.WriteLine("| 4 - Sacar              |");
            Console.WriteLine("| 5 - Depositar          |");
            Console.WriteLine("| C - Limpar a tela      |");
            Console.WriteLine("| X - Sair               |");
            Console.WriteLine("==========================");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        protected static void LimparTela()
        {
            Console.Clear();
        }

        protected static void Continue()
        {
            Console.WriteLine();
            Console.Write("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }

        protected static void Head()
        {
            Console.WriteLine("          =======================");
            Console.WriteLine("          |        BANK         |");
            Console.WriteLine("          =======================");
        }

        protected static void ForaDoRange()
        {
            Console.WriteLine("Digite alguma opção válida! (Aperte enter para tentar novamente)");
            Console.ReadLine();
        }
    }
}