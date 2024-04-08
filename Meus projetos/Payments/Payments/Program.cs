using Payments.Entities.Interface;
using Payments.Entities.Pagamentos;
using Payments.Entities;

namespace Payments;

class Program
{
    static void Main()
    {
        var pagamentoBoleto = new PagamentoBoleto();
        pagamentoBoleto.Pagar();
        pagamentoBoleto.Vencimento = DateTime.Now;

        var pagamentoCartaoCredito = new PagamentoCartaoDeCredito();
        pagamentoCartaoCredito.Pagar();
        pagamentoCartaoCredito.Vencimento = DateTime.Now;

        var pagamentoPix = new PagamentoPix();
        pagamentoPix.Pagar();
        pagamentoPix.Vencimento = DateTime.Now;
        
        
        var menu = new Menu();

        var pessoaFisica = new PessoaFisica();
    }
}


