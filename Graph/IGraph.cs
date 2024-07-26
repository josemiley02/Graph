using Graph.Edge;
using Graph.Vertex;
namespace Graph;

public interface IGraph<T>
{
    int VertexCount { get; }
    int EdgeCount { get; }
    int MaxDegree { get; }
    int MinDegree { get; }
    void AddVertex(T value);
    void AddEdge(T from, T to);
    IEnumerable<IVertex<T>> GetVertexValues();
    IEnumerable<IEdge<T>> GetEdges();
}