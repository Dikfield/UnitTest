using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Tests
{
    [TestFixture]
    public class MyStackTests
    {
        private MyStack<int> _stack;

        [SetUp]
        public void Setup()
        {
            _stack = new MyStack<int>();
        }

        [Test]
        public void TestStack_PushOneItem_Returns2()
        {
            _stack.Push(2);
            Assert.That(_stack.Peek(), Is.EqualTo(2));
        }
        [Test]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            Assert.IsTrue(_stack.IsEmpty);
        }

        [Test]
        public void Pop_EmptyStack_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => _stack.Pop());
        }
        [Test]
        public void Peek_PushTwoItems_ReturnsHeadItem()
        {
            _stack.Push(1);
            _stack.Push(2);

            Assert.AreEqual(2,_stack.Peek());
        }
        [Test]
        public void Peek_PushTreeItemsAndPoptwo_ReturnsHeadElement()
        {
            _stack.Push(1);
            _stack.Push(2);
            _stack.Push(3);

            _stack.Pop();
            _stack.Pop();

            Assert.AreEqual(1,_stack.Peek());
        }
    }
}
