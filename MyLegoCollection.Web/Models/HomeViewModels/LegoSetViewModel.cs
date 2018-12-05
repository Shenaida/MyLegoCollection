using System;

namespace MyLegoCollection.Web.Models.HomeViewModels
{
    public sealed class LegoSetViewModel
    {
        public int SetId { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string BoughtAt { get; set; }
        public bool HasPicture { get; set; }
        public string PictureURL { get; set; }
    }
}
