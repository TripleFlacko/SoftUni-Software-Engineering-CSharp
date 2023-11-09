using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class DateModifier
    {
		public static double GetDifference(DateTime startDate, DateTime endDate)
		{
			var difference = Math.Abs((startDate - endDate).TotalDays);
            return difference;
		}
	}
}
