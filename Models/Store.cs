using System;
using System.Collections.Generic;

namespace Blockbuster.Models
{
  public class Store
  {
    public string Name { get; set; }
    public string Address { get; private set; }
    public Dictionary<Product, List<Item>> Inventory = new Dictionary<Product, List<Item>> ();

    public void ShowGreeting ()
    {
      System.Console.WriteLine ($@"
Welcome to {Name}
=====================================================================
We currently have {Inventory.Count} product(s) available for rent or purchase

      ");

      foreach (var product in Inventory)
      {
        System.Console.WriteLine ($"{product.Value[0].Name} {product.Value.Count}");

      }
    }

    public void AddItem (Item item)
    {
      if (Inventory.ContainsKey (item.Product))
      {
        Inventory[item.Product].Add (item);
        return;
      }

      Inventory.Add (item.Product, new List<Item> () { item });

    }

    public Store (string name, string address)
    {
      Name = name;
      Address = address;
    }

  }
}
