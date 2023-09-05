using Pharmacy_Managment.DatatLayer.Models;
using System.Text.Json;

namespace Pharmacy_Managment.FileService;
public class SelesMedicineContext : ISelesMedicinesContext
{
    private static string StoregPath = "D:\\Pharmacy Managment\\Pharmacy Managment\\FileService\\StorageOfDrugsSold.txt";
    private static string soldMedicinesPath = "D:\\Pharmacy Managment\\Pharmacy Managment\\FileService\\SoldMedicines.txt";
    public void CalculateMedicine(SelesMedicines selesMedicines)
    {
        List<SelesMedicines> _selesMedicines = new();
        string selesMedicine = File.ReadAllText(soldMedicinesPath);

        if(!string.IsNullOrEmpty(selesMedicine))
        {
            _selesMedicines = JsonSerializer.Deserialize<List<SelesMedicines>>(selesMedicine);
        }
        _selesMedicines.Add(selesMedicines);
        var jsonDate = JsonSerializer.Serialize(_selesMedicines);
        File.WriteAllText(soldMedicinesPath, jsonDate);
    }

    public SelesMedicines OutputCheck(SelesMedicines selesMedicines)
    {
        throw new NotImplementedException();
    }
}
