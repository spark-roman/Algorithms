using System;
using Algorithms.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Structures
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void IsEmpty_PassEmptyQueue_ReturnTrue()
        {
            var queue = new Queue<int>();
            var isEmpty = queue.IsEmpty();

            var expectedValue = true;
            Assert.AreEqual(isEmpty, expectedValue);
        }

        [TestMethod]
        public void Clear_AddThreeElements_IsEmptyTrue()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Clear();

            var isEmpty = queue.IsEmpty();
            var expectedValue = true;
            Assert.AreEqual(isEmpty, expectedValue);
        }

        [TestMethod]
        public void Dequeue_PassEmptyQueue_ExceptionThrown()
        {
            try
            {
                var queue = new Queue<int>();
                queue.Dequeue();
            }
            catch (InvalidOperationException e)
            {
                var expectedValue = e.Message;
                Assert.AreEqual("Queue is empty.", expectedValue);
            }
        }

        [TestMethod]
        public void Enqueue_AddThreeElements_CheckSizeIsThree()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var expectedValue = 3;
            Assert.AreEqual(queue.Size, expectedValue);
        }

        [TestMethod]
        public void Dequeue_AddThreeElementsGetOne_CheckSizeIsTwo()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();

            var expectedValue = 2;
            Assert.AreEqual(queue.Size, expectedValue);
        }

        [TestMethod]
        public void Dequeue_AddFiveElementsGetOne_CheckEqualOne()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            var requestedValue = queue.Dequeue();
            var expectedValue = 1;
            Assert.AreEqual(requestedValue, expectedValue);
        }

        [TestMethod]
        public void Dequeue_AddFourElementsGetOneAddOne_CapacityNotChanged()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            var expectedValue = queue.Capacity;

            queue.Dequeue();
            queue.Enqueue(5);

            var currentCapacity = queue.Capacity;
            
            Assert.AreEqual(currentCapacity, expectedValue);
        }
    }
}
