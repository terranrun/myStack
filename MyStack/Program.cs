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
