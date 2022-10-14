using System;

namespace FoodDeliveryApplication
{
    public class FoodDetails
    {
        private static int s_foodId=100;
        public string FoodId { get; set; }
        public string FoodName { get; set; }
        public int PricePerQuantity { get; set; }

        public FoodDetails(string foodName,int pricePerQuantity)
        {
            s_foodId++;
            FoodId="FID"+s_foodId;
            FoodName=foodName;
            PricePerQuantity=pricePerQuantity;

        }
        public FoodDetails(string data)
        {
            string [] values=data.Split(',');
            s_foodId=int.Parse(values[0].Remove(0,3));
            FoodId=values[0];
            FoodName=values[1];
            PricePerQuantity=int.Parse(values[2]);
        }
    }
}
