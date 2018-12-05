using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MyLegoCollection.Web.Data.Entities; /*is dit goed?*/

namespace MyLegoCollection.Web.Models.CollectionViewModels
{
    public sealed class AddLegoSetViewModel
    {
        [Required]
        public int Number { get; set; }
        public int NumberVariant { get; set; }

        [Required]
        public string Name { get; set; }
        public int Year { get; set; }
        public int SelectedTheme { get; set; }
        public IEnumerable<Theme> Themes { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string PurchaseDate { get; set; }

        [Required]
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
