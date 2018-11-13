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
            Console.WriteLine(ht.Find("Cat").Value);
            Console.WriteLine(ht.Find("Doe").Value);
            Console.ReadLine();
        }
    }
}
