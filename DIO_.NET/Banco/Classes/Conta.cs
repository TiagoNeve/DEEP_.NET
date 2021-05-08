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
    }
}