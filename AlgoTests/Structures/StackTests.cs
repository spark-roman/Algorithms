using System;
using Algorithms.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Structures
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void IsEmpty_PassEmptyStack_ReturnTrue()
        {
            var stack = new Stack<int>();
            var isEmpty = stack.IsEmpty();

            var expectedValue = true;
            Assert.AreEqual(isEmpty, expectedValue);
        }

        [TestMethod]
        public void Clear_AddThreeElements_IsEmptyTrue()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Clear();

            var isEmpty = stack.IsEmpty();
            var expectedValue = true;
            Assert.AreEqual(isEmpty, expectedValue);
        }

        [TestMethod]
        public void Pop_PassEmptyStack_ExceptionThrown()
        {
            try
            {
                var stack = new Stack<int>();
                stack.Pop();
            }
            catch (InvalidOperationException e)
            {
                var expectedValue = e.Message;
                Assert.AreEqual("Stack is empty.", expectedValue);
            }
        }

        [TestMethod]
        public void Push_AddThreeElements_CheckSizeIsThree()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var expectedValue = 3;
            Assert.AreEqual(stack.Size, expectedValue);
        }

        [TestMethod]
        public void Pop_AddThreeElementsGetOne_CheckSizeIsTwo()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();

            var expectedValue = 2;
            Assert.AreEqual(stack.Size, expectedValue);
        }

        [TestMethod]
        public void Pop_AddFiveElementsGetOne_CheckEqualFive()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            var requestedValue = stack.Pop();
            var expectedValue = 5;
            Assert.AreEqual(requestedValue, expectedValue);
        }

        [TestMethod]
        public void Pop_AddFourElementsGetOneAddOne_CapacityNotChanged()
        {
            var stack = new Stack<int>();
            stack.Push(1);

            var expectedValue = 16;
            
            Assert.AreEqual(stack.Capacity, expectedValue);
        }
    }
}
