using System;
using System.Collections.Generic;
using System.Text;

namespace LabGenerics
{
    class GenericList<T>
    {
        private T[] array= new T[10];
        private int index = 0;

        public void Add(T element) 
        {
            array[index] = element;
            index++;
        }

        public T GetAt(int position) 
        {
            return array[position];
        }
    }
}
