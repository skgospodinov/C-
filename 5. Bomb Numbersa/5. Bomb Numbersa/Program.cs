namespace _5._Bomb_Numbersa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombNumb = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int i = 0; i < nums.Count; i++)
            {
                if (nums[i]== bombNumb[0])
                {
                    for (int j = 0; j < bombNumb[1]; j++)
                    {
                        nums.RemoveAt(i -j-1);
                    }
                    nums.RemoveAt(i- bombNumb[1]);
                    for (int j = 0; j < bombNumb[1]; j++)
                    {
                        nums.RemoveAt(i +j-2);
                    }
                                   
                }
            }
            Console.WriteLine(nums.Sum());
            


        }
    }
}