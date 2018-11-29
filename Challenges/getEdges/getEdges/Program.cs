using Graph.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace getEdges
{
    public class Program
    {
        public static string GetEdge(Graph<string> graph, string[] cities)
        {
            int totalCost = 0;
            for (int i = 0; i < cities.Length - 1; i++)
            {
                int weight = 0;
                Dictionary<Vertex<string>, int> neighbors = graph.GetNeighbors(new Vertex<string>(cities[i]));
                if (!neighbors.TryGetValue(new Vertex<string>(cities[i + 1]), out weight))
                {
                    return "False, $0";
                }

                totalCost += weight;
            }
            return $"True, ${totalCost}";
        }

        private static void Main(string[] args)
        {
            Graph<string> graph = new Graph<string>();

            Vertex<string> vPandora = new Vertex<string>("Pandora");
            Vertex<string> vMetroville = new Vertex<string>("Metroville");
            Vertex<string> vArendelle = new Vertex<string>("Arendelle");
            Vertex<string> vNewMonstropolis = new Vertex<string>("New Monstropolis");
            Vertex<string> vNaboo = new Vertex<string>("Naboo");
            Vertex<string> vNarnia = new Vertex<string>("Narnia");

            graph.AddEdge(vPandora, vArendelle, 150);
            graph.AddEdge(vPandora, vMetroville, 82);

            graph.AddEdge(vArendelle, vNewMonstropolis, 42);
            graph.AddEdge(vArendelle, vMetroville, 99);

            graph.AddEdge(vMetroville, vNewMonstropolis, 105);
            graph.AddEdge(vMetroville, vNaboo, 26);
            graph.AddEdge(vMetroville, vNarnia, 37);

            graph.AddEdge(vNewMonstropolis, vNaboo, 73);

            graph.AddEdge(vNaboo, vNarnia, 250);


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
            Console.WriteLine();
            Console.WriteLine();
            string[] itinerary = new string[] { "Metroville", "Pandora" };
            string itineraryStr = string.Join(" -> ", itinerary);
            Console.WriteLine($"Itinerary {itineraryStr} with direct flights exists: {GetEdge(graph, itinerary)}");

            itinerary = new string[] { "Arendelle", "New Monstropolis", "Naboo" };
            itineraryStr = string.Join(" -> ", itinerary);
            Console.WriteLine($"Itinerary {itineraryStr} with direct flights exists: {GetEdge(graph, itinerary)}");

            itinerary = new string[] { "Naboo", "Pandora" };
            itineraryStr = string.Join(" -> ", itinerary);
            Console.WriteLine($"Itinerary {itineraryStr} with direct flights exists: {GetEdge(graph, itinerary)}");

            itinerary = new string[] { "Narnia", "Arendelle, Naboo" };
            itineraryStr = string.Join(" -> ", itinerary);
            Console.WriteLine($"Itinerary {itineraryStr} with direct flights exists: {GetEdge(graph, itinerary)}");

            itinerary = new string[] { "Pandora", "Arendelle", "Metroville", "New Monstropolis", "Naboo", "Narnia" };
            itineraryStr = string.Join(" -> ", itinerary);
            Console.WriteLine($"Itinerary {itineraryStr} with direct flights exists: {GetEdge(graph, itinerary)}");

            Console.ReadLine();
        }
    }
}
