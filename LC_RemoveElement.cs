public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        int previousIndex = 0;        
        int k = nums.Length;
        for (int currentIndex = 0; currentIndex < nums.Length; currentIndex++)
        {
            if(nums.Length == 1) return 1;
            
            if(nums[currentIndex] == val)
            {
                if(currentIndex != nums.Length - 1)
                    nums[currentIndex] = nums[currentIndex + 1];                            

                k--;
            }            
        }
        return k;
    }
}
