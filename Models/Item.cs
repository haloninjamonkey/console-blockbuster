using System;

namespace Blockbuster.Models
{
  public class Item
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public Product Product { get; set; }

    public Item (Product product)
    {
      Product = product;
      Id = Guid.NewGuid ().ToString ();
      Name = Product.Name;
    }

  }
}
