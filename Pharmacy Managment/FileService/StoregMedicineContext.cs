using Pharmacy_Managment.DatatLayer.Models;
using System.IO;
using System.Text.Json;

namespace Pharmacy_Managment.FileService;
public class StoregMedicineContext : IStoregMedicineContext
{
    private static string Medicinespath = "D:\\Pharmacy Managment\\Pharmacy Managment\\FileService\\StorageOfDrugsSold.txt";
    public void AddMedicine(StoregMedicine storegMedicine)
    {
        try
        {
            List<StoregMedicine> _medicines = new();
            string medicine = File.ReadAllText(Medicinespath);

            if (string.IsNullOrEmpty(medicine))
            {
                _medicines = JsonSerializer.Deserialize<List<StoregMedicine>>(medicine);
            }
            _medicines.Add(storegMedicine);
            var jsonVendor = JsonSerializer.Serialize(_medicines);
            File.WriteAllText(Medicinespath, jsonVendor);
        }catch(Exception e)
        {
            Console.WriteLine("The string `medicine` could not be deserialized into a list of medicines.");
        }
    }

    public void DeleteMedicine(string pharmacyName)
    {
        string medicine = File.ReadAllText(Medicinespath);
        var _medicineslist = JsonSerializer.Deserialize<List<StoregMedicine>>(medicine);
        var medicinedelete = _medicineslist.Where(medicine => medicine.Name ==  pharmacyName).FirstOrDefault(); 
        if (medicinedelete != null)
        {
            _medicineslist.Remove(medicinedelete);
        }
    }

    public IEnumerable<StoregMedicine> GetAllMedicines()
    {
        List<StoregMedicine> _storegMedicines = new ();
        string getMedicines = File.ReadAllText(Medicinespath);
        if(!string.IsNullOrEmpty(getMedicines))
        {
            _storegMedicines = JsonSerializer.Deserialize<List<StoregMedicine>>(getMedicines);
        }
        return _storegMedicines;
    }

    public StoregMedicine SearchMedicine(string pharmacyName)
    {
        string searchMedicine = File.ReadAllText(Medicinespath);
        var _medicinelist = JsonSerializer.Deserialize<List<StoregMedicine>>(searchMedicine);
        var medicine = _medicinelist.FirstOrDefault( medicine => medicine.Name == pharmacyName);
        return medicine;
    }

    public void UpdateMedicine(StoregMedicine storegMedicine)
    {
        List<StoregMedicine> _storegMedicines = new();
        var updateMedicine = File.ReadAllText(Medicinespath);
        if (string.IsNullOrEmpty(updateMedicine))
        {
            _storegMedicines = JsonSerializer.Deserialize<List<StoregMedicine>>(updateMedicine);
        }
         var index = _storegMedicines.FindIndex(medicine => medicine.Name == storegMedicine.Name);
        _storegMedicines[index].Name = storegMedicine.Name;
        _storegMedicines[index].Price = storegMedicine.Price;
        _storegMedicines[index].CreateDate = storegMedicine.CreateDate;
        _storegMedicines[index].ExpirationDate = storegMedicine.ExpirationDate;
        _storegMedicines[index].CountMedicine = storegMedicine.CountMedicine;
        _storegMedicines[index].ManufacturedCountry = storegMedicine.ManufacturedCountry;
        _storegMedicines[index].ShtrixCode = storegMedicine.ShtrixCode;
        _storegMedicines[index].Temprature = storegMedicine.Temprature;
        string jsonDate = JsonSerializer.Serialize(_storegMedicines);
        File.WriteAllText(Medicinespath, jsonDate);
    }


}
