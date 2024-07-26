using Graph.Vertex;
using Graph.Edge;
namespace Graph.Search.DFS;

public class DFS<T>
{
    public int[] DiscoverTime { get; }
    public int[] FinishTime { get; }
    public Vertex<T>[] Parents { get; }
    public int CC { get; private set; }
    private Graph<T> _graph;
    private bool[] Visited;
    private int time = 0;
    public DFS(Graph<T> graph)
    {
        _graph = graph;
        DiscoverTime = new int[graph.VertexCount];
        FinishTime = new int[graph.VertexCount];
        Parents = new Vertex<T>[graph.VertexCount];
        Visited = new bool[graph.VertexCount];
        CC = 0;
    }
    public void Search()
    {
        CC = 1;
        foreach (var item in _graph.GetVertexValues())
        {
            if (!Visited[item.Id])
            {
                Update((Vertex<T>)item);
            }
        }
    }
    private void Update(Vertex<T> vertex)
    {
        time += 1;
        DiscoverTime[vertex.Id] = time;
        Visited[vertex.Id] = true;
        CC += 1;
        foreach (var neighbor in vertex.Neighbors)
        {
            if (!Visited[neighbor.Id])
            {
                Parents[neighbor.Id] = vertex;
                Update((Vertex<T>)neighbor);
            }
        }
        time += 1;
        FinishTime[vertex.Id] = time;
    }
}