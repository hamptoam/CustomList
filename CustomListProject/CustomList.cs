namespace CustomListProject
{
    public class CustomList <T> 
    {
        int count;
        T[] items;
        int capacity;
        int removeAt;
        int i;

    /*    public int this[int index]
        {
            get
            {
                return 
            }
            set
            {

            }
        }
*/
        public interface ICount
        {
            void Count();
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity; 
            }
        }

        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
            removeAt = i;
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

        /* public void Remove(T[] newArray)
         {

         }
         */

        public void Remove(T item)
        {

            if (count > 0)
            {
                // capacity *= 2;
                T[] arrayToShrink = new T[capacity - 1];

                for (int i = capacity; i < count; i--)
                {
                    arrayToShrink[i] = items[i];
                }
                // point "items" to "arrayToResize" X
                items = arrayToShrink;
            }

            // add our item to the next open spot  in the "items" (count?)
            count--;
            items[count - 1] = item;

        }
        //Removing int from list but not sure if right int, find way to move integers over in the capacity

   
    }
}

// Remove(T item)
/*
   public T[] ArrayToRemoveFrom( T[]arrayToResize, int removeThis)
    {
        T[] newArray = new T[arrayToResize.Count - 1];

        int i = 0;
        int b = 0;

        while (i < arrayToResize.Count)

        count--;

               }

}
}*/

    
