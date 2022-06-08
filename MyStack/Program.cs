var s = new Stack("a", "b", "c");
// size = 3, Top = 'c'
Console.WriteLine($"size = {s.Size}, Top = '{s.top}'");
var deleted = s.Pop();
// Извлек верхний элемент 'c' Size = 2
Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");
s.Add("d");
// size = 3, Top = 'd'
Console.WriteLine($"size = {s.Size}, Top = '{s.top}'");
s.Pop();
Console.WriteLine($"size = {s.Size}, Top = '{s.top}'");
s.Pop();
Console.WriteLine($"size = {s.Size}, Top = '{s.top}'");
s.Pop();
// size = 0, Top = null
Console.WriteLine($"size = {s.Size}, Top = {(s.top == null ? "null" : s.top)}");
s.Pop();

//var s = new Stack("a", "b", "c");
//s.Merge(new Stack("1", "2", "3"));
//Console.WriteLine($"size = {s.Size}, Top = '{s.top}'");
//Console.ReadKey();


//var s = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"));
//Console.ReadKey();



static class StackExtension
{
    
    public static void Merge(this Stack stack, Stack stack1)
    {
        string item;
        int size = stack1.Size;
        for (int i = 0; i< size; i++)
        {
            item = stack1.Pop();
            stack.Add(item);
        }

    }
}

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


public class Stack
{
    private StackItem stackItem = new StackItem();

    public int Size { get; private set; }

    public string top;

    public string result;

    public static List<string> Concat(params Stack[] stacks)// относится к доп заданию 2. 
    {
 
        List<string> ListItem = new List<string>();
        int Count = stacks.Length;
        
        string item;
        for (int i = 0; i <Count; i++)
        {
           Stack stack = stacks[i];
           int count = stack.Size;
           for (int j = 0; j < count; j++)
           {
                item = stack.Pop();
                ListItem.Add(item);
           }
        }
        return ListItem;
    }
  

    public Stack(params string[] stocks)
    {
        stackItem.AddRange(stocks);
        Size = stackItem.Count;
        top = stackItem.Peek();
    }

    public void Add(string item)
    {
        stackItem.Add(item);
        Size = stackItem.Count;
        top = stackItem.Peek();
    }

    public string Pop()
    {
        if (Size == 0)
        {
            throw new InvalidOperationException("Стек пустой");
        }
        result = stackItem.Peek();
        stackItem.Remove();
        Size = stackItem.Count;
        if (Size == 0)
        {
            top = null; 
        }
        else 
        { 
            top = stackItem.Peek(); 
        }
        return result;
    }
}
