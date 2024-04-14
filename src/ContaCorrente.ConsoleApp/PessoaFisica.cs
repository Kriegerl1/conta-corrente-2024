namespace ContaCorrente.ConsoleApp
{
    public class PessoaFisica
    {
        public string cpf, nome, sobrenome;


        public PessoaFisica(string cpf, string nome, string sobrenome)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.sobrenome = sobrenome;
        }
        public string Registrar(string cpf, string nome, string sobrenome)
        {
            cpf = "123.123.123-02";
            nome = "Marcio";
            sobrenome = "Arruda";

            return Registrar(cpf, nome, sobrenome);
        }
    }

}
