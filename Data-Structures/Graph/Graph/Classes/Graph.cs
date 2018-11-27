using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph.Classes
{
    public class Graph<T> : IEnumerable<Vertex<T>>
    {
        /// <summary>
        /// internal storage for a graph as adjacency list with weights:  
        /// </summary>
        private Dictionary<Vertex<T>, Dictionary<Vertex<T>, int>> _graph { get; set; }

        /// <summary>
        /// Initialize a new empty graph
        /// </summary>
        public Graph()
        {
            _graph = new Dictionary<Vertex<T>, Dictionary<Vertex<T>, int>>();
        }

        /// <summary>
        /// Get all nodes of the graph
        /// </summary>
        /// <returns>List of vertices</returns>
        public List<Vertex<T>> GetNodes()
        {
            return _graph.Keys.ToList();
        }

        /// <summary>
        /// Get the size of a graph
        /// </summary>
        /// <returns>Number of vertices in a graph</returns>
        public int Size()
        {
            return _graph.Count;
        }

        /// <summary>
        /// Add value as a vertex to a graph
        /// </summary>
        /// <param name="value">Value to be added as a vertex to a graph</param>
        public void AddNode(T value)
        {
            Vertex<T> newVertex = new Vertex<T>(value);
            AddNode(newVertex);
        }

        /// <summary>
        /// Add a vertex to a graph
        /// </summary>
        /// <param name="vertex">Vertex to be added as a vertex to a graph</param>
        public void AddNode(Vertex<T> vertex)
        {
            if (!_graph.ContainsKey(vertex))
                _graph.Add(vertex, new Dictionary<Vertex<T>, int>());
            else
                throw new Exception($"The vertex with a value '{vertex.Value}' already exists.");
        }

        /// <summary>
        /// Add a new edge between vertices in a graph
        /// </summary>
        /// <param name="vertex1">First vertex</param>
        /// <param name="vertex2">Second vertex</param>
        /// <param name="weight">Weight of the edge</param>
        public void AddEdge(Vertex<T> vertex1, Vertex<T> vertex2, int weight)
        {
            bool vertex1Exists = _graph.ContainsKey(vertex1);
            bool vertex2Exists = _graph.ContainsKey(vertex2);
            if (!vertex1Exists)
                AddNode(vertex1);
            Dictionary<Vertex<T>, int> neighbors1 = GetNeighbors(vertex1);
            if(!neighbors1.ContainsKey(vertex2))
                neighbors1.Add(vertex2, weight);


            if (!vertex2Exists)
                AddNode(vertex2);
            Dictionary<Vertex<T>, int> neighbors2 = GetNeighbors(vertex2);
            if(!neighbors2.ContainsKey(vertex1))
                neighbors2.Add(vertex1, weight);
        }

        /// <summary>
        /// Get all neighbors for a given vertex from a graph
        /// </summary>
        /// <param name="node">A parent vertex</param>
        /// <returns>Dictionary of parent vertex's neighbors</returns>
        public Dictionary<Vertex<T>, int> GetNeighbors(Vertex<T> vertex)
        {
            Dictionary<Vertex<T>, int> neighbors;
            if (_graph.TryGetValue(vertex, out neighbors))
                return neighbors;
            throw new Exception("No such vertex.");
        }

        /// <summary>
        /// Make graph vertices iterable
        /// </summary>
        /// <returns>Generic enumerator</returns>
        public IEnumerator<Vertex<T>> GetEnumerator()
        {
            return _graph.Keys.ToList().GetEnumerator();
        }

        /// <summary>
        /// Make graph vertices iterable
        /// </summary>
        /// <returns>Enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
