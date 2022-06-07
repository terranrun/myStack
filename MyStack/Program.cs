//var s = new Stack("a", "b", "c");
//// size = 3, Top = 'c'
//Console.WriteLine($"size = {s.Size}, Top = '{s.top}'");
//var deleted = s.Pop(); 
//// Извлек верхний элемент 'c' Size = 2
//Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");
//s.Add("d");
//// size = 3, Top = 'd'
//Console.WriteLine($"size = {s.Size}, Top = '{s.top}'");
//s.Pop();
//Console.WriteLine($"size = {s.Size}, Top = '{s.top}'");
//s.Pop();
//Console.WriteLine($"size = {s.Size}, Top = '{s.top}'");
//s.Pop();
//// size = 0, Top = null
//Console.WriteLine($"size = {s.Size}, Top = {(s.top == null ? "null" : s.top)}");
//s.Pop();

//var s = new Stack("a", "b", "c");
//s.Merge(new Stack("1", "2", "3"));
//Console.WriteLine($"size = {s.Size}, Top = '{s.top}'");
//Console.ReadKey();


var s = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"));
Console.ReadKey();



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

public class Stack
{
    private List<string> stock = new List<string>();

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

        stock.AddRange(stocks);
        Size = stock.Count();
        top = stock[Size - 1];
    }

    public void Add(string item)
    {

        stock.Add(item);
        Size = stock.Count;
        top = stock[Size - 1];

    }

    public string Pop()
    {

        if (Size == 0)
        {
            throw new InvalidOperationException("Стек пустой");
        }
        result = stock[Size - 1];
        stock.Remove(result);
        Size = stock.Count;
        if (Size == 0)
        {
            top = null; 
        }
        else 
        { 
            top = stock[Size - 1]; 
        }
        return result;


    }


    public string Peek()
    {
        top = stock[Size - 1];
        return top;
    }

}
