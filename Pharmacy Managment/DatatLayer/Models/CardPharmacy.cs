namespace Pharmacy_Managment.DatatLayer.Models;
public class CardPharmacy
{
    public Guid Id { get; set; }
    public string PharmacyName { get; set; }
    public decimal Balance { get; set; }
    public string CardNumnber { get; set; }

    public CardPharmacy(string pharmacyName, decimal balance, string cardnumber)
    {
        Id = Guid.NewGuid();
        PharmacyName = pharmacyName;
        Balance = balance; 
        CardNumnber = cardnumber;
    }
}

