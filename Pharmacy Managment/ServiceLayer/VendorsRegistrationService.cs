using Pharmacy_Managment.DatatLayer.Models;
using Pharmacy_Managment.FileService;
namespace Pharmacy_Managment.ServiceLayer;
public class VendorsRegistrationService : IVendorsRegistrationService
{
    private readonly IVendorsFileContext _vendorFileContext;

    public VendorsRegistrationService(IVendorsFileContext vendorsFileContext)
    {
        _vendorFileContext = vendorsFileContext;
    }
    public void AddVendor(Registration registration)
    {

        if (ExitsVendors(registration.Login))
        {
            Console.WriteLine("Vendor with login does not exists");
        }
            _vendorFileContext.AddVendor(registration); 
   
    }  
    public bool ExitsVendors(string login)
    {
        var vendors = _vendorFileContext.GetAllVendors().ToList();
        return vendors.Any(vendor => vendor.Login == login );
    }
    public void DeleteVendor(string login)
    {
        var vendors = _vendorFileContext.GetAllVendors();
        var vendorToDelete= vendors.Where(vendor => vendor.Login == login).FirstOrDefault();
        if(vendorToDelete != null)
        {
            _vendorFileContext.DeleteVendor(login);
            Console.WriteLine("Successfully delete vendor");
        }
        else
        {
            Console.WriteLine("login Not Found");
        }
    }
    public Registration GetVendor(string login)
    {

        return _vendorFileContext.GetVendor(login);
    }
    public void UpdateVendor(Registration registration)
    {
        var vendors = _vendorFileContext.GetAllVendors();
        var vendorToUpdate = vendors.Where(vendor => vendor.Login == registration.Login).FirstOrDefault();

        if (vendorToUpdate != null)
        {
            vendorToUpdate.FullName = registration.FullName;
            vendorToUpdate.PhoneNumber = registration.PhoneNumber;
            vendorToUpdate.Login = registration.Login;
            vendorToUpdate.Password = registration.Password;

            _vendorFileContext.UpdateVendor(vendorToUpdate);
            Console.WriteLine("Successfully updated vendor");
        }
        else
        {
            Console.WriteLine("login not found");
        }
    }
}
