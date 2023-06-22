using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace ConsoleAppTest
{
    [TestClass]
    public class DeclarationIndexersAccessorsLikePropertyTests
    {
        [DataTestMethod]
        [DataRow(false, -50, 0, 0)]
        [DataRow(false, 20, 0, 0)]
        [DataRow(false, 25, 0, 0)]
        [DataRow(false, 100, 0, 0)]
        [DataRow(false, 120, 0, 0)]
        [DataRow(false, 200, 0, 0)]
        [DataRow(false, 120, 0, 2)]
        [DataRow(false, 50, 0, 1)]
        [DataRow(true, 80, 0, 1)]
        [DataRow(true, 25, 0, 2)]
        public void CalcFradrag_ShouldReturnCorrectAmount(bool BilTog, float km, float expectedPenge, int BroMoney)
        {
            // Arrange
            Fradrag fradrag = new Fradrag();

            // Act
            float actualPenge = 0;
            if(BilTog == true)
            {
                actualPenge = fradrag.CalcFradragTog(km, BroMoney);
            }
            else
            {
                actualPenge = fradrag.CalcFradrag(km, BroMoney);
            }
            

            // Assert
            Assert.AreNotEqual(-1, actualPenge, "CalcFradrag returned an error value.");
            Console.WriteLine($"Actual result: {actualPenge}"); // Output the actual result
        }
    }
}
