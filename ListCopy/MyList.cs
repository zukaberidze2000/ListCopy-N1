using System;
using System.Collections.Generic;
using System.Text;

namespace ListCopy
{
    class MyList<T> : IEnumerator
    {
        public List<T> list = new List<T>();

        public void AddNumber(T num)
        {
            list.Add(num);
        }
    }

    internal interface IEnumerator
    {
    }
}