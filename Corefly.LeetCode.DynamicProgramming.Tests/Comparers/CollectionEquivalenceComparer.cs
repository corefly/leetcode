namespace Corefly.LeetCode.DynamicProgramming.Tests.Comparers;

internal class CollectionEquivalenceComparer<T> : IEqualityComparer<IEnumerable<T>> where T : IEquatable<T>
{
    public bool Equals(IEnumerable<T> x, IEnumerable<T> y)
    {
        var leftList = new List<T>(x);
        var rightList = new List<T>(y);

        leftList.Sort();
        rightList.Sort();

        using var enumeratorX = leftList.GetEnumerator();
        using var enumeratorY = rightList.GetEnumerator();

        while (true)
        {
            var hasNextX = enumeratorX.MoveNext();
            var hasNextY = enumeratorY.MoveNext();

            if (!hasNextX || !hasNextY)
                return (hasNextX == hasNextY);

            if (!enumeratorX.Current.Equals(enumeratorY.Current))
                return false;
        }
    }

    public int GetHashCode(IEnumerable<T> obj)
    {
        throw new NotImplementedException();
    }
}
