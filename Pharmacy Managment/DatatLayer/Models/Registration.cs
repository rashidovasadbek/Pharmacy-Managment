using System.Data;

namespace Pharmacy_Managment.DatatLayer.Models;
public class Registration
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public Role RoleId { get; set; }

    public Registration(string fullName, string phoneNumber, string login, string password, Role role)
    {

        Id = Guid.NewGuid();
        FullName = fullName;
        PhoneNumber = phoneNumber;
        Login = login;
        Password = password;
        RoleId = role;
    }
    public Registration()
    {

    }
    public override string ToString()
    {
        return $"Id:{Id} FullName:{FullName} PhoneNUmber:{PhoneNumber} Login:{Login} Password:{Password} Role:{RoleId}";
    }
}
