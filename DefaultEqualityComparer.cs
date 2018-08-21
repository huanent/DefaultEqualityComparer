using System;

namespace System.Collections.Generic
{
    public class DefaultEqualityComparer<T> : EqualityComparer<T>
    {
        readonly Func<T, T, bool> _comparer;
        readonly Func<T, int> _hash;

        public DefaultEqualityComparer(Func<T, T, bool> comparer)
        {
            _comparer = comparer;
        }

        public DefaultEqualityComparer(Func<T, T, bool> comparer, Func<T, int> hash)
        {
            _comparer = comparer;
            _hash = hash;
        }
        public override bool Equals(T x, T y)
        {
            return _comparer(x, y);
        }

        public override int GetHashCode(T obj)
        {
            return _hash(obj);
        }
    }
}
