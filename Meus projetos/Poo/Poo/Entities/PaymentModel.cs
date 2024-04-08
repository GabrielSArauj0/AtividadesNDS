namespace Poo.Entities;

public class PaymentModel
{
    class Payments
    {
        public static void main()
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.NumeroBoleto = "123";

            var pagamento = new Payments();
            


        }
    }

    class PagamentoBoleto : Payments
    {
        public DateTime Vencimento;

        public string NumeroBoleto;

        public void Pagar()
        {
            
        }
        
    }

    class PagamentoCartaoCredito : Payments
    {
        public string Numero;
    }
    
}