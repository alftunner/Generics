using System.Collections;
using Generics;

const int COUNT = 10000000;

using (new OperationTimer("List"))
{
    List<int> list = new List<int>(COUNT);
    for (int i = 0; i < COUNT; i++)
    {
        list.Add(i);
        int x = list[i];
    }

    list = null;
}

using (new OperationTimer("ArrayList"))
{
    ArrayList arrayList = new ArrayList();
    for (int i = 0; i < COUNT; i++)
    {
        arrayList.Add(i);
        int x = (int) arrayList[i];
    }

    arrayList = null;
}