using System;
using System.Collections.Generic;

public class Item
{
    public string nom_item { get; set; }

    public double prix_item { get; set; }

    public Item(string nom, double prix)
    {
        nom_item = nom;
        prix_item = prix;
    }

}

public class ItemLine
{
    public Item item { get; set; }
    public int quantite_item { get; set; }

    public ItemLine()
    {
        item = null;
        quantite_item=0;
    }
    public ItemLine(Item i, int q)
    {
        item = i;
        quantite_item = q;
    }
}

public class StockManager
{
    public List<ItemLine> AllLines;
    public ItemLine ReserveItem(int quantity, string name)
    {
        ItemLine i = new ItemLine();
        foreach(ItemLine line in AllLines)
        {
            if(line.item.nom_item == name)
            {
                line.quantite_item--;
                i = line;
            }
        }
        return i;
    }

    public void ReleaseItem(ItemLine line)
    {
        foreach(ItemLine itemline in AllLines)
        {
            if(itemline == line)
            {
                itemline.quantite_item++; //annule la reservation de l'item
            }
        }
    }
}



