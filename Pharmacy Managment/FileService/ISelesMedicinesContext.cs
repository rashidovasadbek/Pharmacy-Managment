using Pharmacy_Managment.DatatLayer.Models;
namespace Pharmacy_Managment.FileService;
public interface ISelesMedicinesContext
{
    void CalculateMedicine(string medicineName, int countMedicine);
    SelesMedicines OutputCheck(SelesMedicines selesMedicines);
}

