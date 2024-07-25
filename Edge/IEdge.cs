using Graph.Vertex;

namespace Graph.Edge;

public interface IEdge<T>
{
    IVertex<T> From {get;}
    IVertex<T> To {get;}
}