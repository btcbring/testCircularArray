using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_CircArray
{
    class Program
    {
        public class CircularArray 
        {
            private object[] buffer;
            private int size;
            private int top = 0;
            private int count = 0;

            public CircularArray (int capacity)
            {
                buffer = new object[capacity];
                size = capacity;
            }

            public Object get(int index)
            {

                return buffer[index - 1];
            }
            public int getCapacity()
            {
                return size;
            }
            public int getSize()
            {
                if (count > size - 1)
                {
                    return size;
                } else
                {
                    return count;
                }
            }
            public void add(Object o)
            {

                buffer[top] = o;
                count++;
                top = (top + 1) % size;

            }

            public int indexOf(Object o)
            {
                for (int j = 0; j < size; j++)
                {

                    if (o.Equals(buffer[j])) {
                        return j + 1;
                    }
                }
                return -1;
            }

           
        }
        static void Main(string[] args)
        {
            CircularArray testCirc = new CircularArray(5);

            testCirc.add("one");
            Console.WriteLine("cap" + testCirc.getCapacity());
            Console.WriteLine("size" + testCirc.getSize());
            testCirc.add("two");
            Console.WriteLine("cap" + testCirc.getCapacity());
            Console.WriteLine("size" + testCirc.getSize());

            testCirc.add("three");
            Console.WriteLine(testCirc.get(1));
            Console.WriteLine("cap" + testCirc.getCapacity());
            Console.WriteLine("s" + testCirc.getSize());
            Console.WriteLine("2 " + testCirc.get(2));
            Console.WriteLine("3 " + testCirc.get(3));
            Console.WriteLine("s" + testCirc.getSize());
            testCirc.add("four");
            testCirc.add("five");
            testCirc.add("six");
            testCirc.add("seven");
            Console.WriteLine("1 " + testCirc.get(1));
            Console.WriteLine("2 " + testCirc.get(2));
            Console.WriteLine("3 " + testCirc.get(3));
            testCirc.add("eight");
            Console.WriteLine("ioOne " + testCirc.indexOf("one"));
            Console.WriteLine(testCirc.indexOf("eight"));

            Console.WriteLine(testCirc.get(1));
            Console.ReadLine();


        }


    }
}
