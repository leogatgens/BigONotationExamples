using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation
{
    class O_N2_
    {

       public  bool ContainsDuplicates(String[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = 0; j < strings.Length; j++)
                {
                    if (i == j) // Don't compare with self
                    {
                        continue;
                    }

                    if (strings[i] == strings[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
