namespace CastomStack
{

public class StackItem
{
    private string[]? _items;
    public int Count;

    public void AddRange(string[] items)
    {
        this._items = items;
        Count = _items.Length;
    }

    public void Add(string item)
    {
        if(_items.Length == Count)
        {
            string[] largerArray = new string[Count * 2];
            Array.Copy(_items, largerArray, Count);

            _items = largerArray;
        }
        _items[Count++] = item;
    }

    public void Remove()
    {
        if(Count==0)
        {
            throw new InvalidOperationException();
        }
        _items[--Count] = null;

    }

    public string Peek()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException();
        }
        return _items[Count - 1];
    }

}
}
