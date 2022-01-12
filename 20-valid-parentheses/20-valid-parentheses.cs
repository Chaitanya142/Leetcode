public class Solution
{
    public bool IsValid(string s)
    {
        Console.WriteLine(s.Length);
        Console.WriteLine(s[0]);
        int length = s.Length;
        if (length % 2 == 1)
            return false;
        //int count=0;
        //while(count<s.Length/2){
        //  if(isValidClosingChar(s[count],s[length-count-1])){
        //    count++;
        // }else{
        //    return false;
        // }
        //}
        Stack<char> myStack = new Stack<char>();

        foreach (char c in s)
        {
            char m = getOpeningChar(c);
            if (m == ' ')
                myStack.Push(c);
            else
            {
                if (myStack.Count == 0)
                {
                    return false;
                }
                char n = myStack.Pop();
                if (n != m)
                    return false;
            }
        }

        if (myStack.Count > 0)
            return false;
        return true;
    }

    /*public char getClosingChar(char s){
        switch(s){
            case '{': return '}';
            case '(': return ')';
            case '[':return ']';
            default:return ' ';
                break;
        }
    }*/

    public char getOpeningChar(char s)
    {
        switch (s)
        {
            case '}': return '{';
            case ')': return '(';
            case ']': return '[';
            default: return ' ';

        }
    }

}