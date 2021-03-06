using System;
using System.Collections.Generic;
namespace Banco
{
    class Program : Utilidades
    {
        // Criação das listas de contas na memória:
        static List<Conta> listaContas = new List<Conta>();

        static void Main(string[] args)
        {
            string opcaoUsuario = Utilidades.ObterOpcaoUsuario();

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
                        Utilidades.ForaDoRange();
                        break;
                }

                opcaoUsuario = Utilidades.ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void ListarContas()
        {
            Utilidades.LimparTela();

            Utilidades.Head();

            Console.WriteLine("    Listagem de contas Ativas    ");
            Console.WriteLine();

            if (listaContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada");
                Utilidades.Continue();
                return;
            }

            for (int i = 0; i < listaContas.Count; i++)
            {
                Conta conta = listaContas[i];
                Console.Write($"# {i} - ");
                Console.WriteLine(conta);
            }

            Utilidades.Continue();
        }

        private static void InserirConta()
        {
            Utilidades.LimparTela();

            Utilidades.Head();

            Console.WriteLine("     Inserir nova conta");


            try
            {
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
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Algum erro ocorreu.");
                Console.WriteLine("  -   Verifique se está digitando os dados corretamente");
                Console.WriteLine("  -   1 para conta Física ou 2 para conta Jurídica");
                Console.WriteLine("  -   Os valores de saldo e crédito devem receber números");
                Console.ReadLine();
            }



            Utilidades.Continue();
        }

        private static void Transferir()
        {
            Utilidades.LimparTela();

            Utilidades.Head();

            try
            {
                Console.Write("Digite o número da conta: ");
                int indiceContaOrigem = int.Parse(Console.ReadLine());

                Console.Write("Digite a conta que você quer trasnferir: ");
                int indiceContaDestino = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor da transferência: ");
                double valorTransferencia = double.Parse(Console.ReadLine());

                listaContas[indiceContaOrigem].Transferir(valorTransferencia: valorTransferencia,
                                                          contaDestino: listaContas[indiceContaDestino]);
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Algum erro ocorreu");
                Console.WriteLine("  -  Verifique se o número das contas estão escritas corretamente e são válidas");
                Console.WriteLine("  -  Verifique se o valor da transferência está escrita de forma numérica");
                Console.WriteLine();

            }

            Utilidades.Continue();
        }

        private static void Sacar()
        {
            Utilidades.LimparTela();

            Utilidades.Head();
            try
            {
                Console.Write("Digite o número da conta: ");
                int indiceConta = int.Parse(Console.ReadLine());

                Console.Write("Digite o quanto você que sacar: ");
                double valorSaque = double.Parse(Console.ReadLine());

                listaContas[indiceConta].Sacar(valorSaque);
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Algum erro ocorreu");
                Console.WriteLine("  -  Verifique se o número da conta é válido e se foi digitado corretamente");
                Console.WriteLine("  -  Verifique se o valor a ser sacado é numérico");
                Console.WriteLine();
            }

            Utilidades.Continue();
        }

        private static void Depositar()
        {
            Utilidades.LimparTela();

            Utilidades.Head();

            try
            {
                Console.Write("Digite o número da conta: ");
                int indiceConta = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor a ser depositado: ");
                double valorDeposito = double.Parse(Console.ReadLine());

                listaContas[indiceConta].Depositar(valorDeposito);
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Algum erro ocorreu");
                Console.WriteLine("  -  Verifique se o número da conta está escrito corretamente e é válido");
                Console.WriteLine("  -  Verifique se o valor do depósito é numérico");
            }


            Utilidades.Continue();
        }

    }
}
