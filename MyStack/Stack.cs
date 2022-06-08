
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
