using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation
{
   public  class PerformanceGrowLinearly
    {

      public   bool ContainsValue(String[] strings, String value)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
