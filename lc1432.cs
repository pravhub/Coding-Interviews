public class Solution {
    public int MaxDiff(int num) {
        char[] arr = num.ToString().ToCharArray();
        int a = int.Parse(ChooseMaxNum(arr));
        int b = int.Parse(ChooseMinNum(arr));
        return a-b;
    }
    private string ChooseMinNum(char[] c)
    {
        int len = c.Length;
        char act=' ';
        StringBuilder sb = new StringBuilder();
        char rep=' ';
        if(c[0]=='1')
        {
            for(int i=1;i<len;i++)
            {
                if(c[i]!='0')
                {
                    if(c[i]=='1')
                    {
                        
                    }
                    else
                    {
                        act = c[i];
                        rep = '0';
                        break;
                    }
                }
            }
        }
        else
        {
            act = c[0];
            rep='1';
        }
        for(int i=0;i<len;i++)
        {            
            if(c[i]==act)
            {                
               // Console.WriteLine("{0},rep={1},act={2}",c[i],rep,act);
               sb.Append(rep);
            }
            else
            {
                sb.Append(c[i]);
            }
        }
        return sb.ToString();
    }
    private string ChooseMaxNum(char[] c)
    {
        int len = c.Length;
        char rep=' ';
        StringBuilder sb = new StringBuilder();
        
        for(int i=0;i<len;i++)
        {
            if(c[i]!='9')
            {
                rep = c[i];
                break;
            }
        }
        for(int i=0;i<len;i++)
        {
            if(c[i]==rep)
            {
                sb.Append('9');
            }
            else
            {
                sb.Append(c[i]);
            }
        }
        return sb.ToString();
    }
}
