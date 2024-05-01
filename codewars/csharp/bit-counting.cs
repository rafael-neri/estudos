using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int CountBits(int val)
    {
        return Convert.ToString(val, 2)
                      .ToCharArray()
                      .Where(x => x == '1')
                      .ToArray()
                      .Length;
    }
}
