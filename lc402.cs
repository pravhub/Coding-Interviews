/*
keep track of the highest element from left to right. 
move forward as long as its increasing. 
at some point if it decreases then the number before decrease is candidate to be removed.
decrement k and continue the above process until k=0.
*/
public class Solution {
    public string RemoveKdigits(string num, int k)
    {
        int n = num.Length;
        if(n==k)
            return "0";
        if(n==0)
            return num;
        Stack<char> s = new Stack<char>();
        int i = 0;
        s.Push(num[i]);
        i++;
        while(i<n) 
        {
            while(k>0 && s.Count>0 && s.Peek()>num[i])
            {
                s.Pop();
                k--;
            }
            s.Push(num[i]);
            i++;
        }        
        while(k>0)
        {
            s.Pop();
            k--;
        }
        StringBuilder sb = new StringBuilder();    
        while(s.Count>0)
        {
            sb.Insert(0,s.Pop());
        }
        return TrimZeros(sb.ToString());
    }
    public string RemoveKdigitsWithoutStack(string num, int k) {
        int n = num.Length;
        if(n==k)
            return "0";
        
        while(k>0)
        {
            StringBuilder sb = new StringBuilder();
            n = num.Length;
            char max = num[0];
            bool charFound = false;
            for(int i=1;i<n;i++)
            {
                if(!charFound)
                {
                    if(num[i]>=max)
                    {
                        max = num[i];
                        sb.Append(num[i-1]);
                    }
                    else
                    {
                        charFound = true;
                        sb.Append(num[i]);
                    }
                }
                else
                {
                    sb.Append(num[i]);
                }
            }
            num = sb.ToString();
            //Console.WriteLine("k={0},num={1}",k,num);
            k--;
        }
        return TrimZeros(num);
    }
    
    private string TrimZeros(string s)
    {
        StringBuilder sb = new StringBuilder();
        int idx = 0;
        while(idx<s.Length && s[idx]=='0')
        {
            idx++;
        }
        while(idx<s.Length)
        {
            sb.Append(s[idx++]);
        }
        if(sb.Length==0)
            sb.Append('0');
        return sb.ToString();
    }
}
