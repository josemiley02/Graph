using Graph.Edge;
using Graph.Search.BFS;
using Graph.Vertex;
using Graph.Search.DFS;
namespace Graph;

public class Graph<T> : IGraph<T>
{
    public Graph(params T[] values)
    {
        foreach (var value in values)
        {
            AddVertex(value);
        }
    }
    public int VertexCount => Vertexs.Count;
    public int EdgeCount => Edges.Count;
    public int MaxDegree => Vertexs.Max(v => v.Degree);
    public int MinDegree => Vertexs.Min(v => v.Degree);
    private List<Vertex<T>> Vertexs = new List<Vertex<T>>();
    private List<Edge<T>> Edges = new List<Edge<T>>();

    public void AddEdge(T from, T to)
    {
        var vFrom = Vertexs.FirstOrDefault(v => v.Value!.Equals(from));
        var vTo = Vertexs.FirstOrDefault(v => v.Value!.Equals(to));
        if (vFrom is null || vTo is null)
        {
            throw new ArgumentException("Vertex not found");
        }
        var edge = new Edge<T>(vFrom, vTo);
        if (Edges.Any(e => e.Equals(edge)))
        {
            throw new ArgumentException("Edge already exists");
        }
        edge.From.Neighbors.Add(edge.To);
        edge.To.Neighbors.Add(edge.From);
        Edges.Add(edge);
    }

    public void AddVertex(T value)
    {
        if (Vertexs.Any(v => v.Value!.Equals(value)))
        {
            throw new ArgumentException("Vertex already exists");
        }
        var vertex = new Vertex<T>(value, Vertexs.Count);
        Vertexs.Add(vertex);
    }

    public IEnumerable<IEdge<T>> GetEdges()
    {
        return Edges;
    }

    public IEnumerable<IVertex<T>> GetVertexValues()
    {
        return Vertexs;
    }
    public BFS<T> BFS(T start)
    {
        var vStart = Vertexs.FirstOrDefault(v => v.Value!.Equals(start));
        if (vStart is null) throw new ArgumentException("Vertex not found");
        var BFS = new BFS<T>(this, vStart);
        BFS.Search();
        return BFS;
    }

    public DFS<T> DFS()
    {
        var DFS = new DFS<T>(this);
        DFS.Search();
        return DFS;
    }
}