using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tested
{
    public class MyQueue<T>
    {
        public T[] array = new T[10];
        public int firstElement;

        public void Queue(T value)
        {
            if (firstElement == array.Length - 1)
            {
                throw new StackOverflowException();
            }
            array[++firstElement] = value;
        }

        public T Dequeue()
        {
            if (firstElement == -1)
            {
                throw new InvalidOperationException();
            }
            return array[firstElement--];
        }

        public T Peek()
        {
            if (firstElement == -1)
            {
                throw new InvalidOperationException();
            }
            return array[--firstElement];
        }
    }
}
