
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
