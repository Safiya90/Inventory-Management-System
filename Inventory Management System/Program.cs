using System.Globalization;

namespace Inventory_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] product = new string[]{ "Apple","Orange","Milk"};
            int[] quantity= new int[] { 100, 200, 300 };

            while (true)
            {
                Console.WriteLine("Menue:\n1-View All Products\r\n2-Add Stock\r\n3-Sell Product\r\n4-Check roduct Quantity\r\n5-Exit");
                Console.Write("Please choose from 1 to 5:");
                string choose=Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        for (int i=0; i < product.Length;i++)
                        {
                            Console.WriteLine($"{product[i]} - {quantity[i]}");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Which product need to be updated:");
                        String add= Console.ReadLine();
                        bool added = false;
                        for (int i = 0; i < product.Length; i++)
                        {
                            if (add == product[i])
                            {
                                Console.WriteLine("Enter Quantity to add:");
                                int addqty = Convert.ToInt32(Console.ReadLine());
                                quantity[i] = addqty + quantity[i];
                                Console.WriteLine($"The updated Quantity of {product[i]} is equals to {quantity[i]}");
                                added = true;
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("Which product need to sell:");
                        String sell = Console.ReadLine();
                        bool selling = false;
                        for (int i = 0; i < product.Length; i++)
                        {
                            if (sell == product[i])
                            {
                                Console.WriteLine("Enter Quantity to sell:");
                                int sellqty = Convert.ToInt32(Console.ReadLine());
                                quantity[i] = quantity[i] - sellqty;
                                Console.WriteLine($"The updated Quantity of {product[i]} is equals to {quantity[i]}");
                                added = true;
                            }
                        }
                        break;

                        case "4":
                        for (int i = 0; i < product.Length; i++)
                        {
                            Console.WriteLine($"{product[i]} - {quantity[i]}");
                        }
                        break;

                        case "5":
                        return;

                }
            }
        }
    }
}
