using System;
using ArrayList;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            list.Print();

            list.Add(11);
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(15);
            list.Add(16);
            list.Add(17);
            list.Add(18);
            list.Add(19);
            list.Add(20);
            list.Print();

            list.Add(21);
            list.Print();

            // Tests for AddAt()
            //list.AddAt(0, 1111);
            //list.Print();
            //list.AddAt(1000, 2222);
            //list.Add(3333);
            //list.Print();

            var sum = 0;

            foreach (int l in list)
            {
                sum += l;
            }

            Console.WriteLine(sum);

            var list2 = new ArrayList<string>();

            list2.Add("Testing ");
            list2.Add("enumeration ");
            list2.Add("of ");
            list2.Add("strings.");

            var str = "";

            foreach(string l in list2)
            {
                str += l;
            }

            Console.WriteLine(str);

            list2.RemoveAt(2);
            list2.Print();

            list.RemoveAt(0);
            list.Print();
            list.RemoveAt(0);
            list.Print();
            list.RemoveAt(0);
            list.Print();

            list.Update(0, 9999);
            list.Update(10, 9999);
            list.Print();
        }
    }
}
