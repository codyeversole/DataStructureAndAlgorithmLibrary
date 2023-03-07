namespace DataStructureAndAlgorithmLibrary.Tests
{
    public class SortServiceTest
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 1 }, new int[] {1,2,3})]
        [InlineData(new int[] { 1, 2, 1 }, new int[] { 1, 1, 2 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { 4, 4, 11, 6, 6, 9, 40, 11, 32, 1, 4, 32, 1 }, new int[] { 1, 1, 4, 4, 4, 6, 6, 9, 11, 11, 32, 32, 40 })]
        public void Bubble_sort_should_be_equal(int[] inputArray, int[] expectedArray)
        {
            var sortService = new SortService();

            var sortedArray = sortService.BubbleSort(inputArray);

            Assert.Equal(expectedArray, sortedArray);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 1, 2, 1 }, new int[] { 1, 1, 2 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { 4, 4, 11, 6, 6, 9, 40, 11, 32, 1, 4, 32, 1 }, new int[] { 1, 1, 4, 4, 4, 6, 6, 9, 11, 11, 32, 32, 40 })]
        public void Selection_sort_should_be_equal(int[] inputArray, int[] expectedArray)
        {
            var sortService = new SortService();

            var sortedArray = sortService.SelectionSort(inputArray);

            Assert.Equal(expectedArray, sortedArray);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 1, 2, 1 }, new int[] { 1, 1, 2 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { 4, 4, 11, 6, 6, 9, 40, 11, 32, 1, 4, 32, 1 }, new int[] { 1, 1, 4, 4, 4, 6, 6, 9, 11, 11, 32, 32, 40 })]
        public void Insertion_sort_should_be_equal(int[] inputArray, int[] expectedArray)
        {
            var sortService = new SortService();

            var sortedArray = sortService.InsertionSort(inputArray);

            Assert.Equal(expectedArray, sortedArray);
        }

    }
}
