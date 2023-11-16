using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _04.GenericSwapMethodInteger
{
    public class Box<T>
    {
        private readonly List<T> list = new List<T>();

        public void AddValue(T value)
        {
            list.Add(value);
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            (list[firstIndex], list[secondIndex]) = (list[secondIndex], list[firstIndex]);
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
