using Pharmacy_Managment.DatatLayer.Models;

namespace Pharmacy_Managment.ServiceLayer;
public interface ISelesMedicineService
{
    void CalculateMedicine(SelesMedicines selesMedicines);
    SelesMedicines OutputCheck(SelesMedicines selesMedicines);
    IEnumerable<StoregMedicine> GetAllMedicines();
}
