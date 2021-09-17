using System;

namespace BankingLibrary
{
    public class CalcInterest: ICalcInterest
    {
        public int Calculate(int principle, int RateofInt, int years)
        {
            int SimpInt = (principle * years * RateofInt) / 100;
            return SimpInt;
        }

    }
}
