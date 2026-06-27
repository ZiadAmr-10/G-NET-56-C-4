namespace Assignment04
{
    internal class ArrayStatistics
    {
        int[] arr;
        public ArrayStatistics(int[] arr)
        {
            this.arr = arr;
        }
        public int GetSum()
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public double GetAverage()
        {
            return (double)GetSum() / arr.Length;
        }
        public int GetMax()
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++) { 
            if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public int GetMin() { 
         int min = arr[0];
            for (int i = 1; i < arr.Length; i++) {
                if (arr[i] < min) { 
                min = arr[i];
                }
            
            }
            return min;
        }
        public void PrintReverse()
        {
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }




    }
}