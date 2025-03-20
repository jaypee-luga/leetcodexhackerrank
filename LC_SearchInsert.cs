public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var pos = 0;
        for(int i=0; i < nums.Length; i++) {
            if(nums[i] == target)
                return i;            
            if(nums[i] > target)
                return i;
        }
        return nums.Length;
    }
}
