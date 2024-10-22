namespace GenericsDemo;

public class GenericArray<TArrayItem>
{
    private int _addIndex = 0;
    private TArrayItem[] _items;

    public int Size
    {
        get => _items.Length;
    }

    public int LastAdded
    {
        get => _addIndex;
    }

    public GenericArray(int length)
    {
        if (length < 1)
        {
            throw new ArgumentException("length must be bigger than zero.", nameof(length));
        }

        _items = new TArrayItem[length];
    }

    public TArrayItem GetArrayItem(int index)
    {
        if (index < 0 || _items.Length - 1 < index)
        {
            throw new IndexOutOfRangeException(nameof(index));
        }

        if (_addIndex <= index)
        {
            return default;
        }

        return _items[index];
    }

    public void Add(TArrayItem item)
    {
        // AddLastWithoutExtend(item);
        // Try using this method instead
        AddLastWithExtend(item);
    }

    public void DeleteAt(int index)
    {
        if (index < 0 || _items.Length - 1 < index)
        {
            throw new IndexOutOfRangeException(nameof(index));
        }

        for (int i = index; i < _items.Length - 2; i++)
        {
            _items[i] = _items[i + 1];
        }

        // Similar to _items[_items.Length - 1]
        _items[^1] = default; // the default value of TArrayItem
        _addIndex--;
    }

    public void Print()
    {
        for (int i = 0; i < _addIndex; i++)
        {
            if (i == _addIndex - 1)
            {
                Console.WriteLine(_items[i]);
                continue;
            }

            Console.Write(_items[i]);
            Console.Write(",");
        }
    }

    private void AddLastWithoutExtend(TArrayItem item)
    {
        if (_items.Length - 1 < _addIndex)
        {
            Console.WriteLine("The array is full");
            return;
        }

        _items[_addIndex++] = item;
    }

    private void AddLastWithExtend(TArrayItem item)
    {
        if (_items.Length <= _addIndex)
        {
            var newArray = new TArrayItem[_items.Length * 2];
            Array.Copy(_items, newArray, _items.Length);
            _items = newArray;
        }

        _items[_addIndex++] = item;
    }
}
