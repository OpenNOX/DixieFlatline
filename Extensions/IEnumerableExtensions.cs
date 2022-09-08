namespace DixieFlatline.Extensions;

public static class IEnumerableExtensions
{
    public static IEnumerable<(T, uint)> WithIndex<T>(this IEnumerable<T> enumerable)
    {
        var index = 0u;

        return enumerable.Select(item => (item, index++));
    }
}
