using Pharmacy_Managment.DatatLayer.Models;
using Pharmacy_Managment.FileService;

namespace Pharmacy_Managment.ServiceLayer;
public class StoregMedicineService : IStoregMedicinesService
{
    private readonly IStoregMedicineContext _storegMedicineContext;
    public StoregMedicineService(IStoregMedicineContext storegMedicineContext)
    {
        _storegMedicineContext = storegMedicineContext;
    }


    public void AddMedicine(StoregMedicine storegMedicine)
    {
       /* if (!ExistsMedicine(storegMedicine.Name))
        {
            Console.WriteLine("There is already this drug");
        }*/
        _storegMedicineContext.AddMedicine(storegMedicine);
        
    }
 /*   public bool ExistsMedicine(string name)
    {
        var medicines = _storegMedicineContext.GetAllMedicines();
        return medicines.Any(medicine => medicine.Name == name);
    }*/
    public void DeleteMedicine(string pharmacyName)
    {
        try
        {
            var medicines = _storegMedicineContext.GetAllMedicines();
            var medicinesdelete = medicines.Where(medicine => medicine.Name == pharmacyName).FirstOrDefault();
            if (medicinesdelete != null)
            {
                _storegMedicineContext.DeleteMedicine(pharmacyName);
                Console.WriteLine("Succsess delete medicine");
            }
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public StoregMedicine SearchMedicine(string pharmacyName)
    {
        return _storegMedicineContext.SearchMedicine(pharmacyName);
    }
    public List<StoregMedicine> SortMedicane()
    {
        var allMedicines = _storegMedicineContext.GetAllMedicines();
       var sortmedicine = allMedicines.OrderBy(sort => sort.ExpirationDate).ToList();
        return sortmedicine;
    }
    public void UpdateMedicine(StoregMedicine storegMedicine)
    {
        var medicines = _storegMedicineContext.GetAllMedicines();
        var medicinesupdate = medicines.Where(medicine => medicine.Name == storegMedicine.Name).FirstOrDefault();
        if(medicinesupdate != null)
        {
            medicinesupdate.Name = storegMedicine.Name;
            medicinesupdate.Price = storegMedicine.Price;
            medicinesupdate.CreateDate = storegMedicine.CreateDate;
            medicinesupdate.ExpirationDate = storegMedicine.ExpirationDate;
            medicinesupdate.Temprature = storegMedicine.Temprature;
            medicinesupdate.CountMedicine = storegMedicine.CountMedicine;
            medicinesupdate.ManufacturedCountry = storegMedicine.ManufacturedCountry;
            medicinesupdate.ShtrixCode = storegMedicine.ShtrixCode;
           
            _storegMedicineContext.UpdateMedicine(medicinesupdate);
            Console.WriteLine("Successfully updated medicine");
        }
        else
        {
            Console.WriteLine("medicine not found");
        }
    }

    public IEnumerable<StoregMedicine> OverdueMedicines()
    {
        var allMedicine  = _storegMedicineContext.GetAllMedicines();

        var overdueMedicine = allMedicine.Where(overdue => overdue.ExpirationDate < DateOnly.FromDateTime(DateTime.Now));
        return overdueMedicine;
    }
}
