using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        T[] items;
        int count;
        int capacity;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        public void Add(T item)
        {

            if (count == capacity)
            {
                capacity *= 2;
                T[] arrayToResize = new T[capacity]; 

                for (int i = 0; i < count; i++)
                {
                    arrayToResize[i] = items[i];
                }
                // point "items" to "arrayToResize" X
                items = arrayToResize;
            }

            // add our item to the next open spot  in the "items" (count?)
            count++;
            items[count - 1] = item;

        }

        public void Remove(T item)
        {

        }

        //public static void Add(T item)
        //{
        //    T[] arrayToResize = T[] items;
        //    T[] elementsArray;
        //    T arrayLength = arrayToResize.Count + elementsArray.count;
        //    T[] resizedArray = new T[arrayLength];



        //    for (int i = arrayToResize.count; i < arrayLength; i++)
        //    {
        //        resizedArray[i] = arrayToResize[counter];

        //        counter++; 
        //    }
        //}

    }
}
