namespace Graph.Vertex;

public class Vertex<T> : IVertex<T>
{
    public int Id { get; set; }
    public T Value { get; } 
    public int Degree => Neighbors.Count;
    public List<IVertex<T>> Neighbors { get; }
    public Colors Color { get; set; }
    public Vertex(T value, int id)
    {
        Value = value;
        Id = id;
        Neighbors = [];
        Color = Colors.White;
    }
    public override string ToString()
    {
        return $"({Value}, {Degree})";
    }
    public override bool Equals(object? obj)
    {
        if (obj is Vertex<T> vertex)
        {
            return Value!.Equals(vertex.Value);
        }
        return false;
    }
    public override int GetHashCode()
    {
        return Value!.GetHashCode();
    }
}