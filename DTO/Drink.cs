using System.ComponentModel.DataAnnotations;

namespace CRUD_Assignment.DTO
{
    public class Drink
    {
        public int intColdDrinksld { get; set; }

        public string strColdDrinksName { get; set; }

        public double numQuantity { get; set; }

        public double numUnitPrice { get; set; }
    }
}
