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




public class Stack
{
    private List<string> stock = new List<string>();

    public int Size { get; private set; }

    public string top;

    public string result;

    

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
        { top = null; } 
        else { top = stock[Size - 1]; };
        return result;
       

    }
   

    public string Peek()
    {
        top = stock[Size - 1];
        return top;
    }

}
