using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program Mad Libs
      Author: Omer Topcu
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Program started.");


      // Give the Mad Lib a title:
      string title = "MAD LIB GAME";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name:  ");
      string name = Console.ReadLine();
      Console.Write("Enter three adjectives respectively:  ");
      string adjective1 = Console.ReadLine();
      string adjective2 = Console.ReadLine();
      string adjective3 = Console.ReadLine();
      Console.Write("Enter a verb:  ");
      string verb = Console.ReadLine();
      Console.Write("Enter two nouns respectively:  ");
      string noun1 = Console.ReadLine();
      string noun2 = Console.ReadLine();
      Console.Write("Enter one of each of the following:\nAn animal\nA food\nA fruit\nA superhero\nA country\nA dessert\nA year\n\n");
      Console.Write("An animal:  ");
      string animal = Console.ReadLine();
      Console.Write("A food:  ");
      string food = Console.ReadLine();
      Console.Write("A fruit:  ");
      string fruit = Console.ReadLine();
      Console.Write("A superhero:  ");
      string superhero = Console.ReadLine();
      Console.Write("A country:  ");
      string country = Console.ReadLine();
      Console.Write("A dessert:  ");
      string dessert = Console.ReadLine();
      Console.Write("A year:  ");
      string year = Console.ReadLine();



      // The template for the story:

      string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine($"\n***{name.ToUpper()}'s STORY***\n");
      Console.WriteLine(story);

    }
  }
}
