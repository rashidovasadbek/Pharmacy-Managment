using Pharmacy_Managment.DatatLayer.Models;
namespace Pharmacy_Managment.FileService;
public interface ISelesMedicinesContext
{
    void CalculateMedicine(SelesMedicines selesMedicines);
    SelesMedicines OutputCheck(SelesMedicines selesMedicines);
}

