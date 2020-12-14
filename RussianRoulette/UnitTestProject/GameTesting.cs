using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRoulette;
namespace UnitTestProject
{
    [TestClass]
    public class GameTesting
    {
        GameLogic obj_test = new GameLogic(); // initiate the GameLogic object
        [TestMethod]
        public void TestMethod1()
        {
            var actual = obj_test.logic(1, 3); // call the logic function and store the value in actual variable
            var expected = 4;
            Assert.AreEqual(expected, actual); //test the actual and expected value
             

        }
    }
}
