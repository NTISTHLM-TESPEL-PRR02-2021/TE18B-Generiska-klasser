using System.Net;
using System;
using System.Collections.Generic;

namespace GeneriskaKlasser
{
  class Program
  {

    static void Main(string[] args)
    {

      // Klassdiagram: Variabler, datatyper, metoder, arv
      // Generiska klasser, Klasser, instanser, Arv

      // Nätverk

      // Gränssnitt
      // Kommentarer, namngivning
      // Robusthet

      // Creature<string> c = new Creature<string>();
      // Creature<int> c2 = new Creature<int>();

      // c.category = "6";
      // c2.category = 6;

      // Queue<string> orders = new Queue<string>();

      // orders.Enqueue("walk");
      // orders.Enqueue("stand");
      // orders.Enqueue("patrol");

      // string order = orders.Dequeue();

      // Console.WriteLine(orders);

      // Dictionary<string, string> words = new Dictionary<string, string>();

      // words.Add("RPG", "Role-playing game");

      // Console.WriteLine(words["RPG"]);

      Dictionary<string, Action> actions = new Dictionary<string, Action>();

      actions.Add("walk", Walk);
      actions.Add("patrol", Patrol);

      string userAction = Console.ReadLine();

      actions[userAction]();


      Console.ReadLine();

    }

    public static void Walk()
    {
      Console.WriteLine("Walking");
    }

    public static void Patrol()
    {
      Console.WriteLine("Patrolling");
    }
  }
}
