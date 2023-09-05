using System;
using Pharmacy_Managment.FileService;
using Pharmacy_Managment.ServiceLayer;
using Pharmacy_Managment.DatatLayer.Models;

Name();
MainMenu();
while (true)
{
    var chooseA = int.Parse(Console.ReadLine());
    if (chooseA == 1)
    {
        while (true)
        {
            Console.Clear();
            ChangeVendors();
            VendorsFileContext vendorsFileContext = new VendorsFileContext();
            IVendorsRegistrationService vendorsRegistrationService = new VendorsRegistrationService(vendorsFileContext);
            var chooseB = int.Parse(Console.ReadLine());

            if (chooseB == 1)
            {
                Console.WriteLine("FullName = ");
                string fullName = Console.ReadLine();

                Console.WriteLine("Phone = ");
                string phone = Console.ReadLine();

                Console.WriteLine("Login:");
                string login = Console.ReadLine();

                Console.WriteLine("Password = ");
                string password = Console.ReadLine();

                Console.WriteLine("Admin Password:");
                string adminPassword = Console.ReadLine();
                // Admin Password is Admin

                if (adminPassword == "Admin")
                {
                    var vendor = new Registration(fullName, phone, login, password, Role.vendor);
                    vendorsRegistrationService.AddVendor(vendor);
                    Console.WriteLine("Succsess Add vendor");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Only admins can add");
                }

                Console.Write("0.Back->");
                var chooseB0 = int.Parse(Console.ReadLine());
                if (chooseB0 == 0)
                {
                    chooseA = 1;
                    Console.Clear();
                    ChangeVendors();
                }
            }
            if (chooseB == 2)
            {
                Console.WriteLine("Enter login:");
                var login = Console.ReadLine();
                Console.WriteLine(vendorsRegistrationService.GetVendor(login));
                Console.Write("0.Back->");
                var chooseB0 = int.Parse(Console.ReadLine());
                if (chooseB0 == 0)
                {
                    Console.Clear();
                    ChangeVendors();
                }
            }
            if (chooseB == 3)
            {
                Console.WriteLine("Login:");
                string login = Console.ReadLine();

                Console.WriteLine("FullName = ");
                string fullName = Console.ReadLine();

                Console.WriteLine("Phone = ");
                string phone = Console.ReadLine();

                Console.WriteLine("Login:");
                string updatelogin = Console.ReadLine();

                Console.WriteLine("Password = ");
                string password = Console.ReadLine();

                Console.WriteLine("Admin Password:");
                string adminPassword = Console.ReadLine();
                // Admin Password is Admin
                if (adminPassword == "Admin")
                {
                    vendorsRegistrationService.UpdateVendor(new Registration(fullName, phone, updatelogin, password, Role.vendor));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Only admins can update");
                }

                Console.Write("0.Back->");
                var chooseB0 = int.Parse(Console.ReadLine());
                if (chooseB0 == 0)
                {
                    Console.Clear();
                    ChangeVendors();
                }
            }
            if (chooseB == 4)
            {
                Console.WriteLine("Enter login:");
                var login = Console.ReadLine();
                Console.WriteLine("Admin Password:");
                string adminPassword = Console.ReadLine();
                // Admin Password is Admin
                if (adminPassword == "Admin")
                {
                    vendorsRegistrationService.DeleteVendor(login);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Only admins can delete");
                }

                Console.Write("0.Back->");
                var chooseB0 = int.Parse(Console.ReadLine());
                if (chooseB0 == 0)
                {
                    Console.Clear();
                    ChangeVendors();
                }
            }
            if (chooseB == 0)
            {
                return;
            }
        }
    }
    if (chooseA == 2)
    {
        while (true)
        {
            Console.Clear();
            MainSales();
            var chooseC = int.Parse(Console.ReadLine());
            if(chooseC == 1)
            {
                while (true)
                {
                    Console.Clear();
                    ActionMedicines();
                    StoregMedicineContext storegMedicineContext = new StoregMedicineContext();
                    IStoregMedicinesService storegMedicinesService = new StoregMedicineService(storegMedicineContext);
                    var chooseD = int.Parse(Console.ReadLine());
                    /*  Id = Guid.NewGuid();
                        Name = name;
                        Price = price;
                        CreateDate = createDate;
                        ExpirationDate = expiration;
                        Temprature = temprature;
                        ManufacturedCountry = manufacturedCountry;
                        ShtrixCode = shtrixCode;
                        CountMedicine = countMedicine;*/
                    if(chooseD == 1)
                    { 
                        //Console.Write("MedicineName:");
                        //var medicineName = Console.ReadLine();
                        var medicineName = "Amizon";
                        //Console.Write("Price:");
                        //var medicinePrice = double.Parse(Console.ReadLine());
                        var medicinePrice = 12.3;
                        //Console.WriteLine("CreateDate:");
                        //Console.Write("Year:");
                        //var createYear = int.Parse(Console.ReadLine());
                        var createYear = 2023;
                        //Console.Write("Month:");
                        //var createMonth = int.Parse(Console.ReadLine());
                        var createMonth = 1;
                        //Console.Write("Day:");
                        //var createDay = int.Parse(Console.ReadLine());
                        var createDay = 1;


                        //Console.WriteLine("ExpirationDate:");              
                        //Console.Write("Year:");
                        //var expirationYear = int.Parse(Console.ReadLine());
                        var expirationYear = 2024;
                        //Console.Write("Month:");
                        //var expirationMonth = int.Parse(Console.ReadLine());
                        var expirationMonth = 1;
                        //Console.Write("Day:");
                        //var expirationDay = int.Parse(Console.ReadLine());
                        var expirationDay = 1;
                       // Console.Write("Temprature:");
                        //var temprature = double.Parse(Console.ReadLine());
                        var temprature = 21.5;
                        //Console.Write("ManufacturedCountry:");
                        //var manufacturedCountry = Console.ReadLine();
                        var manufacturedCountry = "Germany";
                        //Console.Write("ShtrixCode:");
                        //var shtrixCode = Console.ReadLine();
                        var shtrixCode = "123456543567";
                        //Console.Write("CountMedicine:");
                        //var countMedicine = int.Parse(Console.ReadLine());
                        var countMedicine = 18;
                        var medicine = new StoregMedicine(medicineName, medicinePrice, new DateOnly(createYear,createMonth,createDay),  new DateOnly(expirationYear,expirationMonth,expirationDay), temprature, manufacturedCountry, shtrixCode, countMedicine);
                        storegMedicinesService.AddMedicine(medicine);
                        Console.WriteLine("Succsess Add medicine");
                        Console.Write("0.Back->");
                        var chooseB0 = int.Parse(Console.ReadLine());
                        if (chooseB0 == 0)
                        {
                            Console.Clear();
                            ActionMedicines();
                        }
                    }
                    if(chooseD == 2)
                    {
                        Console.Write("Enter Name:");
                        var name = Console.ReadLine();
                        storegMedicinesService.DeleteMedicine(name);
                        
                    }
                }
            }
        }
    }
    if (chooseA == 0)
    {
        return;
    }
}
static void Name()
{
Console.WriteLine("Pharmacy Managment".PadLeft(30));
}
static void ChangeVendors()
{
    Console.WriteLine("Change Vendors".PadLeft(30));
    Console.WriteLine("1.AddVendor");
    Console.WriteLine("2.GetVendor");
    Console.WriteLine("3.UpdateVendor");
    Console.WriteLine("4.DeleteVendor");
    Console.WriteLine("0.Back");
}
static void ActionMedicines()
{
    Console.WriteLine("1.AddMedicines");
    Console.WriteLine("2.DeleteMedicine");
    Console.WriteLine("3.SearchMedicine");
    Console.WriteLine("4.SortMedicane");
    Console.WriteLine("5.UpdateMedicine");
}
static void EnterMenu()
{
    Console.WriteLine("1.Admistrator");
    Console.WriteLine("2.MainSelesManagment");
    Console.WriteLine("0.Exit");   
} 
static void MainSales()
{
    Console.WriteLine("1.StoregMedicines");
    Console.WriteLine("2.SelesMedicines");
    Console.WriteLine("0.Back");
}
static void MainMenu()
{
    Console.WriteLine("1.Admistration");
    Console.WriteLine("2.Vedors");
}

