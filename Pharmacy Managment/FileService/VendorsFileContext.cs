using Pharmacy_Managment.DatatLayer.Models;
using System.Numerics;
using System.Text.Json;

namespace Pharmacy_Managment.FileService;
public class VendorsFileContext : IVendorsFileContext
{
    private static string path = "D:\\Pharmacy Managment\\Pharmacy Managment\\FileService\\PharmacyRegistration.txt";
    
    public void AddVendor(Registration registration)
    {
        List<Registration> _vendors = new();
        string vendor = File.ReadAllText(path);

        if(!string.IsNullOrEmpty(vendor)) 
        {
            _vendors = JsonSerializer.Deserialize<List<Registration>>(vendor);
        }
        _vendors.Add(registration);
        var jsonVendor = JsonSerializer.Serialize(_vendors);
        File.WriteAllText(path, jsonVendor);
    }
    public Registration GetVendor(string login)
    {
        string readvendor = File.ReadAllText(path);
        var _vendorlist = JsonSerializer.Deserialize<List<Registration>>(readvendor);
        var vendor = _vendorlist.FirstOrDefault(vendorId => vendorId.Login == login);
        return vendor;
    }
    public void UpdateVendor(Registration registration)
    {
        List<Registration> _vendors = new();
        string updatevendor = File.ReadAllText(path);
        
        if (!string.IsNullOrEmpty(updatevendor))
        {
          _vendors = JsonSerializer.Deserialize<List<Registration>>(updatevendor);     
        }
        
        var index = _vendors.FindIndex(vendor => vendor.Login == registration.Login);
        _vendors[index].FullName = registration.FullName;
        _vendors[index].PhoneNumber = registration.PhoneNumber;
        _vendors[index].Login = registration.Login;
        _vendors[index].Password = registration.Password;
        var jsonDate = JsonSerializer.Serialize(_vendors);
        File.WriteAllText(path, jsonDate); 
    }
    public void DeleteVendor(string login)
    {
        string removevendor = File.ReadAllText(path);
        var _vendorlist = JsonSerializer.Deserialize<List<Registration>>(removevendor);
        var vendor = _vendorlist.Find(remove => remove.Login == login);
        if (vendor != null)
        {
            _vendorlist.Remove(vendor);
        }
        var jsonVendor = JsonSerializer.Serialize(_vendorlist);
        File.WriteAllText(path, jsonVendor);
    }
    public IEnumerable<Registration> GetAllVendors()
    {
        List<Registration> _vendors = new();
        string getAllVedors = File.ReadAllText(path);
        if (!string.IsNullOrEmpty(getAllVedors))
        {
           _vendors = JsonSerializer.Deserialize<List<Registration>>(getAllVedors);
        }
        if (_vendors == null)

        {
            Console.WriteLine("error");
            return null;
        }
        else
            return _vendors;
    }

}
