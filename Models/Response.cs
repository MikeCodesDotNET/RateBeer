using System;

namespace RateBeer.Models
{
    public class Response
    {
        public int BeerID { get; set; }
        public string BeerName { get; set; }
        public int BrewerID { get; set; }
        public string BrewerName { get; set; }
        public double AverageRating { get; set; }
        public double Alcohol { get; set; }

    }
}

