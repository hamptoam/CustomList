using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable<T>
    {
        public int count { get; set; }
        private T[] items;
        int removeAt;
        int i;

        public T this[int i]
        {
            get => items[i];

            set => items[i] = value;
        }

        public interface ICount
        {
            void Count();
        }

       
        public int Capacity
        {
            get
            {
                return items.Length; 
            }
        }
        public CustomList()
        {
            count = 0;
            items = new T[Capacity];
        }

        public void Add(T item)
        {

            if (count >= Capacity)
            {
                Capacity *= 2;
                T[] arrayToResize = new T[Capacity];

                for (int i = 0; i < count; i++)
                {
                    arrayToResize[i] = items[i];
                }
                // point "items" to "arrayToResize" X
                items = arrayToResize;
              //  Objects = arrayToResize;

            }

            // add our item to the next open spot  in the "items" (count?)
            count++;
            items[count - 1] = item;
            objects[count - 1] = Object;

        }

        public void Remove(T item)
        {

            if (count == 0)
            {
                return;
            }
            else
            {
                T[] arrayToShrink = items;

                for (int i = Capacity; i > 0; i--)
                {
                    if (arrayToShrink.Length > i)
                    {



                    }

                }
                items = arrayToShrink;
            }

            // add our item to the next open spot  in the "items" (count?)
            count--;
            items[count - 1] = item;
            //objects[count - 1] = object;
        }
        //Removing int from list but not sure if right int, find way to move integers over in the capacity


       // T[]  = new T[];


        public void Zip(CustomList<T> listToAdd)
        {
            
            if (items.Length <= 0 || listToAdd.count <= 0)
            {
                return;
            }
            else
            {



            }

           //T[] oldlist = new T[count];

           // var itemsAndObjects = items.Add(objects, (first, second) => first + " " + second);
        }

        public void toString()
        {


        }

        public IEnumerator<T> GetEnumerator()
        {
           for(int i = 0; i < count; i++)
           {
                yield return items[i];
           }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}



    
