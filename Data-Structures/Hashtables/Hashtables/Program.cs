using System;
using Hashtables.Classes;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable<string> ht = new Hashtable<string>();
            ht.Add(new Node<string>() { Key = "Cat", Value = "Jessy" });
            ht.Add(new Node<string>() { Key = "Doe", Value = "Tess" });// the same bucket as for "Cat"
            ht.Add(new Node<string>() { Key = "Dog", Value = "Goldy" });
            ht.Add(new Node<string>() { Key = "Candy", Value = "Hershy Kisses" });
            Console.WriteLine("Initial hashtable is:");
            ht.ToList().ForEach(elm => Console.Write($"{elm.Key}:{elm.Value}, "));
            Console.WriteLine();
            Console.WriteLine($"The value for the key 'Cat': {ht.Find("Cat").Value}");
            Console.WriteLine($"The value for the key 'Cat': {ht.Find("Doe").Value}");
            Console.WriteLine($"Do we have key 'Dove' in our dictionary: {ht.Contains("Dove").ToString()}");
            Console.WriteLine($"Do we have key 'Dove' in our dictionary: {ht.Contains("Candy").ToString()}");
            Console.ReadLine();
        }
    }
}
