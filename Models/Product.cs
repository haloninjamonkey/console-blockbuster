using System;

namespace Blockbuster.Models
{
  public class Product
  {
    public string Name { get; set; }
    public string SKU { get; set; }
    public Product(string name)
    {
        Name = name;
        SKU = Guid.NewGuid().ToString();
    }

  }
}
