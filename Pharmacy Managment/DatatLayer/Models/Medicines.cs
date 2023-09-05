namespace Pharmacy_Managment.DatatLayer.Models;
public class Medicines
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public DateOnly CreateDate { get; set; }
    public DateOnly ExpirationDate { get; set; }    
    public double Temprature { get; set; }
    public string ManufacturedCountry { get; set; }
    public string ShtrixCode { get; set; }
    public int CountMedicine { get; set; }

    public Medicines(string name, double price, DateOnly createDate, DateOnly expiration, double temprature, string manufacturedCountry, string shtrixCode, int countMedicine)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        CreateDate = createDate;
        ExpirationDate = expiration;
        Temprature = temprature;
        ManufacturedCountry = manufacturedCountry;
        ShtrixCode = shtrixCode;
        CountMedicine = countMedicine;

    }
    public Medicines()
    {
        
    }
}
