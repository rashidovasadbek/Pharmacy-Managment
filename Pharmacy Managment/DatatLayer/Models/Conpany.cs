namespace Pharmacy_Managment.DatatLayer.Models;
public class Conpany
{
    public Guid Id { get; set; }
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public string CompanyPhone { get; set; }

    public Conpany(string companyName, string address, string companyPhone)
    {
        Id = Guid.NewGuid();
        CompanyName = companyName;
        Address = address;
        CompanyPhone = companyPhone;
    }
}
