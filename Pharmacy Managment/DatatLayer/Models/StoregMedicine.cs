namespace Pharmacy_Managment.DatatLayer.Models;
public class StoregMedicine : Medicines 
{
    public StoregMedicine(string name, double price, DateOnly createDate, DateOnly expiration, double temprature, string manufacturedCountry, string shtrixCode, int countMedicine) 
        : base(name, price, createDate, expiration, temprature, manufacturedCountry, shtrixCode, countMedicine)
    {
        
    }

}
