using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework8
{
    class Program
    {
        
        public class Array
        {
            private int[] _array;

            public Array()
            {
                Size = 1;
                _array = new int[Size];
            }

            public Array(int size)
            {
                Size = size;
                _array = new int[Size];
            }

            public int Size { get; set; }

            public int this[int i]
            {
                get
                {
                    return _array[i];
                }
                set
                {
                    _array[i] = (int)Math.Pow((double)value, 2);
                }
            }

        }
        static void Main(string[] args)
        {
            Array array = new Array(3);
            array[0] = 4;
            array[1] = 134;
            array[2] = 3456;

            for (int i = 0; i < array.Size; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
