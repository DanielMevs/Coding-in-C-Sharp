//var numbers = new List<int> { 1, 3, 1, 2, 41 };
//var words = new List<string> { "aaa", "bbb" };
//var dates = new List<DateTime> { new DateTime(2023, 1, 4) };

var numbers = new SimpleList<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);

//numbers.RemoveAt(2);
var words = new SimpleList<string>();
words.Add("aaa");
words.Add("ccc");
words.Add("ddd");

var dates = new SimpleList<DateTime>();
dates.Add(new DateTime(2025, 1, 6));
dates.Add(new DateTime(2025, 1, 3));
dates.Add(new DateTime(2025, 1, 9));

Console.ReadKey();

class SimpleList<T>
{
    private T[] _items = new T[4];
    private int _size = 0;

    public void Add(T item)
    {
        if(_size >= _items.Length)
        {
            var newItem = new T[_items.Length * 2];

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

        _items[_size] = default;
    }

    public T GetAtIndex(int index)
    {
        if (index < 0 || index > _size)
        {
            throw new IndexOutOfRangeException(
                $"Index {index} is outside the bounds of the list.");
        }
        return _items[index];
    }
}

//class ListOfStrings
//{
//    private string[] _items = new string[4];
//    private int _size = 0;

//    public void Add(string item)
//    {
//        if (_size >= _items.Length)
//        {
//            var newItem = new string[_items.Length * 2];

//            for (int i = 0; i < _items.Length; i++)
//            {
//                newItem[i] = _items[i];
//            }
//            _items = newItem;
//        }
//        _items[_size] = item;
//        ++_size;
//    }
//    public void RemoveAt(int index)
//    {
//        if (index < 0 || index > _size)
//        {
//            throw new IndexOutOfRangeException(
//                $"Index {index} is outside the bounds of the list.");
//        }
//        --_size;
//        for (int i = index; i < _size; i++)
//        {
//            _items[i] = _items[i + 1];
//        }

//        _items[_size] = null;
//    }

//    public string GetAtIndex(int index)
//    {
//        if (index < 0 || index > _size)
//        {
//            throw new IndexOutOfRangeException(
//                $"Index {index} is outside the bounds of the list.");
//        }
//        return _items[index];
//    }
//}