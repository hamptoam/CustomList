using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable<T>
    {
        public int Count { get; private set; }
        private T[] Items;

        public T this[int i]
        {
            get => Items[i];

            set => Items[i] = value;
        }

        public interface ICount
        {
            void Count();
        }

       
        public int Capacity
        {
            get
            {
                return Items.Length; 
            }
        }
        public CustomList()
        {
            Count = 0;
            Items = new T[Capacity];
        }

        public void Add(T item)
        {
            if (Count >= Capacity)
            {
               // Capacity *= 2;
                T[] arrayToResize = new T[Capacity * 2];

                for (int i = 0; i < Items.Length; i++)
                {
                    arrayToResize[i] = Items[i];
                }
                Items = arrayToResize;
            }
            Count++;
            Items[Count] = item;
        }

        public bool Remove(T item)
        {
          
            if (Count == 0)
            {
                return false;
            }
            else
            {
                T[] arrayToShrink = new T[Capacity];
                
                //T valueToRemove = Items[i];

                for (int i = 0; i < Count; i++)
                {
                    if (EqualityComparer<T>.Default.Equals(Items[i], item)); // Couldn't find other option to compare 2 T type objects
                    {
                        Count--;
                        return true;
                    }

                }

                Items = arrayToShrink;
            }

            Count--;
            Items[Count - 1] = item;
            return false;
        }
     
       public void Zip(CustomList<T> listToAdd)
        {
            
            if (Items.Length <= 0 || listToAdd.Count <= 0)
            {
                return;
            }
            else
            {



            }
        }

        public void toString()
        {


        }

        public IEnumerator<T> GetEnumerator()
        {
           for(int i = 0; i < Count; i++)
           {
                yield return Items[i];
           }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}



    
