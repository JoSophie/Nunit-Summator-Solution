using NUnit.Framework;

namespace Summator.Tests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPositiveNumbers()
        {
            long expected = Summator.Sum(new int[] { 5, 7 });
            int actual = 12;

            Assert.That(expected == actual);
        }

         [Test]
         public void Test_Sum_OneNumber()
         {
            long result = Summator.Sum(new int[] { 5 });

            Assert.That(result == 5);
         }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long expected = Summator.Sum(new int[] { -6, -7 });

            Assert.That(expected == -13);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long expected = Summator.Sum(new int[] { });

            Assert.That(expected == 0);
        }

        [Test]
        public void Test_Sum_BigValue()
        {
            long actual = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(8000000000, actual);
        }
        [Test]
        public void Test_Avrg_TwoPositiveNumbers()
        {
            int avrg = Summator.Average(new int[] { 5, 7 });
            int avrgActual = 6;

            Assert.That(avrg == avrgActual);
        }
    }
}