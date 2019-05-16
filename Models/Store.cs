using System;
using System.Collections.Generic;

namespace Blockbuster.Models
{
  public class Store
  {
    public string Name { get; set; }
    public string Address { get; private set; }
    public Dictionary<Product, List<Item>> Inventory = new Dictionary<Product, List<Item>> ();
    public Dictionary<Genres,List<Movie>> Movies = new Dictionary<Genres, List<Movie>>();

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
    public void DisplayGenres()
    {
        // int i = 0;
      foreach(KeyValuePair<Genres, List<Movie>> movie in Movies)
      {
        System.Console.WriteLine(movie.Value[0].Name);
        System.Console.WriteLine($"{(int)movie.Key}. {movie.Key}: {movie.Value.Count}");
      }
      System.Console.WriteLine("Enter a Genre to browse videos: ");
      SelectGenre();
    }
    public void SelectGenre()
    {
      Genres targetGenre;
      try
      {
      while(!Enum.TryParse(Console.ReadLine(), true, out targetGenre))
        {
          System.Console.WriteLine("Not a valid genre.");
        }
        ListMoviesByGenre(targetGenre);

      } catch(KeyNotFoundException e){
        System.Console.WriteLine("Not a valid number: " + e);
        System.Console.WriteLine("Please make another choice.");
        SelectGenre();
      }
      
    }

    public void ListMoviesByGenre(Genres genre)
    {
      //declared placeholder variable
      Dictionary<string, int> availableMovies = new Dictionary<string, int>();
      //iterate over the genre list and total up the copies of each movie
      foreach(Movie movie in Movies[genre])
      {
        if(!availableMovies.ContainsKey(movie.Name)){
          availableMovies[movie.Name] = 0;
        }
        availableMovies[movie.Name]++;
      }
      // display to the user each key/value pair within available movies
      foreach(var kvp in availableMovies)
      {
        System.Console.WriteLine("{0} - number of copies available: {1}", kvp.Key, kvp.Value);
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

    public void AddItem(Movie movie)
    {
      if(!Movies.ContainsKey(movie.Genres))
      {
        Movies.Add(movie.Genres, new List<Movie>());
      }
      Movies[movie.Genres].Add(movie);
      AddItem(movie as Item);
    }

    public Store (string name, string address)
    {
      Name = name;
      Address = address;
    }

  }
}
