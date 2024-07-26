using Graph;

namespace Main;

public static class Program
{
    public static void Main()
    {
        Graph<char> graph = new Graph<char>('B','C','D','E','S','V');
        graph.AddEdge('S','B');
        graph.AddEdge('S','C');
        graph.AddEdge('B','D');
        graph.AddEdge('C','D');
        graph.AddEdge('C','E');
        graph.AddEdge('E','V');

        var bfs = graph.BFS('S');
    }
}