public class Solution {
    public int StrStr(string haystack, string needle) {
        //return haystack.IndexOf(needle);
        
        for(int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if(haystack.Substring(i,needle.Length).Equals(needle))
                return i;
        }
        return -1;
    }
}
