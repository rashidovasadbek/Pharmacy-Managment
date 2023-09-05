﻿using Pharmacy_Managment.DatatLayer.Models;
namespace Pharmacy_Managment.ServiceLayer;
public interface IStoregMedicinesService
{
    void AddMedicine(StoregMedicine storegMedicine);
    void UpdateMedicine(StoregMedicine storegMedicine);
    void DeleteMedicine(string pharmacyName);
    StoregMedicine SearchMedicine(string pharmacyName);
    IEnumerable<StoregMedicine> SortMedicane();
    
  
}
