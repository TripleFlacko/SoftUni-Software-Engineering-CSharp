namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main()
        {
            var list = new DoublyLinkedList();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddLast(3);
            list.AddLast(4);
            list.RemoveFirst();
            list.RemoveLast();
            list.ForEach(item => Console.WriteLine(item));
        }
    }
}