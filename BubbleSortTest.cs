using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewSession_4;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TextProject
{
    //Q.9)Test Sorting Algorithm: Write NUnit tests for sorting functions (Bubble Sort
    public class BubbleSortTest
    {

        private BubbleSort bs;

        [SetUp]
        public void Setup()
        {
            bs = new BubbleSort();
        
        }


        [Test]
        public void SortArray()
        {
            int[] input = { 5, 3, 8, 1, 2 };
            int[] expected = { 1, 2, 3, 5, 8 };

            int[] result = bs.UsingBubbleSort(input);

             Assert.AreEqual(expected, result);
        }


        [Test]
        public void EmptyArray()
        {
            int[] input = { };
            int[] expected = { };

            int[] result = bs.UsingBubbleSort(input);

            Assert.AreEqual(expected, result);
        }


        [Test]
        public void DifferentLength_False()
        {
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3 };

            int[] result = bs.UsingBubbleSort(input);

            Assert.AreEqual(expected, result);
        }

    }
}
