using System;

namespace Assignment
{
    // This program demo. how to create Association 
    class Association
    {
      static void Main()
        {
            Cloth cloth1 = new Cloth { NoOfClothes = 3, ClothColour = "Red" };
            Item item1 = new Item { ItemNo = 45, ItemName = "Dress" };
            item1.Items(cloth1);

            Cloth cloth2 = new Cloth { NoOfClothes = 2, ClothColour = "Blue" };
            Item item2 = new Item { ItemNo = 34, ItemName = "Frock" };
            item1.Items(cloth2);
            Console.ReadLine();
        }
    }
    class Item
    {
        public int ItemNo { get; set; }
        public string ItemName { get; set; }
        public void Items(Cloth cloth)
        {
            Console.WriteLine($"{this.ItemName} is a Item {cloth.ClothColour}");

        }
    }
    class Cloth
    {
        public int NoOfClothes { get; set; }
        public string ClothColour { get; set; }


    }
}
