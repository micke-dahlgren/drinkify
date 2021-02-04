using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    /*
    public class TodoItem
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }
    }
    */
    public class Drink
    {
        public string strDrink { get; set; }
        public string strDrinkThumb { get; set; }
        public string idDrink { get; set; }

        public long Id {get; set; }
    }

    public class DrinkResult
    {
        public List<Drink> drinks { get; set; }
    }
}





