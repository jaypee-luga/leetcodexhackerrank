public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        int overwritePosition = 0; 
        for(int iterator = 0; iterator < nums.Length; iterator++)
        {
            if(nums[iterator] == val)
                continue;
            else
            {
                nums[overwritePosition] = nums[iterator];
                overwritePosition++;
            }
        }

        return overwritePosition;
        
    }
    
}
