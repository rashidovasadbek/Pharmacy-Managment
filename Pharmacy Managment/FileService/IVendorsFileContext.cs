using Pharmacy_Managment.DatatLayer.Models;

namespace Pharmacy_Managment.FileService;
public interface IVendorsFileContext
{
    void AddVendor(Registration registration);
    Registration GetVendor(string login);
    void UpdateVendor(Registration registration);
    void DeleteVendor(string login);
    IEnumerable<Registration> GetAllVendors();

}
