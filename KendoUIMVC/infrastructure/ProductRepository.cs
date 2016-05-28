using KendoUIMVC.Models;
using KendoUIMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIMvcApplication.Infrastructure
{
    public class ProductRepository
    {
        public IList<Product> GetProducts()
        {
            IList<Product> ProductsList = new List<Product>()
            {
                new Product(){ProductID = 1, ProductName = "A", UnitPrice = 100, UnitsInStock = 150, Discontinued = false, SupplierID=1, Category = new Category() {CategoryID = 1, CategoryName = "C1" }},
                new Product(){ProductID = 2, ProductName = "B", UnitPrice = 200, UnitsInStock = 250, Discontinued = false, SupplierID=2, Category = new Category() {CategoryID = 2, CategoryName = "C2" }},
                new Product(){ProductID = 3, ProductName = "C", UnitPrice = 300, UnitsInStock = 350, Discontinued = false, SupplierID=4, Category = new Category() {CategoryID = 3, CategoryName = "C3" }},
                new Product(){ProductID = 4, ProductName = "D", UnitPrice = 400, UnitsInStock = 450, Discontinued = true, SupplierID=4 , Category = new Category() {CategoryID = 3, CategoryName = "C3" }},
                new Product(){ProductID = 5, ProductName = "E", UnitPrice = 500, UnitsInStock = 550, Discontinued = true, SupplierID=5, Category = new Category() {CategoryID = 4, CategoryName = "C4" }},
            };
            return ProductsList;
        }
    }
}