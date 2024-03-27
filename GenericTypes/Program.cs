//var numbers = new List<int> { 1, 3, 1, 2, 41 };
//var words = new List<string> { "aaa", "bbb" };
//var dates = new List<DateTime> { new DateTime(2023, 1, 4) };

var numbers = new ListOfInts();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);

numbers.RemoveAt(2);

Console.ReadKey();

class ListOfInts
{
    private int[] _items = new int[4];
    private int _size = 0;

    public void Add(int item)
    {
        if(_size >= _items.Length)
        {
            var newItem = new int[_items.Length * 2];

            for(int i = 0; i < _items.Length; i++)
            {
                newItem[i] = _items[i];
            }
            _items = newItem;
        }
        _items[_size] = item;
        ++_size;
    }
    public void RemoveAt(int index)
    {
        if(index < 0 || index > _size)
        {
            throw new IndexOutOfRangeException(
                $"Index {index} is outside the bounds of the list.");
        }
        --_size;
        for(int i = index; i < _size; i++)
        {
            _items[i] = _items[i + 1];
        }

        _items[_size] = 0;
    }

    public int GetAtIndex(int index)
    {
        if (index < 0 || index > _size)
        {
            throw new IndexOutOfRangeException(
                $"Index {index} is outside the bounds of the list.");
        }
        return _items[index];
    }
}