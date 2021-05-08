using System;
namespace Banco
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; } // Os get e os sets informa que o atributo pode ser puchado e retornado

        // Método constructor da classe, quando a classe for instanciada é necessário definir esses valores
        // Os métodos construtores sempre terão o nome da classe.
        public Conta(TipoConta tipoConta, double Saldo, double Credito, string Nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = Saldo;
            this.Credito = Credito;
            this.Nome = Nome;
        }

        // Método sacar, que retorna true se for possível sacar e false se não.
        public bool Sacar(double valorSaque)
        {
            // Validação de saldo suficiente
            if (this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }

            this.Saldo -= valorSaque;

            Console.WriteLine($"Saldo atual da conta de {this.Nome} é {this.Saldo}");

            return true;
        }

        // Método depositar, onde o valor é depositado na conta do usuário
        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;

            Console.WriteLine($"Saldo atual da conta de {this.Nome} é {this.Saldo}");
        }

        // Método transferir, onde o valor será transferido de uma conta para outra conta
        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        // Override método ToString() para atribuir novas funcionalidades a esse método da classe pai Object.
        public override string ToString()
        {
            string retorno = "";
            retorno += $"Tipo conta: {this.TipoConta} | ";
            retorno += $"Nome: {this.Nome} | ";
            retorno += $"Saldo: {this.Saldo} | ";
            retorno += $"Credito: {this.Credito}";
            return retorno;
        }
    }
}