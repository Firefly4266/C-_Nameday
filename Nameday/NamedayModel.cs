using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nameday
{
    public class NamedayModel
    {
        public int Month { get; } //only using the GET method of the auto implementor because the SET is done in the constructor. 
        public int Day { get; }
        public IEnumerable<string> Names { get; }

        public NamedayModel(int month, int day, IEnumerable<string> names)
        {
            Month = month;
            Day = day;
            Names = names;
        }
        public string NameAsString => string.Join(", ", Names);// the fat arrow function works the same as the code below.
        //{
        //    get { return string.Join(", ", Names); }
        //}
    }
}
