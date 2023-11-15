namespace BoxOfT
{
    public class Box<T>
    {
        public Stack<T> stack;
        public int Count
        {
            get
            {
                return stack.Count;
            }
        }
        public Box()
        {
            stack = new Stack<T>();
        }
        public void Add(T element)
        {
            stack.Push(element);
        }
        public T Remove()
        {
            return stack.Pop();
        }
    }
}
