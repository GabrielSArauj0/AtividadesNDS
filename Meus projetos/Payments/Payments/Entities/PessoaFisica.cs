namespace Payments.Entities;

public class PessoaFisica : Pessoa
{
    public string Cpf { get; set; } = null!;
    public string Nome { get; set; } = null!;

    public PessoaFisica()
    { }
    
    public PessoaFisica(string cpf, string nome)
    {
        Cpf = cpf;
        Nome = nome;
    }
}