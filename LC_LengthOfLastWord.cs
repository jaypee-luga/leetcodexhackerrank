public class Solution {
    public int LengthOfLastWord(string s) {
        if(s.Length == 1) return 1;

        var lastwordLength = 0;
        for(int i = s.Length-1; i >=0; i--)
        {
            if(s[i] != ' ')
                lastwordLength++;
            
            else if(s[i] == ' ' && lastwordLength != 0)
                return lastwordLength;
        }
        return lastwordLength;
    }
}
