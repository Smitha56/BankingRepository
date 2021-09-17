using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public interface ICalcInterest
    {
        public int Calculate(int principle, int RateofInt, int years);
    }
}
