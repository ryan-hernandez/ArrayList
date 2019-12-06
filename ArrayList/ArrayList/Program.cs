using System;
using ArrayList;

namespace ArrayList
{
    class Program
    {
        struct TestStruct
        {
            public ArrayList<int> values;
        };

        static void Main(string[] args)
        {
            ArrayList<TestStruct> list = new ArrayList<TestStruct>();

            var innerList1 = new TestStruct();
            var innerList2 = new TestStruct();

            innerList1.values = new ArrayList<int>();
            innerList2.values = new ArrayList<int>();

            innerList1.values.Add(1);
            innerList1.values.Add(3);
            innerList1.values.Add(5);
            innerList1.values.Add(7);
            innerList1.values.Add(9);

            innerList2.values.Add(2);
            innerList2.values.Add(4);
            innerList2.values.Add(6);
            innerList2.values.Add(8);
            innerList2.values.Add(10);

            list.Add(innerList1);
            list.Add(innerList2);

            for (int i = 0; i < list.Count(); i++)
            {
                list.Get(i).values.Print();
            }
        }
    }
}
