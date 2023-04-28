class Graph
{
    private int V; // number of vertices
    private LinkedList<int>[] adj; // adjacency list

    // constructor
    public Graph(int v)
    {
        V = v;
        adj = new LinkedList<int>[v];
        for (int i = 0; i < v; i++)
        {
            adj[i] = new LinkedList<int>();
        }
    }

    // function to add an edge to the graph
    public void AddEdge(int v, int w)
    {
        adj[v].AddLast(w);
    }

    // breadth-first search function
    public void BFS(int s)
    {
        bool[] visited = new bool[V]; // initialize all vertices as not visited
        Queue<int> queue = new Queue<int>(); // create a queue for BFS

        visited[s] = true; // mark the current vertex as visited
        queue.Enqueue(s); // enqueue the current vertex

        while (queue.Count != 0)
        {
            s = queue.Dequeue(); // dequeue a vertex from the queue and print it
            Console.Write(s + " ");

            // get all adjacent vertices of the dequeued vertex s
            // if an adjacent vertex has not been visited, mark it visited
            // and enqueue it to the queue
            foreach (int i in adj[s])
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    queue.Enqueue(i);
                }
            }
        }
    }

    // driver function to test the graph
    static void Main()
    {
        Graph g = new Graph(4);

        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 2);
        g.AddEdge(2, 0);
        g.AddEdge(2, 3);
        g.AddEdge(3, 3);

        Console.WriteLine("Following is Breadth First Traversal " + "(starting from vertex 2)");

        g.BFS(2);
    }
}
