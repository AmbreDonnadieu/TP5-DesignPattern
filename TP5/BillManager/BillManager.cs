using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using StockSDK;
class BillManager
{
    Bill theBill;


    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World!");
    }

    public void BillToJson()
    {
        using (StreamWriter file = File.CreateText(@"bill.json"))
        using (JsonTextWriter writer = new JsonTextWriter(file))
        {
            JArray all = new JArray();
            
            JObject userJson = new JObject();
            userJson.Add("nom", theBill.user.nom);
            userJson.Add("prenom",theBill.user.prenom);
            userJson.Add("email",theBill.user.email);
            userJson.Add("username",theBill.user.username);

            JArray totaux = new JArray();
            foreach (Bill.BillLine i in theBill.AllBillLines)
            {
                JObject o = new JObject();
                o["nom"] = i.itemLine.item.nom_item;
                o["quantite"] = i.itemLine.quantite_item;
                o["sous-total"] = i.soustotal;

                totaux.Add(o);
            }
            all.Add(userJson);
            all.Add(totaux);
            all.WriteTo(writer);
        }
    }
}

