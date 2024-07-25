using Graph.Vertex;

namespace Graph.Edge;

public class Edge<T> : IEdge<T>
{
    public Edge(IVertex<T> from, IVertex<T> to)
    {
        From = from;
        To = to;
    }
    public IVertex<T> From { get; }
    public IVertex<T> To { get; }

    public override string ToString()
    {
        return $"({{{From}, {To}}})";
    }
    public override bool Equals(object? obj)
    {
        if (obj is Edge<T> edge)
        {
            return From.Equals(edge.From) && To.Equals(edge.To);
        }
        return false;
    }
    public override int GetHashCode()
    {
        return From.GetHashCode() + To.GetHashCode();
    }
}