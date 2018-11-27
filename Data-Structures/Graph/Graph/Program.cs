using Graph.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Graph
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // elements of a graph to generate
            int numberOfElements = 15;
            int lowerBoundOfWeights = 0;
            int upperBoundOfWeights = 30;
            Random rnd = new Random();
            // use letters starting with 'A' as a vertices names 
            List<string> letters = Enumerable.Range(65, numberOfElements).Select(elm => ((char)elm).ToString()).ToList();
            Graph<string> graph = new Graph<string>();
            letters.ForEach(letter => graph.AddNode(letter));
            // get all vertices of a newly created graph
            List<Vertex<string>> vertices = graph.GetNodes();
            // generate 10 random edges
            for (int i = 0; i < numberOfElements; i++)
            {
                // take two random vertices
                List<Vertex<string>> pair = vertices.OrderByDescending(_ => rnd.Next(0, 10)).Take(2).ToList();
                // add edge with a random weight
                graph.AddEdge(pair[0], pair[1], rnd.Next(lowerBoundOfWeights, upperBoundOfWeights));
            }

            // output the graph to the console 
            Console.Write("Adjacency list respresentation of a random graph");
            foreach (var item in graph)
            {
                Console.WriteLine();
                Console.Write($"{item.Value}: ");
                graph.GetNeighbors(item)
                    .ToList()
                    .ForEach(elm => Console.Write($"[{elm.Key}, {elm.Value}], "));
            }
            Console.ReadLine();
        }
    }
}
