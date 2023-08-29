using System.Text.RegularExpressions;

namespace Algorithms.IdCard;

public class TelephoneNumber
{
    private string telephoneNumber;

    public TelephoneNumber(string telephoneNumber)
    {
        this.telephoneNumber = telephoneNumber;
    }
    public bool IsValid() {
        Regex rx = new Regex(@"^(\+?1 )?\d{3}\d{3}-\d{4}$");
        return rx.Match(this.telephoneNumber).Success;

    }
}