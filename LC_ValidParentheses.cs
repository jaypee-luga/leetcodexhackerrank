public class Solution {
    public bool IsValid(string s) {
        
        var stack = new Stack<char>();
		foreach(var c in s.ToCharArray())
        {
			if(stack.Count > 0)
			{
				var topStack = stack.Peek();
				
				if(topStack== '(' && c == ')'){
					stack.Pop();
					continue;
				}
				else if(topStack == '{' && c == '}'){
					stack.Pop();
					continue;
				}
				else if(topStack == '[' && c == ']'){
					stack.Pop();
					continue;
				}
				else
					stack.Push(c);
			}
			else
			{
            	stack.Push(c);	
			}
        }
		
		return stack.Count == 0;
    }
}
