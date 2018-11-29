using System;
using Xunit;
using Graph.Classes;
using getEdges;

namespace getEdgesTests
{
    public class GetEdgeTests
    {
        /// <summary>
        /// Can return True and travel costs when direct route exists
        /// </summary>
        [Fact]
        public void GetEdges_onCitiesWithDirectRoute_ReturnsTrueAndCost()
        {
            // arrange
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertex1 = new Vertex<string>("Vertex1");
            Vertex<string> vertex2 = new Vertex<string>("Vertex2");
            int cost = 1;
            string expecterResult = $"True, ${cost}";
            // act
            graph.AddEdge(vertex1, vertex2, cost);
            // assert
            Assert.Equal(expecterResult, Program.GetEdge(graph, new string[] { vertex1.Value, vertex2.Value }));

        }
        /// <summary>
        /// Can return False and travel costs 0 when direct route does not exist
        /// </summary>
        [Fact]
        public void GetEdges_onCitiesWithOutDirectRoute_ReturnsFalseAndZero()
        {
            // arrange
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertex1 = new Vertex<string>("Vertex1");
            Vertex<string> vertex2 = new Vertex<string>("Vertex2");
            Vertex<string> vertex3 = new Vertex<string>("Vertex3");
            int cost = 1;
            int costZero = 0;
            string expecterResult = $"False, ${costZero}";
            // act
            graph.AddEdge(vertex1, vertex2, cost);
            graph.AddEdge(vertex2, vertex3, cost);
            // assert
            Assert.Equal(expecterResult, Program.GetEdge(graph, new string[] { vertex1.Value, vertex3.Value }));
        }
        /// <summary>
        /// Can return True and total travel costs for multiple cities itinerary
        /// </summary>
        [Fact]
        public void GetEdges_onMultipleCitiesItinerary_ReturnsTrueAndTotalCost()
        {
            // arrange
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertex1 = new Vertex<string>("Vertex1");
            Vertex<string> vertex2 = new Vertex<string>("Vertex2");
            Vertex<string> vertex3 = new Vertex<string>("Vertex3");
            int cost = 1;
            string expecterResult = $"True, ${cost + cost}";
            // act
            graph.AddEdge(vertex1, vertex2, cost);
            graph.AddEdge(vertex2, vertex3, cost);
            // assert
            Assert.Equal(expecterResult, Program.GetEdge(graph, new string[] { vertex1.Value, vertex2.Value, vertex3.Value }));
        }
    }
}
