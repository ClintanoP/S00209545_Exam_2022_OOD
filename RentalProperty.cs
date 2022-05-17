using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace S00209545_Exam_2022_OOD
{
    public enum RentalType
    { 
        House, Flat, Share
    }
    public class RentalProperty
    {
        public int ID { get; set; }
        public RentalType TypeOfRental { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public void IncreasePrice(decimal percentage)
        {
            Price *= percentage;
        }
        public override string ToString()
        {
            return $"{Location}  {Price:C}";
        }
    }//end of RentalProperty class

    public class RentalPropertyData : DbContext {
        public RentalPropertyData() : base("MyRentalPropertyData") { }

        public DbSet<RentalProperty> Rentals { get; set; }
    }


    
}
