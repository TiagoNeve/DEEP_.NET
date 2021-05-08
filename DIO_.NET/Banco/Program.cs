using System;
namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta contaUsuario = new Conta(TipoConta.PessoaFisica, 1000, 3000, "Stuler");
            // Criando um novo objeto chamado minhaConta da classe Conta, logo irá herdar os métodos e atributos.
            // Dessa forma é settar um valor do atributo minhaConta sem estragar a classe, pois o valor só será modificado
            // no objeto.

            Console.WriteLine(contaUsuario.ToString());
        }
    }
}
