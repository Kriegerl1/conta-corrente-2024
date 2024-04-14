using System.Reflection.Metadata;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio Conta Corrente, Academia de Programação!\n");

            #region Instaciamento
            #region pessoa1
            PessoaFisica novaPessoa = new PessoaFisica("106.955.068-97", "Leonardo", "Rodrigues");
            ContaCorrente novaConta = new ContaCorrente(1, 1000.5, 300.5, '0');
            novaConta.Titular = novaPessoa;
            novaConta.Extrato = new Historico();
            #endregion
            #region pessoa2
            PessoaFisica novaPessoa2 = new PessoaFisica("123.123.123-01", "Giovanna", "Martins");
            ContaCorrente novaConta2 = new ContaCorrente(2, 1000, 300, '1');
            novaConta2.Titular = novaPessoa2;
            novaConta2.Extrato = new Historico();
            #endregion
            #region pessoa3

            PessoaFisica novaPessoa3 = new PessoaFisica(ObterValor<string>("CPF:"),ObterValor<string>("Nome:"),ObterValor<string>("Sobrenome:"));
            ContaCorrente novaConta3 = new ContaCorrente(ObterValor<int>("ID:"),ObterValor<double>("Saldo:"),ObterValor<double>("Limite:"),ObterValor<char>("Tipo de conta:"));
            novaConta3.Titular = novaPessoa3;
            novaConta3.Extrato = new Historico();
            #endregion
            #endregion
            #region Passagem de valores para novaPessoa

            //novaPessoa.nome = "Leonardo";
            //novaPessoa.sobrenome = "Rodrigues";
            //novaPessoa.cpf = "123.123.123-00";

            #endregion
            #region Passagem de valores para novaPessoa2

            //novaPessoa2.nome = "Giovanna";
            //novaPessoa2.sobrenome = "Martins";
            //novaPessoa2.cpf = "123.123.123-01";

            #endregion
            #region Passagem de valor para novaConta

            //novaConta.numeroIdentificador = 1;
            //novaConta.saldo = 1000.50;
            //novaConta.limite = 300.50;
            //novaConta.status = '0';  // status: 0 = Especial , status:1 = Normal , status:2 = desativada

            #endregion
            #region Passagem de valor para novaConta2

            //novaConta2.numeroIdentificador = 2;
            //novaConta2.saldo = 1000.50;
            //novaConta2.limite = 300.50;
            //novaConta2.status = '1';  // status: 0 = Especial , status:1 = Normal , status:2 = desativada

            #endregion

            #region Atividades novaConta
            novaConta.Sacar(100.5);
            novaConta.Depositar(1100);
            novaConta.Sacar(1000);
            novaConta.Depositar(455);
            novaConta.Sacar(55);
            novaConta.VisualizarSaldo();
            novaConta.DefinirTipo(novaConta.status);
            novaConta.VisualizarTransacoes();
            novaConta.Tranferir(399.5, novaConta2);
            #endregion
            #region Atividades novaConta2

            novaConta2.VisualizarSaldo();
            novaConta2.DefinirTipo(novaConta2.status);
            novaConta2.VisualizarTransacoes();
            #endregion
            #region Atividade novaPessoa3
            novaConta3.VisualizarSaldo();
            #endregion
        }

        static T ObterValor<T>(string texto)
        {
            Console.WriteLine(texto);

            string input = Console.ReadLine();

            try
            {
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato Inválido!");
                return ObterValor<T>(texto);
            }
        }
    }
}
