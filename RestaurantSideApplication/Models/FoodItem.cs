﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantSideApplication.Models
{
    public class FoodItem
    {
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodItemId { get; set; }*/
        public string FoodItemName { get; set; }

        public string FoodItemImage { get; set; }

        public int Price { get; set; }

        /*public int RestaurantId { get; set; }*/

       /* [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }*/

        public FoodItem() { }
        public FoodItem(string foodItemName, string foodItemImage, int price)
        {
       
            FoodItemName = foodItemName;
            FoodItemImage = foodItemImage;
            Price = price;
          
        }
    }
}
