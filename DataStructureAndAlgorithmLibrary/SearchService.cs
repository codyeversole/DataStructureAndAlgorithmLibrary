namespace DataStructureAndAlgorithmLibrary
{
    public interface ISearchService
    {
        int? LinearSearch(int[] array, int searchValue);
        int? BinarySearch(int[] array, int searchValue);
    }

    public class SearchService: ISearchService
    {
        /// <summary>
        /// Returns first index matching search value. Returns null if value is not found. O(N) 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public int? LinearSearch(int[] array, int searchValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchValue)
                {
                    return i;
                }             
            }

            return null;
        }

        /// <summary>
        /// Returns first index matching search value. Returns null if value is not found. Array must be sorted. O(log N) 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public int? BinarySearch(int[] array, int searchValue)
        {
            int lowerBound = 0;
            int upperBound = array.Length - 1;

            while(lowerBound <= upperBound)
            {
                int midpoint = (upperBound + lowerBound) / 2;

                if(searchValue == array[midpoint])
                {
                    return midpoint;
                }
                else if(searchValue < array[midpoint])
                {
                    upperBound = midpoint - 1;
                }
                else
                {
                    lowerBound = midpoint + 1;
                }
            }

            return null;
        }

    }
}
