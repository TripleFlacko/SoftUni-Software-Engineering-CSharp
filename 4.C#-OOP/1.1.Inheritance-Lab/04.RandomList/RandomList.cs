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
        public List<string> Items { get; set; }
        public string RandomString()
        {
            var random = new Random();
            int randomIndex = random.Next(Items.Count);

            string randomString = Items[randomIndex];
            Items.Remove(randomString);

            return randomString;
        }
    }
}
