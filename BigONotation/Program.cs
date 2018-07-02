using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation
{
    class Program
    {
      

        static void Main(string[] args)
        {
          
            SameTimeBigList();
            SameTimeTest();

            Console.ReadKey();
        }

        private static void SameTimeTest()
        {
       

            PerformanceGrowLinearly performanceGrowLinearly = new PerformanceGrowLinearly();
            string[] itemsSmall = {
                "Item1", "Item2", "Item3", "Item4", "Item1",
                "Item2", "Item3", "Item4", "Item2", "Item3", "Item4",
                "Item1", "Item2", "Item3", "Item4", "Item2", "Item3",
                "Item4", "Item1", "Item2", "Item3", "Item4", "Item2",
                "Item3", "Item4", "Item1", "Item2", "Item3", "Item4",
                "Item2", "Item3", "Item4", "Item1", "Item2", "Item3",
                 };
            
            SameTime sameTime = new SameTime();


            TimeDiffCalculator timerDiff = new TimeDiffCalculator("Small");



            timerDiff.Start();
            sameTime.IsFirstElementNull(itemsSmall);
            timerDiff.Finish();
     

           
        }

        private static void SameTimeBigList()
        {
          

            PerformanceGrowLinearly performanceGrowLinearly = new PerformanceGrowLinearly();
           
            string[] itemsBig = {
                "Item1", "Item2", "Item3", "Item4", "Item1",
                "Item2", "Item3", "Item4", "Item2", "Item3", "Item4",
                "Item2", "Item3", "Item4", "Item1", "Item2", "Item3",
                "Item4", "Item2", "Item3", "Item4", "Item1", "Item2",
                "Item4", "Item1", "Item2", "Item3", "Item4", "Item2",
                "Item3", "Item4", "Item1", "Item2", "Item3", "Item4"
                , "Item2", "Item3", "Item4", "Item1",
                "Item2", "Item3", "Item4", "Item2", "Item3", "Item4",
                "Item2", "Item3", "Item4", "Item1", "Item2", "Item3",
                "Item4", "Item2", "Item3", "Item4", "Item1", "Item2",
                "Item4", "Item1", "Item2", "Item3", "Item4", "Item2",
                "Item3", "Item4", "Item1", "Item2", "Item3", "Item4"
                , "Item2", "Item3", "Item4", "Item1",
                "Item2", "Item3", "Item4", "Item2", "Item3", "Item4",
                "Item2", "Item3", "Item4", "Item1", "Item2", "Item3",
                "Item4", "Item2", "Item3", "Item4", "Item1", "Item2",
                "Item4", "Item1", "Item2", "Item3", "Item4", "Item2",
                "Item3", "Item4", "Item1", "Item2", "Item3", "Item4"
                , "Item2", "Item3", "Item4", "Item1",
                "Item2", "Item3", "Item4", "Item2", "Item3", "Item4",
                "Item2", "Item3", "Item4", "Item1", "Item2", "Item3",
                "Item4", "Item2", "Item3", "Item4", "Item1", "Item2",
                "Item4", "Item1", "Item2", "Item3", "Item4", "Item2",
                "Item3", "Item4", "Item1", "Item2", "Item3", "Item4"
                , "Item2", "Item3", "Item4", "Item1",
                "Item2", "Item3", "Item4", "Item2", "Item3", "Item4",
                "Item2", "Item3", "Item4", "Item1", "Item2", "Item3",
                "Item4", "Item2", "Item3", "Item4", "Item1", "Item2",
                "Item4", "Item1", "Item2", "Item3", "Item4", "Item2",
                "Item3", "Item4", "Item1", "Item2", "Item3", "Item4"
                , "Item2", "Item3", "Item4", "Item1",
                "Item2", "Item3", "Item4", "Item2", "Item3", "Item4",
                "Item2", "Item3", "Item4", "Item1", "Item2", "Item3",
                "Item4", "Item2", "Item3", "Item4", "Item1", "Item2",
                "Item4", "Item1", "Item2", "Item3", "Item4", "Item2",
                "Item3", "Item4", "Item1", "Item2", "Item3", "Item4"
                , "Item2", "Item3", "Item4", "Item1",
                "Item2", "Item3", "Item4", "Item2", "Item3", "Item4",
                "Item2", "Item3", "Item4", "Item1", "Item2", "Item3",
                "Item4", "Item2", "Item3", "Item4", "Item1", "Item2",
                "Item4", "Item1", "Item2", "Item3", "Item4", "Item2",
                "Item3", "Item4", "Item1", "Item2", "Item3", "Item4"
                , "Item2", "Item3", "Item4", "Item1",
                "Item2", "Item3", "Item4", "Item2", "Item3", "Item4",
                "Item2", "Item3", "Item4", "Item1", "Item2", "Item3",
                "Item4", "Item2", "Item3", "Item4", "Item1", "Item2",
                "Item4", "Item1", "Item2", "Item3", "Item4", "Item2",
                "Item3", "Item4", "Item1", "Item2", "Item3", "Item4"
                , "Item2", "Item3", "Item4", "Item1",
                "Item2", "Item3", "Item4", "Item2", "Item3", "Item4",
                "Item2", "Item3", "Item4", "Item1", "Item2", "Item3",
                "Item4", "Item2", "Item3", "Item4", "Item1", "Item2",
                "Item4", "Item1", "Item2", "Item3", "Item4", "Item2",
                "Item3", "Item4", "Item1", "Item2", "Item3", "Item4"
                , "Item2", "Item3", "Item4", "Item1",
                "Item2", "Item3", "Item4", "Item2", "Item3", "Item4",
                "Item2", "Item3", "Item4", "Item1", "Item2", "Item3",
                "Item4", "Item2", "Item3", "Item4", "Item1", "Item2",
                "Item4", "Item1", "Item2", "Item3", "Item4", "Item2",
                "Item3", "Item4", "Item1", "Item2", "Item3", "Item4"
                , "Item2", "Item3", "Item4", "Item1",
                "Item2", "Item3", "Item4", "Item2", "Item3", "Item4",
                "Item2", "Item3", "Item4", "Item1", "Item2", "Item3",
                "Item4", "Item2", "Item3", "Item4", "Item1", "Item2",
                "Item4", "Item1", "Item2", "Item3", "Item4", "Item2",
                "Item3", "Item4", "Item1", "Item2", "Item3", "Item4"
                , "Item2", "Item3", "Item4", "Item1",
                "Item2", "Item3", "Item4", "Item2", "Item3", "Item4",
                "Item2", "Item3", "Item4", "Item1", "Item2", "Item3",
                "Item4", "Item2", "Item3", "Item4", "Item1", "Item2",
                "Item4", "Item1", "Item2", "Item3", "Item4", "Item2",
                "Item3", "Item4", "Item1", "Item2", "Item3", "Item4"};
            SameTime sameTime = new SameTime( );
            TimeDiffCalculator timerDiff = new TimeDiffCalculator("Big");



            timerDiff.Start();
            sameTime.IsFirstElementNull(itemsBig);
            timerDiff.Finish();
        }
    }
}
