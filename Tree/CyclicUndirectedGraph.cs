using System.Linq;
using System.Collections.Generic;
using System;
 class CyclicUndirectedGraph
{
    public static void Main(string[] args)
       {
 // Created the jagged array. It contains the vertexes and how they are to be connected.
 // E.g. new int[]{ 1,2}, means 1 is to be connected to 2
 int[][] graph = new int[][]
           {

 new int[]{ 1,2},

 new int[]{ 1,3},

 new int[]{ 1,4},

 new int[]{ 1,5},

 new int[]{ 2,6},

 new int[]{ 2,7},

 new int[]{ 3,4},

 new int[]{ 4,1},

           };
 // this is the total number of nodes in our graph
 int nodes = 8;
 // we call the MakeGraph method. This is the method that will constract the graph for us.
 var hasCycle = MakeGraph(graph, nodes);
 // This will print for us the result on the output window. If we find a cycle it will print:
 //Does the graph have a cycle ? ---> true
 // If the graph does not have a cycle it will print
 //Does the graph have a cycle ? ---> false
 Console.WriteLine($"Does the graph have a cycle ? ---> {hasCycle}");

 // A built-in c# Static method that reads the next line of character.
 //The result will stay on the output window when we add this line.
 Console.ReadLine();

       }

 
 private static bool MakeGraph(int[][] graph, int nodes)
       {
 // This is the dictionary for storing the adjacency list.
 //It is of the type, int that will hold a node and List<int> that will hold all other nodes 
 //attached to the int node.
 /* E.G. This is how our graph will look like 
                    1-> 2,3,4
                    2-> 6,7
                    3-> 4
                    4-> 1
                */
 Dictionary<int, List<int>> ls = new Dictionary<int, List<int>>();
 // We declare a visited bool array variable. We will store the visited nodes in it.
 bool[] visited = new bool[nodes];
 // We declare a path bool array variable. We will store all nodes in our current path here.
 bool[] path = new bool[nodes];
 // Loop through our jagged array, graph.
 for (int i = 0; i < graph.Length; i++)
           {
 // As we loop, check whether our dictionary already contains the node at index[i][0]
 // of our jagged array, graph. If it is not there, we add it to the dictionary, ls
 if (!ls.ContainsKey(graph[i][0]))
               {
 ls.Add(graph[i][0], new List<int>());
               }
 // this line of code will connect the nodes. E.g. If we are given { 1,2}, we added 1 to our dictionary
 // on the line  ls.Add(graph[i][0], new List<int>());
 //Therefore, in this next line,ls[graph[i][0]].Add(graph[i][1]); we connect the 1 to the 2
 ls[graph[i][0]].Add(graph[i][1]);

           }
 // We start our traversal here. We could also say that this is where we start our path from.
 for (int i = 0; i < nodes; i++)
           {
 // We do our Dfs starting from the node at i in this case our start point will be 0;
 // For each Dfs, we are checking if we will find a cycle. If yes, we immediately return true.
 // A cycle has been found.
 if (Dfs(ls, i, visited, path))

 return true;

           }
 // If in our for loop above, we never found a cycle, then we will return false.
 // A cycle was not detected.
 return false;

       }

 private static bool Dfs(Dictionary<int, List<int>> graph, int start, bool[] visited, bool[] path)
       {
 // If we find that we marked path[start] true, we return true.
 // This means that we have come back to the node we started from hence a cycle has
 // been found.
 if (path[start])
           {
 return true;
           }
 // If we didn't find a cycle from the code block above, we mark visited[start] to true.
 visited[start] = true;

 //  We also mark path[start] to true. This will help us know that the node start is on our
 //  current path.
 path[start] = true;

 // We check whether our graph contains the start node. Sometimes the start node is not in our graph.
 // Thus, if we do our traversal on such a node, an exception will be thrown. This is because the node does
 // not exist.
 if (graph.ContainsKey(start))
           {
 // We start our traversal from our start node of the graph.
 foreach (var item in graph[start])

               {
 //We do our recursion
 // At this point, if the start node returned a true in our recursive call, then we say that cycle has been
 // found. We return true immediately.
 if (Dfs(graph, item, visited, path))
                   {
 return true;
                   }

               }

           }
 // If we have traversed the whole path from the start node and never found a cycle, we start removing
 // those nodes from this path. This is done recursively using c# inbuilt stack also called the call stack.
 path[start] = false;
 // If we did not find a cycle, we return false.
 return false;

       }
}
