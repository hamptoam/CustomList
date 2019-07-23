namespace CustomListProject
{
    public class CustomList<T>  
    {
        int count;
        T[] items;
        T[] objects;
        int capacity;
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
            objects = new T[capacity];
            removeAt = i;
        }

        public void Add(T item, T Object)
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
                objects = arrayToResize;
                
            }

            // add our item to the next open spot  in the "items" (count?)
            count++;
            items[count - 1] = item;
            objects[count - 1] = Object; 

        }

        public void Remove(T item, T Object)
        {

            if (count > 0)
            {
                
                T[] arrayToShrink = new T[capacity - 1];

                for (int i = capacity; i < count; i--)
                {
                    arrayToShrink[i] = items[i];
                }
                
                items = arrayToShrink;
            }

            // add our item to the next open spot  in the "items" (count?)
            count--;
            items[count - 1] = item;
            objects[count - 1] = Object; 
        }
        //Removing int from list but not sure if right int, find way to move integers over in the capacity
    

        public void Zip()
        {
            int[] items = { 1, 2, 3, 4 };
            string[] objects = { "person", "place", "thing", "animal" };

            var itemsAndObjects = items.Zip(objects, (first, second) => first + " " + second);

            foreach (var item in itemsAndObjects)
                Console.WriteLine(item);

        }

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

    
