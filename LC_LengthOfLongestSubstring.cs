public class Solution {
    public int LengthOfLongestSubstring(string s) {

        if (s is {Length: 0}) return 0;

        if (s is {Length: 1}) return 1;
        else 
        {
            var nonRepeatingSubstring = new Dictionary<string, int>();
            var rightPtr = 1;

            for(int leftPtr = 0; (leftPtr + rightPtr) < s.Length; leftPtr++)
            {
                while(leftPtr + rightPtr < s.Length - 1)
                {
                    if(nonRepeatingSubstring.ContainsKey(s.Substring(leftPtr, rightPtr)))
                        nonRepeatingSubstring[s.Substring(leftPtr, rightPtr)] += 1;
                    else
                        nonRepeatingSubstring[s.Substring(leftPtr, rightPtr)] = 1;

                    rightPtr++;
                }
                rightPtr = 1;
            }

            return nonRepeatingSubstring.MaxBy(nrs => nrs.Value).Value;
        }

        return -1;
    }
}
