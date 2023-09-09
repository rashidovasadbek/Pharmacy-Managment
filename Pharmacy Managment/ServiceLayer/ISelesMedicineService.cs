using Pharmacy_Managment.DatatLayer.Models;

namespace Pharmacy_Managment.ServiceLayer;
public interface ISelesMedicineService
{
    void SelesMedicine(string medicineName, int countMedicine);
    SelesMedicines OutputCheck(SelesMedicines selesMedicines);
    IEnumerable<StoregMedicine> GetAllMedicines();
}
