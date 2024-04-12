using System.Reflection.Metadata;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio Conta Corrente, Academia de Programação!\n");

            #region Instaciamento

            PessoaFisica novaPessoa = new PessoaFisica();
            ContaCorrente novaConta = new ContaCorrente();
            novaConta.Titular = novaPessoa;
            novaConta.Extrato = new Historico();
            #endregion

            #region Passagem de valores para novaPessoa

            novaPessoa.nome = "Leonardo";
            novaPessoa.sobrenome = "Rodrigues";
            novaPessoa.cpf = "123.123.123-00";

            #endregion

            #region Passagem de valor para novaConta

            novaConta.numeroIdentificador = 1;
            novaConta.saldo = 1000.50;
            novaConta.limite = 300.50;
            novaConta.status = '0';  // status: 0 = Especial , status:1 = Normal , status:2 = desativada

            #endregion

            novaConta.Sacar(555);
            novaConta.Depositar(999);
            novaConta.Sacar(777);
            novaConta.Sacar(100.50);
            novaConta.Depositar(600);
            novaConta.Sacar(500);
            novaConta.Sacar(789);
            novaConta.Depositar(456);
            novaConta.Sacar(123);


            novaConta.VisualizarSaldo();
            novaConta.DefinirTipo(novaConta.status);




            novaConta.VisualizarTransacoes();
        }
    }
}
