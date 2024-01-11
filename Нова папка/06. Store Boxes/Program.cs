namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string info = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            while (info != "end")
            {

                string[] infoAsArray = info.Split();
                string serialNumber = infoAsArray[0];
                string itemName = infoAsArray[1];
                int itemQuentity = int.Parse(infoAsArray[2]);
                decimal itemPrice = decimal.Parse(infoAsArray[3]);

                //: itemQuantity * itemPrice 
                // purvo zapochvame s po malko vajniq obekt 

                Item item = new Item();
                item.Name = itemName;
                item.Price = itemPrice;

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.Item = item; // taka dobavqme obekta item kum obekta box 
                box.ItemQuentity = itemQuentity;
                box.PriceForBox = itemPrice * itemQuentity;


                boxes.Add(box);


                info = Console.ReadLine();
            }
            foreach (var box in boxes.OrderByDescending(x => x.PriceForBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuentity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
        }

        class Box // imame edna golqma kutiq i v neq imame nqkakuv item 
        {
            public string SerialNumber { get; set; }

            public Item Item { get; set; } // kakvo e vutre

            public int ItemQuentity { get; set; }

            public decimal PriceForBox { get; set; }
        }

        class Item
        {
            public string Name { get; set; }

            public decimal Price { get; set; }
        }
    }
    
}