using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation
{
    class Program
    {
        private static string[] ListOfOneMillonItems;
        private static string[] ListOf10000Items;


        static void Main(string[] args)
        {
            ListOfOneMillonItems = GenerateOneMillonItems();
            ListOf10000Items = Generate10000Items();

            SameTimeBigList();
            SameTimeTestSmallList();
            
            GrowLinearly1();
            GrowLinearly2();

            SquareOfTheSize1();
            SquareOfTheSize2();

            Console.ReadKey();
        }

        private static string[] GenerateOneMillonItems()
        {
            string[] TheOneMillonItems = new string[1000000] ;
            string Prefix = "Item";
            for (int i = 0; i < 1000000; i++)
            {
                TheOneMillonItems[i] = string.Concat(Prefix, i.ToString());

            }

            return TheOneMillonItems;
        }

        private static string[] Generate10000Items()
        {
            string[] The10000Items = new string[10000];
            string Prefix = "Item";
            for (int i = 0; i < 10000; i++)
            {
                The10000Items[i] = string.Concat(Prefix, i.ToString());

            }

            return The10000Items;
        }


        private static void GrowLinearly1()
        {
            PerformanceGrowLinearly performanceGrowLinearly = new PerformanceGrowLinearly();
            TimeDiffCalculator timerDiff = new TimeDiffCalculator("GrowLinearly1");

            timerDiff.Start();
            bool ItemFound = performanceGrowLinearly.ContainsValue(ListOf10000Items, "Item9999");
            timerDiff.Finish();
            if (ItemFound == true)
            {
                Console.WriteLine("Item9999 exist.");

            }
                

        }

        private static void GrowLinearly2()
        {
            PerformanceGrowLinearly performanceGrowLinearly = new PerformanceGrowLinearly();
            TimeDiffCalculator timerDiff = new TimeDiffCalculator("GrowLinearly2");
         
            timerDiff.Start();
            bool ItemFound = performanceGrowLinearly.ContainsValue(ListOfOneMillonItems, "Item999999");
            timerDiff.Finish();
            if (ItemFound == true)
            {
                Console.WriteLine("Item999999 exist.");

            }
        }

        private static void SameTimeTestSmallList()
        {   
                   
            SameTime sameTime = new SameTime();
            TimeDiffCalculator timerDiff = new TimeDiffCalculator("Small");
            timerDiff.Start();
            sameTime.IsFirstElementNull(ListOf10000Items);
            timerDiff.Finish();   

           
        }

        private static void SameTimeBigList()
        {
          

            SameTime sameTime = new SameTime( );
            TimeDiffCalculator timerDiff = new TimeDiffCalculator("Big");

            timerDiff.Start();
            sameTime.IsFirstElementNull(ListOfOneMillonItems);
            timerDiff.Finish();
        }


        private static void SquareOfTheSize1()
        {
            O_N2_ performanceGrowLinearly = new O_N2_();
            TimeDiffCalculator timerDiff = new TimeDiffCalculator("SquareOfTheSize1");
       
            timerDiff.Start();
         bool isDuplicated =   performanceGrowLinearly.ContainsDuplicates (ListOf10000Items);
            timerDiff.Finish();
            if (isDuplicated)
            {
                Console.WriteLine("Item duplicated");
            }
            else {
                Console.WriteLine("Item not duplicated");
            }
        }

        private static void SquareOfTheSize2()
        {
            O_N2_ performanceGrowLinearly = new O_N2_();
            TimeDiffCalculator timerDiff = new TimeDiffCalculator("SquareOfTheSize2");
           
            timerDiff.Start();
            bool isDuplicated = performanceGrowLinearly.ContainsDuplicates(ListOfOneMillonItems);
            timerDiff.Finish();
            if (isDuplicated)
            {
                Console.WriteLine("Item duplicated");
            }
            else
            {
                Console.WriteLine("Item not duplicated");
            }
        }


    }
}
