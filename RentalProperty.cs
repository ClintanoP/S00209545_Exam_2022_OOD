using System;
using System.Collections.Generic;
using System.Text;

namespace S00209545_Exam_2022_OOD
{
    public enum Rentals
    { 
        Rental, Flat, Share
    }
    public class RentalProperty
    {
        public int ID { get; set; }
        public Rentals RentalType { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public void IncreasePrice(decimal percentage)
        {
            Price *= percentage;
        }
    }

    
}
