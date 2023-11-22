using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public List<string> list { get; set; }
        public string RandomString()
        {
            var random = new Random();
            int randomIndex = random.Next(list.Count);

            string randomString = list[randomIndex];
            list.Remove(randomString);

            return randomString;
        }
    }
}
