using System.Text;

namespace AtelierComposite
{
    internal class Person
    {
        public string Name { get; set; }
        public List<Person> Children { get; set;}

        public Person(string name)
        {
            Name = name;
            Children = new List<Person>();
        }

        public void AddChildren(Person children)
        {
            Children.Add(children);
        }

        public override string ToString()
        {
            return ToString(0);
        }

        private string ToString(int level)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string(' ', level * 2) + Name);
            foreach (var descendant in Children)
            {
                sb.Append(descendant.ToString(level + 1));
            }
            return sb.ToString();
        }
    }
}
