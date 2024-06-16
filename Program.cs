namespace AtelierComposite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person root = new Person("John");
            Person child1 = new Person("Alice");
            Person child2 = new Person("Bob");
            Person grandChild1 = new Person("Charlie");
            Person grandChild2 = new Person("Diana");

            root.AddChildren(child1);
            root.AddChildren(child2);
            child1.AddChildren(grandChild1);
            child2.AddChildren(grandChild2);

            Console.WriteLine(root.ToString());
        }
    }
}
