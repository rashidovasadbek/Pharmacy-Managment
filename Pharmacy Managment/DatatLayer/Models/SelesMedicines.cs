namespace Pharmacy_Managment.DatatLayer.Models;
public class SelesMedicines : Medicines
{
    public SelesMedicines(string name, double price, DateOnly createDate, DateOnly expiration, double temprature, string manufacturedCountry, string shtrixCode, int countMedicine)
        : base(name, price, createDate, expiration, temprature, manufacturedCountry, shtrixCode, countMedicine)
    {

    }
}
