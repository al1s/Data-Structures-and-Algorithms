using System;
using Xunit;
using Graph.Classes;
using System.Linq;
using System.Collections.Generic;

namespace GraphTests
{
    public class GraphTesting
    {
        /// <summary>
        /// Tests whether can create an object of a required type
        /// </summary>
        [Fact]
        public void CanCreateANewGraph()
        {
            // arrange
            // act
            Graph<string> graph = new Graph<string>();
            // assert
            Assert.IsType<Graph<string>>(graph);
        }

        /// <summary>
        /// Can get nodes from a graph
        /// </summary>
        /// <param name="numberOfNodes">Number of nodes to add</param>
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(100)]
        public void WhenGraphHasNodes_OnGetNodes_ReturnsAllNodes(int numberOfNodes)
        {
            // arrange
            IEnumerable<int> range = Enumerable.Range(0, numberOfNodes).Select(elm => elm);
            Graph<int> graph = new Graph<int>();
            // act
            range.ToList().ForEach(elm => graph.AddNode(elm)); 
            // assert
            Assert.Equal(range.Count(), graph.GetNodes().Count);
        }

        /// <summary>
        /// Can add a new node with a value to a graph
        /// </summary>
        [Fact]
        public void OnAddNewValueToGraph_NodeAdded()
        {
            // arrange
            string expectedValue = "A";
            Graph<string> graph = new Graph<string>();
            // act
            graph.AddNode(expectedValue);
            // assert
            Assert.IsType<Vertex<string>>(graph.GetNodes()[0]);
            Assert.Equal(expectedValue, graph.GetNodes()[0].Value);
        }

        /// <summary>
        /// Can throw an exception if adding a node with existing value to a graph
        /// </summary>
        [Fact]
        public void OnAddSameValueToGraph_ExceptionThrown()
        {
            // arrange
            string value = "A";
            Graph<string> graph = new Graph<string>();
            string exceptionMsg = "The vertex with a value 'A' already exists.";
            // act
            graph.AddNode(value);
            // assert
            Exception ex = Assert.Throws<Exception>(() => graph.AddNode(value));
            Assert.Equal(exceptionMsg, ex.Message);
        }

        /// <summary>
        /// Can get number of nodes from a graph
        /// </summary>
        /// <param name="expectedNumberOfNodes">Number of nodes to add</param>
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(100)]
        public void WhenGraphHasNodes_OnSize_ReturnsNumberOfNodes(int expectedNumberOfNodes)
        {
            // arrange
            IEnumerable<int> range = Enumerable.Range(0, expectedNumberOfNodes).Select(elm => elm);
            Graph<int> graph = new Graph<int>();
            // act
            range.ToList().ForEach(elm => graph.AddNode(elm)); 
            // assert
            Assert.Equal(range.Count(), graph.Size());
        }
        
        /// <summary>
        /// Can create an edge between two vertices in a graph
        /// </summary>
        [Fact]
        public void ForGraphWithNodes_OnAddEdge_BothNodesHaveNeighbors()
        {
            // arrange
            Vertex<string> vertex1 = new Vertex<string>("Vertex1");
            Vertex<string> vertex2 = new Vertex<string>("Vertex2");
            Graph<string> graph = new Graph<string>();
            graph.AddNode(vertex1);
            graph.AddNode(vertex2);
            // act
            graph.AddEdge(vertex1, vertex2, 0);
            Dictionary<Vertex<string>, int> neighbors1 = graph.GetNeighbors(vertex1);
            Dictionary<Vertex<string>, int> neighbors2 = graph.GetNeighbors(vertex2);
            // assert
            Assert.Contains(vertex1, neighbors2.Keys);
            Assert.Contains(vertex2, neighbors1.Keys);
        }

        /// <summary>
        /// Can create an edge between two new vertices in a graph
        /// </summary>
        [Fact]
        public void ForGraphWithOutNodes_OnAddEdge_BothNodesHaveNeighbors()
        {
            // arrange
            Vertex<string> vertex1 = new Vertex<string>("Vertex1");
            Vertex<string> vertex2 = new Vertex<string>("Vertex2");
            Graph<string> graph = new Graph<string>();
            // act
            graph.AddEdge(vertex1, vertex2, 0);
            Dictionary<Vertex<string>, int> neighbors1 = graph.GetNeighbors(vertex1);
            Dictionary<Vertex<string>, int> neighbors2 = graph.GetNeighbors(vertex2);
            // assert
            Assert.Contains(vertex1, neighbors2.Keys);
            Assert.Contains(vertex2, neighbors1.Keys);
        }

        /// <summary>
        /// Can create an edge between two vertices in a graph with a weight
        /// </summary>
        [Fact]
        public void ForGraphWithNodes_OnAddEdge_BothNodesHaveNeighborsWithWeight()
        {
            // arrange
            Vertex<string> vertex1 = new Vertex<string>("Vertex1");
            Vertex<string> vertex2 = new Vertex<string>("Vertex2");
            Graph<string> graph = new Graph<string>();
            graph.AddNode(vertex1);
            graph.AddNode(vertex2);
            // act
            graph.AddEdge(vertex1, vertex2, 0);
            Dictionary<Vertex<string>, int> neighbors1 = graph.GetNeighbors(vertex1);
            Dictionary<Vertex<string>, int> neighbors2 = graph.GetNeighbors(vertex2);
            // assert
            Assert.Contains(0, neighbors2.Values);
            Assert.Contains(0, neighbors1.Values);
            Assert.True(neighbors1.Values.All(elm => elm == 0));
        }
    }
}
