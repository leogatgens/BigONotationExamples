using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation
{
   
    public class TimeDiffCalculator
    {
        private TimeSpan InitialTime = TimeSpan.Zero;
        private TimeSpan FinishTime = TimeSpan.Zero;
        private TimeSpan result = TimeSpan.Zero;

        private readonly string Text = string.Empty;
        public TimeDiffCalculator(string message )
        {
            Text = message;
        }

        public void Start()
        {
            InitialTime = DateTime.Now.TimeOfDay;
        }

        public void Finish()
        {
              FinishTime = DateTime.Now.TimeOfDay;
            Print(); 
        }

        private void Print()
        {

            result = (FinishTime - InitialTime);
            string finalText = string.Empty;
            finalText = string.Concat("Time: ",Text    ," " , result.ToString());
            Console.WriteLine(finalText);
        }


    }
}
