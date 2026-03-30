public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        foreach(char item in s)
        {
            if(item == '[' || item=='{' || item =='('){
                stack.Push(item);
            }else{
                if(stack.Count > 0)
                {
                    if(item == ')' && stack.Peek() != '('){
                        return false;
                    }
                    if(item == '}' && stack.Peek() != '{' )
                    {
                        return false;
                    }
                    if(item == ']' && stack.Peek() != '[' )
                    {
                    return false;
                    }
                    stack.Pop();
                }else{
                    return false;
                }
            }
           
        }
        return stack.Count == 0;
    }
}
