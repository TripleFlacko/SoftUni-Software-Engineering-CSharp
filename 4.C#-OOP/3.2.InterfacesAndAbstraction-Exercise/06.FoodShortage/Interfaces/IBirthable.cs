using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoodShortage.Interfaces
{
    public interface IBirthable
    {
        string Name { get; }
        string Birthdate { get; }
        bool SameYear(string year);
    }
}
