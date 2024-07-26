using Graph.Edge;
using Graph.Vertex;
namespace Graph.Search.BFS;

public class BFS<T>
{
    public int[] Distances { get; }
    public Vertex<T>[] Parents { get; }
    private Graph<T> _graph;
    private Vertex<T> _start;
    public BFS(Graph<T> graph, Vertex<T> start)
    {
        _graph = graph;
        _start = start;
        Distances = new int[graph.VertexCount];
        for (int i = 0; i < Distances.Length; i++)
        {
            Distances[i] = int.MaxValue;
        }
        Parents = new Vertex<T>[_graph.VertexCount];
    }
    public void Search()
    {
        Distances[_start.Id] = 0;
        var queue = new Queue<Vertex<T>>();
        queue.Enqueue(_start);
        while (queue.Count > 0)
        {
            var vertex = queue.Dequeue();
            foreach (var neighbor in vertex.Neighbors)
            {
                if (Distances[neighbor.Id] == int.MaxValue)
                {
                    Distances[neighbor.Id] = Distances[vertex.Id] + 1;
                    Parents[neighbor.Id] = vertex;
                    queue.Enqueue((Vertex<T>)neighbor);
                }
            }
        }
    }
}