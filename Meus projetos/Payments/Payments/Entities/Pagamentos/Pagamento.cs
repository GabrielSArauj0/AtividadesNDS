namespace Payments.Entities.Pagamentos;

public class Pagamento
{
    public DateTime Vencimento;
    
    public virtual void Pagar()
    {
    }
}
