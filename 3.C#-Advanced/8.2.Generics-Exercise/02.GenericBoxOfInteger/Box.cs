using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GenericBoxOfInteger
{
    public class Box<T>
    {
        private readonly List<T> list = new List<T>();
        public void AddValue(T value)
        {
            list.Add(value);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.AppendLine($"{typeof(T)}: {item.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
