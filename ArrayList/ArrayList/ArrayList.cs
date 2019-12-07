using System;
using System.Collections;

namespace ArrayList
{
    {
        private int _size;
        private int _index;
        private T[] _array;

        private int _position = -1;

        public ArrayList()
        {
            _size = 10;
            _index = 0;
            _array = new T[_size];
        }

        public ArrayList(int size)
        {
            _size = size;
            _index = 0;
            _array = new T[_size];
        }

        public void Add(T data)
        {
            if (_index >= _size)
            {
                Resize();
            }

            _array[_index] = data;
            _index++;
        }

        public void AddAt(int index, T data)
        {
            if (index > _index)
            {
                while (index >= _size)
                {
                    Resize();
                }

                _array[index] = data;
                _index = index + 1;
            }
            else
            {
                if (_index >= _size)
                {
                    Resize();
                }

                T tmp = _array[index];
                _array[index] = data;

                for (int i = index + 1; i < _index + 1; i++)
                {
                    var curr = _array[i];
                    _array[i] = tmp;
                    tmp = curr;
                }

                _index++;
            }
        }

        public int Count()
        {
            return _index;
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _index; i++)
            {
                yield return _array[i];
            }
        }

        public void Remove()
        {
            try
            {
                if (_index - 1 < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                _array[_index] = default;
                _index--;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoveAt(int index)
        {
            try
            {
                if (index == _index)
                {
                    _array[index] = default;
                    _index--;
                }
                else
                {
                    _array[index] = default;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Reduce()
        {
            // TODO: implement
        }

        public void Resize()
        {
            _size *= 2;
            T[] tmp = _array;

            _array = new T[_size];

            for (int i = 0; i < tmp.Length; i++)
            {
                _array[i] = tmp[i];
            }
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
