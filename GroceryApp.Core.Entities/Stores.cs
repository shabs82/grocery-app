using System;

namespace GroceryApp.Core.Entities
{
    public class Stores
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string WebUrl { get; set; }
    }
}
