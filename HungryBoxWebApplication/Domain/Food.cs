
namespace HungryBoxWebApplication
{
    using System;

    public class Food
    {
        public string ItemName { get; set; }
        public string ItemPrice { get; set; }
        public string HotelName { get; set; }
        //public FoodType foodType { get; set; }
    }
    public enum FoodType
    {
        Italian, 
        French, 
        Greek, 
        Turkish, 
        Azian
    }
}
