using System;
using BigONotation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestExamples

{
    [TestClass]
    public class IsFirstElementNull_Test
    {

      private   SameTime methodTested;
        private  string[] itemsSmall = { "Item1", "Item2", "Item3", "Item4", "Item1",
                "Item2", "Item3", "Item4", "Item2", "Item3", "Item4",
                "Item1", "Item2", "Item3", "Item4", "Item2", "Item3",
                "Item4", "Item1", "Item2", "Item3", "Item4", "Item2",
                "Item3", "Item4", "Item1", "Item2", "Item3", "Item4",
                "Item2", "Item3", "Item4", "Item1", "Item2", "Item3",
                 };
        private  string[] itemsBig = { "Item1", "Item2", "Item3", "Item4", "Item1",
                "Item2", "Item3", "Item4", "Item2", "Item3", "Item4",              
                "Item2", "Item3", "Item4", "Item1", "Item2", "Item3",
                "Item4", "Item2", "Item3", "Item4", "Item1", "Item2",                           
                "Item4", "Item1", "Item2", "Item3", "Item4", "Item2",
                "Item3", "Item4", "Item1", "Item2", "Item3", "Item4" }; 

        [TestInitialize]
        public void TEst()
        {
             methodTested = new SameTime();                       
        }
        [TestMethod]
        public void TestMethod_WithManyItems_SameTime()
        {
            methodTested.IsFirstElementNull(itemsSmall);
        }

        [TestMethod]
        public void TestMethod_WithFewItems_SameTime()
        {         
            methodTested.IsFirstElementNull(itemsSmall);
        }
    }
}
