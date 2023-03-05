using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_Array
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            var nums = new int[] { 1, 1, 2 };
            Console.WriteLine($"Distinct items = {FindDistinctMembersInArray(nums)}");
        }

        public int FindDistinctMembersInArray(int[] nums)
        {
            try
            {
                int index = 1;
                for (int current = index; current < nums.Length; current++)
                {
                    if (nums[current] != nums[current - 1])
                        nums[index++] = nums[current];
                }
                return index;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
