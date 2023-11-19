using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        public int[] _numbers;
        public Lake(int[] numbers)
        {
            _numbers = numbers;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    yield return _numbers[i];
                }
            }
            for (int i = _numbers.Length - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return _numbers[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
