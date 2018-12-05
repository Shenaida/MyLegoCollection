using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLegoCollection.Web.Business.Models
{
    public sealed class LegoSetModel
    {
        public int SetId { get; set; }
        public int Number { get; set; }
        public int NumberVariant { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Theme { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string BoughtAt { get; set; }
        public int LegoPieces { get; set; }
        public bool HasPicture { get; set; }
        public string PictureURL { get; set; }
        public int AgeMinimum { get; set; }
        public int AgeMaximum { get; set; }
        public int BoxHeight { get; set; }
        public int BoxWidth { get; set; }
        public int BoxDepth { get; set; }
        public int BoxWeight { get; set; }
    }
}
