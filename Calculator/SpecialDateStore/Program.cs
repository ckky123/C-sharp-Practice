using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialDateStore
{
    public class SpecialDate
    {
        static void Main(string[] args)
        {
        }

        public DateTime DateOf(SpecialDates specialDate)
        {
            switch (specialDate)
            {
                case SpecialDates.NewMillennium:
                    return new DateTime(2000, 1, 1, 0, 0, 0, 0);
                default:
                    throw new ArgumentOutOfRangeException("specialDate");
            }
        }
    }
}
