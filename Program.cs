using Graph;

namespace Main;

public static class Program
{
    public static void Main()
    {
        Graph<char> graph = new Graph<char>('s', 'r', 'v', 'w', 't', 'u', 'x', 'y');
        graph.AddEdge('s', 'r');
        graph.AddEdge('r', 'v');
        graph.AddEdge('s', 'w');
        graph.AddEdge('w', 't');
        graph.AddEdge('w', 'x');
        graph.AddEdge('t', 'u');
        graph.AddEdge('u', 'x');
        graph.AddEdge('u', 'y');
        graph.AddEdge('x', 't');
        graph.AddEdge('x', 'y');

        var dfs = graph.DFS();
    }
}