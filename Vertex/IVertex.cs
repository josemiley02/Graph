namespace Graph.Vertex;

public interface IVertex<T>
{
    T Value { get; }
    int Degree { get; }
    List<IVertex<T>> Neighbors { get; }
}