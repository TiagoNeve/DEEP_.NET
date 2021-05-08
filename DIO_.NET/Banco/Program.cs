using System;
using System.Collections.Generic;
namespace Banco
{
    class Program
    {
        // Criação das listas de contas na memória:
        static List<Conta> listaContas = new List<Conta>();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear(); // Limpa terminal
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void Transferir()
        {
            LimparTela();

            Console.Write("Digite o número da conta");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite a conta que você quer trasnferir");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da transferência");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listaContas[indiceContaOrigem].Transferir(valorTransferencia: valorTransferencia,
                                                      contaDestino: listaContas[indiceContaDestino]);

            Continue();
        }

        private static void Depositar()
        {
            LimparTela();

            Console.Write("Digite o número da conta");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado");
            double valorDeposito = double.Parse(Console.ReadLine());

            listaContas[indiceConta].Depositar(valorDeposito);

            Continue();
        }

        private static void Sacar()
        {
            LimparTela();

            Console.Write("Digite o número da conta");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o quanto você que sacar");
            double valorSaque = double.Parse(Console.ReadLine());

            listaContas[indiceConta].Sacar(valorSaque);

            Continue();
        }

        private static void ListarContas()
        {
            LimparTela();

            Console.WriteLine("Listagem de contas Ativas");
            Console.WriteLine();

            if (listaContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada"); return;
            }

            for (int i = 0; i < listaContas.Count; i++)
            {
                Conta conta = listaContas[i];
                Console.Write($"# {i} - ");
                Console.WriteLine(conta);
            }

            Continue();
        }

        private static void InserirConta()
        {
            LimparTela();

            Console.WriteLine("Inserir nova conta");

            Console.Write("Digite 1 para a conta Física ou 2 para conta Jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                        Nome: entradaNome,
                                        Saldo: entradaSaldo,
                                        Credito: entradaCredito);

            listaContas.Add(novaConta); // Adiciona uma nova conta na lista de contas.

            Continue();
        }

        private static string ObterOpcaoUsuario()
        {
            LimparTela();

            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine("|    Bank ao seu dispor  |");
            Console.WriteLine("|Informa a opção desejada|");
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

        private static void LimparTela()
        {
            Console.Clear();
        }

        private static void Continue()
        {
            Console.WriteLine();
            Console.Write("Digite algo para voltar ao menu");
            Console.ReadLine();
        }

    }
}
