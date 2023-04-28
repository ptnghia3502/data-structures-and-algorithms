using System;
using System.Collections.Generic;

public class DijkstraAlgorithm
{
    private int V; // number of vertices
    private List<int>[] adj; // adjacency list
    private int[] dist; // array to store shortest distances
    private bool[] visited; // array to track visited vertices

    public DijkstraAlgorithm(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; i++)
        {
            adj[i] = new List<int>();
        }
        dist = new int[v];
        visited = new bool[v];
    }

    // function to add an edge to the graph
    public void AddEdge(int v, int w, int weight)
    {
        adj[v].Add(w);
        adj[w].Add(v);
    }

    // function to find the vertex with minimum distance value
    private int MinDistance()
    {
        int min = int.MaxValue, minIndex = -1;

        for (int v = 0; v < V; v++)
        {
            if (!visited[v] && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }
        }

        return minIndex;
    }

    // function to perform Dijkstra's algorithm
    public void Dijkstra(int start)
    {
        // initialize distances to infinity and visited to false
        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
        }

        // set the distance of the starting vertex to 0
        dist[start] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            // find the vertex with the minimum distance value
            int u = MinDistance();

            // mark the vertex as visited
            visited[u] = true;

            // update the distances of adjacent vertices
            foreach (int v in adj[u])
            {
                if (!visited[v] && dist[u] != int.MaxValue && dist[u] + 1 < dist[v])
                {
                    dist[v] = dist[u] + 1;
                }
            }
        }
    }

    // driver function to test the graph
    static void Main()
    {
        DijkstraAlgorithm g = new DijkstraAlgorithm(9);

        g.AddEdge(0, 1, 4);
        g.AddEdge(0, 7, 8);
        g.AddEdge(1, 2, 8);
        g.AddEdge(1, 7, 11);
        g.AddEdge(2, 3, 7);
        g.AddEdge(2, 8, 2);
        g.AddEdge(2, 5, 4);
        g.AddEdge(3, 4, 9);
        g.AddEdge(3, 5, 14);
        g.AddEdge(4, 5, 10);
        g.AddEdge(5, 6, 2);
        g.AddEdge(6, 7, 1);
        g.AddEdge(6, 8, 6);
        g.AddEdge(7, 8, 7);

        g.Dijkstra(0);

        Console.WriteLine("Vertex\tDistance from Start");
        for (int i = 0; i < g.V; i++)
        {
            Console.WriteLine(i + "\t" + g.dist[i]);
        }
    }
}
