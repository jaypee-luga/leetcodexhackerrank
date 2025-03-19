public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int previousIndex = 0;
        int uniqueIndex = 0;
        int uniqueNumCtr = 1;
        for (int currentIndex = 0; currentIndex < nums.Length; currentIndex++)
        {
            if(nums.Length == 1)
                return uniqueNumCtr;
            
            if(nums[previousIndex] != nums[currentIndex])
            {
                previousIndex = currentIndex;
                uniqueIndex++;
                nums[uniqueIndex] = nums[currentIndex];
                uniqueNumCtr++;
            }            
        }

        return uniqueNumCtr;
    }
}
