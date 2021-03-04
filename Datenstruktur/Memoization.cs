using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenstruktur
{
    public class Memoization
    {
        public long FibbonacciSeries_Memotized(int number,Dictionary<int,long> memo)
        {
            if (memo.ContainsKey(number)) return memo[number];
            if (number < 2) return 1;
            long temp = FibbonacciSeries_Memotized(number - 1, memo) + FibbonacciSeries_Memotized(number - 2, memo );
            memo.Add(number, temp);
            return memo[number];
        }

    }
}
