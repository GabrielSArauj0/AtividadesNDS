using MP.ApiDotNet6.Domain.Validations;

namespace MP.ApiDotNet6.Domain.Entities;

public class Purchase
{
    public int Id { get; private set; }
    public int ProductId { get; private set; }
    public int PersonId { get; private set; }
    public DateTime Date { get; private set; }
    public Person Person { get; private set; }
    public Product Product { get; private set; }

    public Purchase(int productId, int personId)
    {
        Validation(productId, personId);
    }

    public Purchase(int id, int productId, int personId)
    {
        DomainValidationException.When(id < 0, "Id deve ser informado");
        Id = id;
        Validation(productId, personId);
    }
    
    private void Validation(int productId, int personId)
    {
        DomainValidationException.When(productId < 0, "O id do produto deve ser informado.");
        DomainValidationException.When(personId< 0, "O id da pessoa deve ser informado!");
       
        PersonId = personId;
        ProductId = productId;
        Date = DateTime.Now;
    }
}