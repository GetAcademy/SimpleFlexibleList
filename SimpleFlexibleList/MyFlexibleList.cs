namespace SimpleFlexibleList
{
    internal class MyFlexibleList<T>
    {
        private T[] _values;
        private int _count;

        public string AsString => 
            $"Count={_count} Values={string.Join(',', _values)}";

        public MyFlexibleList()
        {
            _values = new T[4];
        }

        public void Add(T value)
        {
            var index = _count;
            if (index >= _values.Length)
            {
                IncreaseCapacity();
            }
            _values[index] = value;
            _count++;
        }

        private void IncreaseCapacity()
        {
            var newValues = new T[_values.Length * 2];
            Array.Copy(_values, newValues, _values.Length);
            _values = newValues;
        }
    }
}
