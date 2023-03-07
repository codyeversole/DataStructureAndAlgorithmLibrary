namespace DataStructureAndAlgorithmLibrary
{
    public interface ISortService
    {
        int[] BubbleSort(int[] array);
        int[] SelectionSort(int[] array);
        int[] InsertionSort(int[] array);
    }

    public class SortService: ISortService
    {
        /// <summary>
        /// Sorts an array of integers in ascending order. O(N²) 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] BubbleSort(int[] array)
        {
            bool sorted = false;

            while(sorted == false)
            {
                sorted = true;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    int v1 = array[i];
                    int v2 = array[i + 1];  

                    if(v1 > v2)
                    {
                        array[i] = v2;
                        array[i + 1] = v1;

                        sorted = false;
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// Sorts an array of integers in ascending order. O(N²). Twice as fast as BubbleSort
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int lowestIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[lowestIndex])
                    {
                        lowestIndex = j;
                    }
                }

                if(lowestIndex != i)
                {
                    var temp = array[i];
                    array[i] = array[lowestIndex];
                    array[lowestIndex] = temp;
                }
            }

            return array;
        }

        /// <summary>
        /// Sorts an array of integers in ascending order.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int position = i - 1;
                while(position >= 0)
                {
                    if (array[position] > temp)
                    {
                        array[position + 1] = array[position];

                        if(position == 0)
                        {
                            array[0] = temp;
                        }
                    }
                    else
                    {
                        array[position + 1] = temp;
                        break;
                    }

                    position--;
                }
            }

            return array;
        }

    }
}