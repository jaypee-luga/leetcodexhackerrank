int[] nums = {1,1,2};
HashSet<int> unique = new HashSet<int>();
for (int i = 0; i < nums.Length; i++)
{
	if(nums.Length == 1)
		 1.Dump();

	if (unique.Count() > 0 && unique.Contains(nums[i]))
	{
		nums[i] = nums[i + 1];
	}
	else
	{
		unique.Add(nums[i]);
	}
}
