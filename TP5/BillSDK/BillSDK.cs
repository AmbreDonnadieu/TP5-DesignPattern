using System;
using System.Collections.Generic;
using StockSDK;

public class Bill
{
    public User user { get; set; }

    public List<BillLine> AllBillLines { get; set; }

    public double TotalHT;
    public double TotalTTC;

    public Bill CreateBill(User user2, List<ItemLine> lines)
    {
        Bill b = new Bill();
        b.user = user2;
        foreach(ItemLine l in lines)
        {
            BillLine bl = new BillLine();
            bl.itemLine = l;
            bl.soustotal = l.quantite_item * l.item.prix_item;
            b.AllBillLines.Add(bl);
        }
        foreach(BillLine bl in b.AllBillLines)
        {
            b.TotalHT += bl.soustotal;
        }
        b.TotalTTC = b.TotalHT * 1.15; //on prend 15% de taxes ce qui correspond aux taxes au Québec
        return b;
    }

    public class BillLine
    {
        public ItemLine itemLine { get; set; }
        public double soustotal {get;set;}
    }
}