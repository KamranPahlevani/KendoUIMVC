using KendoUIMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIMVC.infrastructure
{
    public class CustomerRepository
    {
        public IList<Customer> GetCustomers()
        {
            IList<Customer> customersList = new List<Customer>(){
                new Customer(){CustomerID = 1, ContactName = "customer1", CompanyName = "company1"},
                new Customer(){CustomerID = 2, ContactName = "customer2", CompanyName = "company2"},
                new Customer(){CustomerID = 3, ContactName = "customer3", CompanyName = "company3"},
                new Customer(){CustomerID = 4, ContactName = "customer4", CompanyName = "company4"},
                new Customer(){CustomerID = 5, ContactName = "customer5", CompanyName = "company5"},
                new Customer(){CustomerID = 6, ContactName = "customer6", CompanyName = "company6"},
                new Customer(){CustomerID = 7, ContactName = "customer7", CompanyName = "company7"},
                new Customer(){CustomerID = 8, ContactName = "customer8", CompanyName = "company8"},
            };
            return customersList;
        }
    }
}