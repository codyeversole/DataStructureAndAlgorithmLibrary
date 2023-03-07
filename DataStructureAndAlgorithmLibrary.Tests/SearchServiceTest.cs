namespace DataStructureAndAlgorithmLibrary.Tests
{
    public class SearchServiceTest
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 1 }, 3, 0)]
        [InlineData(new int[] { 3, 2, 1 }, 40, null)]
        [InlineData(new int[] { 4, 4, 11, 6, 6, 9, 40, 11, 32, 1, 4, 32, 1 }, 40, 6)]
        public void Linear_search_should_be_equal(int[] inputArray, int searchValue, int? expectedIndex)
        {
            var searchService = new SearchService();

            var index = searchService.LinearSearch(inputArray, searchValue);

            Assert.Equal(expectedIndex, index);
        }

        [Theory]
        [InlineData(new int[] { 1,2,3 }, 3, 2)]
        [InlineData(new int[] { 1,2,3 }, 40, null)]
        [InlineData(new int[] { 1, 1, 4, 4, 4, 6, 6, 9, 11, 11, 32, 32, 40 }, 9, 7)]
        [InlineData(new int[] { 1, 1, 4, 4, 4, 6, 7, 9, 11, 11, 32, 32, 40 }, 6, 5)]
        public void Binary_search_should_be_equal(int[] inputArray, int searchValue, int? expectedIndex)
        {
            var searchService = new SearchService();

            var index = searchService.BinarySearch(inputArray, searchValue);

            Assert.Equal(expectedIndex, index);
        }

    }
}
