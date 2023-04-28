// An undirected graph is a data structure that consists of a set of vertices and a set of edges,
// where each edge connects two vertices and has no direction.
// Undirected graphs can be implemented using a custom Vertex class and a Graph class,
// that provides methods for adding vertices and edges to the graph,
// and performing depth-first and breadth-first traversals of the graph.

namespace UndirectedGraphExample
{
    class Vertex
    {
        public int value;
        public List<Vertex> neighbors;

        public Vertex(int value)
        {
            this.value = value;
            neighbors = new List<Vertex>();
        }

        public void AddNeighbor(Vertex neighbor)
        {
            neighbors.Add(neighbor);
        }
    }

    class Graph
    {
        private List<Vertex> vertices;

        public Graph()
        {
            vertices = new List<Vertex>();
        }

        public void AddVertex(Vertex vertex)
        {
            vertices.Add(vertex);
        }

        public void AddEdge(Vertex vertex1, Vertex vertex2)
        {
            vertex1.AddNeighbor(vertex2);
            vertex2.AddNeighbor(vertex1);
        }

        public void DepthFirstTraversal(Vertex start)
        {
            HashSet<Vertex> visited = new HashSet<Vertex>();
            DepthFirstTraversalHelper(start, visited);
        }

        private void DepthFirstTraversalHelper(Vertex current, HashSet<Vertex> visited)
        {
            visited.Add(current);
            Console.WriteLine(current.value);

            foreach (Vertex neighbor in current.neighbors)
            {
                if (!visited.Contains(neighbor))
                {
                    DepthFirstTraversalHelper(neighbor, visited);
                }
            }
        }

        public void BreadthFirstTraversal(Vertex start)
        {
            Queue<Vertex> queue = new Queue<Vertex>();
            HashSet<Vertex> visited = new HashSet<Vertex>();

            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                Vertex current = queue.Dequeue();
                Console.WriteLine(current.value);

                foreach (Vertex neighbor in current.neighbors)
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            Vertex vertex1 = new Vertex(1);
            Vertex vertex2 = new Vertex(2);
            Vertex vertex3 = new Vertex(3);
            Vertex vertex4 = new Vertex(4);
            Vertex vertex5 = new Vertex(5);

            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);
            graph.AddVertex(vertex3);
            graph.AddVertex(vertex4);
            graph.AddVertex(vertex5);

            graph.AddEdge(vertex1, vertex2);
            graph.AddEdge(vertex1, vertex3);
            graph.AddEdge(vertex2, vertex3);
            graph.AddEdge(vertex2, vertex4);
            graph.AddEdge(vertex3, vertex4);
            graph.AddEdge(vertex4, vertex5);

            Console.WriteLine("Depth-First Traversal:");
            graph.DepthFirstTraversal(vertex1);

            Console.WriteLine("\nBreadth-First Traversal:");
            graph.BreadthFirstTraversal(vertex1);

            Console.ReadLine();
        }
    }
}
