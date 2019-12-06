using System;
namespace ArrayList
{
    public class ArrayList<T>
    {
        private int _size;
        private int _index;
        private T[] _array;

        public ArrayList()
        {
            _size = 10;
            _index = 0;
            _array = new T[_size];
        }

        public void Add(T data)
        {
            if (_index < _size)
            {
                _array[_index] = data;
                _index++;
            }
        }

        public T Get(int index)
        {
            T ret = default;

            try
            {
                ret = _array[index];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ret;
        }

        public int Count()
        {
            return _index;
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _index; i++)
            {
                if (i == Count() - 1)
                {
                    Console.Write(_array[i]);
                }
                else
                {
                    Console.Write(_array[i] + ", ");
                }
            }
            Console.WriteLine("]");
        }
    }
}
