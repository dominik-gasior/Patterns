namespace Patterns.ValueObject;

public abstract class ValueObject : IEquatable<ValueObject>
{
    public abstract IEnumerable<object> GetAtomicValues();
    
    public static bool operator ==(ValueObject left, ValueObject right)
        => left is null ? right is null : left.Equals(right);

    public static bool operator !=(ValueObject left, ValueObject right)
        => !(left == right);
    
    public bool Equals(ValueObject? other)
        => other is not null && ValuesAreEqual(other);

    public override bool Equals(object? obj)
        => obj is ValueObject other && ValuesAreEqual(other);

    public override int GetHashCode()
        => GetAtomicValues()
            .Aggregate(
                default(int), 
                HashCode.Combine);

    private bool ValuesAreEqual(ValueObject other)
        => GetAtomicValues().SequenceEqual(other.GetAtomicValues());
}