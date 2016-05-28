using KendoUIMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIMVC.infrastructure
{
    public class SupplierRepository
    {
        public IList<Supplier> GetSuppliers()
        {
            IList<Supplier> SuppliersList = new List<Supplier>()
            {
                new Supplier(){SupplierID = 1, CompanyName = "C1"},
                new Supplier(){SupplierID = 2, CompanyName = "C2"},
                new Supplier(){SupplierID = 3, CompanyName = "C3"},
                new Supplier(){SupplierID = 4, CompanyName = "C4"},
                new Supplier(){SupplierID = 5, CompanyName = "C5"},
            };
            return SuppliersList;
        }

    }
}