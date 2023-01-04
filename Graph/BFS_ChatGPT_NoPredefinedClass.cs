// Without using the defined class

using System;
using System.Collections.Generic;

public class Graph
{
    private int numVertices;
    private List<int>[] adjacencyList;

    public Graph(int numVertices)
    {
        this.numVertices = numVertices;
        adjacencyList = new List<int>[numVertices];
        for (int i = 0; i < numVertices; i++)
        {
            adjacencyList[i] = new List<int>();
        }
    }

    public void AddEdge(int source, int destination)
    {
        adjacencyList[source].Add(destination);
    }

    public void BFS(int startVertex)
    {
        bool[] visited = new bool[numVertices];
        int[] queue = new int[numVertices];
        int front = 0;
        int rear = 0;

        visited[startVertex] = true;
        queue[rear] = startVertex;
        rear++;

        while (front != rear)
        {
            int currentVertex = queue[front];
            front++;
            Console.Write(currentVertex + " ");

            foreach (int neighbor in adjacencyList[currentVertex])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    queue[rear] = neighbor;
                    rear++;
                }
            }
        }
    }
}
//// Main class

Graph graph = new Graph(4);
graph.AddEdge(0, 1);
graph.AddEdge(0, 2);
graph.AddEdge(1, 2);
graph.AddEdge(2, 0);
graph.AddEdge(2, 3);
graph.AddEdge(3, 3);

Console.WriteLine("BFS starting at vertex 2:");
graph.BFS(2);
