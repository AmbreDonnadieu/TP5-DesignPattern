using System;
using StockSDK;


namespace AppliPrincipale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StockManager.AllStockFromJson();
            StockManager.AllStockToJson();

            UserManager.UsersFromJson();
            User u = UserManager.FindByUsername("lfairburne5");
        }
    }
}
