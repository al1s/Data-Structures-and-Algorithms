using System.Linq;
using System.Text;

namespace Hashtables.Classes
{
    public class Node<T>
    {
        public string Key { get; set; }
        public T Value { get; set; }
        public Node()
        {
            Key = default(string);
            Value = default(T);
        }
        public Node(string key, T value)
        {
            Key = key;
            Value = value;
        }
    }
}
