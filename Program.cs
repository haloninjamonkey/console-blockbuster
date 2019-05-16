﻿using System;
using Blockbuster.Models;

namespace Blockbuster
{
    class Program
    {
        static void Main (string[] args)
        {
            var harryPotter1 = new Product ("Harry Potter and the Philosophers Stone");
            var harryPotter2 = new Product ("Harry Potter and the Chamber of Secrets");


            var hp1 = new Movie ("Harry Potter 1", "A boy becomes a wizard", 2001, harryPotter1, Genres.Fantasy);
            var hp2 = new Movie ("Harry Potter 1", "A boy becomes a wizard", 2001, harryPotter1, Genres.Fantasy);
            var hp3 = new Movie ("Harry Potter 1", "A boy becomes a wizard", 2001, harryPotter1, Genres.Fantasy);
            var hp4 = new Movie ("Harry Potter 1", "A boy becomes a wizard", 2001, harryPotter1, Genres.Fantasy);
            var hp6 = new Movie ("Harry Potter 1", "A boy becomes a wizard", 2001, harryPotter1, Genres.Action);
            var hp7 = new Movie ("It", "Stay away from sewers", 2001, harryPotter1, Genres.Horror);
            var hp8 = new Movie ("Avengers", "Earth's Mightiest Heroes", 2001, harryPotter1, Genres.Superhero);
            
            
            var hp5 = new Movie ("Harry Potter 2", "A boy becomes a better wizard", 2003, harryPotter2, Genres.Fantasy);


            var hollywoodVideo = new Store ("Hollywood Video", "123 N. Dunder Street");

            hollywoodVideo.AddItem(hp1);
            hollywoodVideo.AddItem(hp2);
            hollywoodVideo.AddItem(hp3);
            hollywoodVideo.AddItem(hp5);
            hollywoodVideo.AddItem(hp8);
            hollywoodVideo.AddItem(hp7);
            hollywoodVideo.AddItem(hp6);



            hollywoodVideo.ShowGreeting ();
            hollywoodVideo.DisplayGenres();

        }
    }
}
