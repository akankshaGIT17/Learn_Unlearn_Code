using System.Linq;
using System.Collections.Generic;
using System;
class CyclicDirectedGraph
{
    public static void Main(string[] args)
    {

        char[][] graph = new char[][]
                  {
 new char[]{ 'A','B'},

 new char[]{ 'B','A'},

 new char[]{ 'B','C'},

 new char[]{ 'C','B'},

 new char[]{ 'C','A'},

 new char[]{ 'A','C'},

                  };

        int nodes = 4;

        var hasCycle = MakeGraph(graph, nodes);

        Console.WriteLine($"Does the graph have a cycle ? ---> {hasCycle}");

        Console.ReadLine();

    }

    private static bool MakeGraph(char[][] graph, int nodes)
    {
        Dictionary<int, List<char>> ls = new Dictionary<int, List<char>>();

        bool[] visited = new bool[100];

        bool[] path = new bool[100];

        for (int i = 0; i < graph.Length; i++)
        {
            if (!ls.ContainsKey(graph[i][0]))
            {
                ls.Add(graph[i][0], new List<char>());
            }

            ls[graph[i][0]].Add(graph[i][1]);

        }

        for (int i = 0; i < ls.Count; i++)
        {
            if (HasCycle(ls, ls.ElementAt(i).Key, visited, -1))
                return true;
        }

        return false;

    }
    public static bool HasCycle(Dictionary<int, List<char>> connections, int start, bool[] visited, int parent)
    {
        visited[start] = true;
        // Traverse the graph starting from the start node.
        foreach (var item in connections[start])
        {

            if (!visited[item])
            {
                // This is our recursive call. If in our recursion we find a cycle, we immediately return a true.
                if (HasCycle(connections, item, visited, start))

                {
                    return true;
                }

            }

            var current = (int)item;
            // This is where the difference comes from the directed graph. As we traverse, we check whether the node is a parent.
            // If not then it means that a cycle has been found. We return true.
            if (current != parent)
            {
                return true;
            }

        }
        //If we haven't found a cycle we return false.
        return false;

    }
}