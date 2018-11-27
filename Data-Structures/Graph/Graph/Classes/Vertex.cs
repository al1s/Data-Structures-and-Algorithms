using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Vertex<T>
    {
        public T Value { get; set; }
        public Vertex(T value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public bool Equals(Vertex<T> other)
        {
            if (other == null)
                return false;

            if (Value.Equals(other.Value))
                return true;
            else
                return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Vertex<T> vertexObj))
                return false;
            else
                return Equals(vertexObj);
        }
    }
}
