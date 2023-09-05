using Pharmacy_Managment.FileService;
using Pharmacy_Managment.ServiceLayer;
using Pharmacy_Managment.DatatLayer;
using Pharmacy_Managment.DatatLayer.Models;

namespace Pharmacy_Managment.ServiceLayer;
public interface IVendorsRegistrationService
{
    void AddVendor(Registration registration);
    Registration GetVendor(string login);
    void UpdateVendor(Registration registration);
    void DeleteVendor( string login);
    bool ExitsVendors(string login);
}
