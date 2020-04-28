using System;
using System.IO;
using StockSDK;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



public class StockManager
{

    public static StockSDK.StockManager test = new StockSDK.StockManager();

    public static void AllStockFromJson()
    {
        JArray o1 = JArray.Parse(File.ReadAllText(@"stock.json"));

        foreach (JToken token in o1)
        {
            ItemLine line = new ItemLine();
            line.item.nom_item = token["nom"].ToString();
            line.item.prix_item = Double.Parse(token["prixHT"].ToString());
            line.quantite_item = int.Parse(token["quantite"].ToString());

            test.AllLines.Add(line);
        }
    }

    public static void AllStockToJson()
    {
        using (StreamWriter file = File.CreateText(@"stock.json"))
        using (JsonTextWriter writer = new JsonTextWriter(file))
        {
            JArray all = new JArray();
            foreach (ItemLine i in test.AllLines)
            {
                JObject o = new JObject();
                o["nom"] = i.item.nom_item;
                o["prixHT"] = i.item.prix_item;
                o["quantite"] = i.quantite_item;

                all.Add(o);
            }
            all.WriteTo(writer);
        }
    }

    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World!");
    }
}