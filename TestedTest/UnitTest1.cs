using Tested;

namespace TestedTest
{
    public class UnitTest1
    {
        MyQueue<int> myQueueInteger = new MyQueue<int>();
        MyQueue<string> myQueueString = new MyQueue<string>();

        [Fact]
        public void QueueTestInteger()
        {
            myQueueInteger.Queue(1);
            myQueueInteger.Queue(2);
            Assert.Equal(2, myQueueInteger.firstElement);
        }

        [Fact]
        public void DequeueTestInteger()
        {
            myQueueInteger.Queue(1);
            myQueueInteger.Queue(2);
            myQueueInteger.Dequeue();
            Assert.True(myQueueInteger.firstElement.Equals(1));
        }

        [Fact]
        public void PeekTestInteger()
        {
            myQueueInteger.Queue(1);
            myQueueInteger.Queue(2);
            var getValue= myQueueInteger.Peek();
            Assert.Equivalent(1, getValue);
        }




        [Fact]
        public void QueueTestString()       
        {
            myQueueString.Queue("Marco");
            myQueueString.Queue("Luca");
            var result = myQueueString.firstElement;
            Assert.Equivalent(2, result);
        }

        [Fact]
        public void DequeueTestString()
        {
            myQueueString.Queue("Luca");
            myQueueString.Queue("Emanuele");
            myQueueString.Dequeue();
            Assert.Equivalent(1, myQueueString.firstElement);
        }

        [Fact]
        public void PeekTestString()
        {
            myQueueString.Queue("Franco");
            myQueueString.Queue("Anna");
            string getPeekElement= myQueueString.Peek();
            Assert.Equivalent("Franco", getPeekElement);
        }
    }
}