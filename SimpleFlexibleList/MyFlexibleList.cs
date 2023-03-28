namespace SimpleFlexibleList
{
    internal class MyFlexibleList
    {
        private int[] _numbers;
        private int _count;

        public string AsString => 
            $"Count={_count} Numbers={string.Join(',', _numbers)}";

        public MyFlexibleList()
        {
            _numbers = new int[4];
        }

        public void Add(int number)
        {
            var index = _count;
            if (index >= _numbers.Length)
            {
                IncreaseCapacity();
            }
            _numbers[index] = number;
            _count++;
        }

        private void IncreaseCapacity()
        {
            var newNumbers = new int[_numbers.Length * 2];
            Array.Copy(_numbers, newNumbers, _numbers.Length);
            _numbers = newNumbers;
        }
    }
}
