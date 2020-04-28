using System;
using StockSDK;


namespace AppliPrincipale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StockManager i = new StockManager();
            StockManager.AllStockFromJson();
            StockManager.AllStockToJson();
        }
    }
}
