using Pharmacy_Managment.DatatLayer.Models;
using Pharmacy_Managment.FileService;

namespace Pharmacy_Managment.ServiceLayer;
public class SelesMedicinesService : ISelesMedicineService
{
    private readonly ISelesMedicinesContext _selesMedicinesContext;
    private readonly IStoregMedicineContext _storegMedicineContext;

    public SelesMedicinesService(ISelesMedicinesContext selesMedicinesContext,IStoregMedicineContext storegMedicineContext)
    {
        _selesMedicinesContext = selesMedicinesContext;
        _storegMedicineContext = storegMedicineContext;
    }
    public void SelesMedicine(string medicineName, int countMedicine)
    {
        var medicines =_storegMedicineContext.GetAllMedicines();
        var medicinesSeleAndDelete = medicines.Where(medicine => medicine.Name == medicineName && medicine.CountMedicine > 0).FirstOrDefault();
       
        if (medicinesSeleAndDelete is  null)
        {
            Console.WriteLine($"{medicineName} is not found");
        }
        if(medicinesSeleAndDelete is not null)
        {
            _selesMedicinesContext.CalculateMedicine(medicineName,countMedicine);
            medicinesSeleAndDelete.CountMedicine -= countMedicine;
            _storegMedicineContext.UpdateMedicine(medicinesSeleAndDelete);        
        }
    }
    public IEnumerable<StoregMedicine> GetAllMedicines()
    {
        var getAllMedicines = _storegMedicineContext.GetAllMedicines();
        return getAllMedicines;
    }

    public SelesMedicines OutputCheck(SelesMedicines selesMedicines)
    {
        throw new NotImplementedException();
    }
}
