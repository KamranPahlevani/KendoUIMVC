using MvcKendo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcKendo.infrastructure
{
    public class FruitRepository
    {
        public IList<Fruit> GetFruits()
        {
            IList<Fruit> FruitsList = new List<Fruit>()
            {
                new Fruit(){ID = 1, Name = "Apples"},
                new Fruit(){ID = 2, Name = "Oranges"},
                new Fruit(){ID = 3, Name = "Banana"},
                new Fruit(){ID = 4, Name = "BlueBerry"},
            };
            return FruitsList;
        }
    }
}