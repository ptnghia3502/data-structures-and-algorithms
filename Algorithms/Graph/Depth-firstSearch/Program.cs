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

    // depth-first search function
    private void DFSUtil(int v, bool[] visited)
    {
        visited[v] = true; // mark the current vertex as visited
        Console.Write(v + " "); // print the vertex

        // recursively visit all adjacent vertices of the current vertex
        foreach (int i in adj[v])
        {
            if (!visited[i])
            {
                DFSUtil(i, visited);
            }
        }
    }

    public void DFS(int s)
    {
        bool[] visited = new bool[V]; // initialize all vertices as not visited
        DFSUtil(s, visited); // recursively visit all vertices
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

        Console.WriteLine("Following is Depth First Traversal " + "(starting from vertex 2)");

        g.DFS(2);
    }
}
