using SortAlgoritms;
using SortAlgoritms.Algoritms;

namespace SortAlgoritms_UT
{
    public class SortAlgoritms_UT
    {
        [Fact]
        public void BubbleSort_UT()
        {
            BubbleSort bs= new BubbleSort();
            int[] data = bs.GetDisorder(100);
            var dataSorted = bs.Sort(data);
            Assert.True(bs.Validation(dataSorted));
        }

        [Fact]
        public void CountingSort_UT()
        {
            CountingSort bs = new CountingSort();
            int[] data = bs.GetDisorder(100);
            var dataSorted = bs.Sort(data);
            Assert.True(bs.Validation(dataSorted));
        }

        [Fact]
        public void HeapSort_UT()
        {
            HeapSort bs = new HeapSort();
            int[] data = bs.GetDisorder(100);
            var dataSorted = bs.Sort(data);
            Assert.True(bs.Validation(dataSorted));
        }

        [Fact]
        public void InsertionSort_UT()
        {
            InsertionSort bs = new InsertionSort();
            int[] data = bs.GetDisorder(100);
            var dataSorted = bs.Sort(data);
            Assert.True(bs.Validation(dataSorted));
        }

        [Fact]
        public void QuickSort_UT()
        {
            QuickSort bs = new QuickSort();
            int[] data = bs.GetDisorder(100);
            var dataSorted = bs.Sort(data);
            Assert.True(bs.Validation(dataSorted));
        }

        [Fact]
        public void RadixSort_UT()
        {
            RadixSort bs = new RadixSort();
            int[] data = bs.GetDisorder(100);
            var dataSorted = bs.Sort(data);
            Assert.True(bs.Validation(dataSorted));
        }

        [Fact]
        public void SelectionSort_UT()
        {
            SelectionSort bs = new SelectionSort();
            int[] data = bs.GetDisorder(100);
            var dataSorted = bs.Sort(data);
            Assert.True(bs.Validation(dataSorted));
        }
    }
}