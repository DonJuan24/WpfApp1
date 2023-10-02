using System;
using System.Collections.Generic;

namespace Lib_8
{
    public class Class1 //БОЛОТО
    {
        static public int GetMax(int n, out List<int> generated)
        {
            generated = new List<int>(n);
            int max = -1;
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int Chislo = rnd.Next(0, n + 1);
                if ( Chislo > max )
                {
                    max = Chislo;
                }
                generated.Add(Chislo);
            }
            return max;

        }    
    }
}
