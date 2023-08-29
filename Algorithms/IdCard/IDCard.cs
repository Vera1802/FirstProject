using Algorithms.IdCard;

public class IdCard
{
    private Name name;
    private PostalCode postalCode;
    private TelephoneNumber telephoneNumber;

    public IdCard(Name name, 
                  PostalCode postalCode, 
                  TelephoneNumber telephoneNumber)
    {
        this.name = name;
        this.postalCode = postalCode;
        this.telephoneNumber = telephoneNumber;
    }
    public bool IsValid() {
        return name.IsValid() 
        && postalCode.IsValid() 
        && telephoneNumber.IsValid();
    }
}