namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 0,3,-3,4,-1 };
            printArr(TwoSum(test,-1));
        }
        static void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static int[] TwoSum(int[] nums, int target)
        {
            int index = 0;
            int sum = int.MinValue;
            int[] answer = new int[] { -1,-1};
            while (index < nums.Length && sum != target)
            {
                
                int a = Convert.ToInt32(nums[index]);
                int indexb = index + 1;
                while (indexb < nums.Length && sum != target)
                {
                    int b = nums[indexb];
                    int tempSum = a + b;
                  
                    if (tempSum != target)
                    {
                        indexb++;
                    }
                    else
                    {
                        answer[0] = index;
                        answer[1] = indexb;
                     return answer;

                    }
                }
                if (sum != target || answer[1]==-1)
                {
                    index++;
                }
            }
            return answer;
        }
    }

}