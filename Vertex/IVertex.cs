namespace Graph.Vertex;

public interface IVertex<T>
{
    int Id { get; }
    T Value { get; }
    int Degree { get; }
    List<IVertex<T>> Neighbors { get; }
}