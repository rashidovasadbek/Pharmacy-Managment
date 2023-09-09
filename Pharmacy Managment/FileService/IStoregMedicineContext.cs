using Pharmacy_Managment.DatatLayer.Models;

namespace Pharmacy_Managment.FileService;
public interface IStoregMedicineContext
{
    void AddMedicine(StoregMedicine storegMedicine);
    void UpdateMedicine(StoregMedicine storegMedicine);
    void DeleteMedicine(string pharmacyName);
    StoregMedicine SearchMedicine(string pharmacyName);
    List<StoregMedicine> GetAllMedicines();
   
}
