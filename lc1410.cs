public class Solution {
    public string EntityParser(string text) {
        //return text.Replace("&quot;", "\"").Replace("&apos;","\'").Replace("&amp;","&").Replace("&gt;",">").Replace("&lt;","<").Replace("&frasl;","/");
        
        StringBuilder sb = new StringBuilder();
        int i=0;
        while(i<text.Length)
        {
            if(text[i]=='&')
            {
                StringBuilder cur = new StringBuilder();
                cur.Append(text[i++]);
                int len=0;
                while(i<text.Length && len<8 &&text[i]!=';' && text[i]!='&' )
                {
                    cur.Append(text[i++]);
                    len++;
                }
                if(i<text.Length && text[i]==';')
                {
                    cur.Append(text[i++]);
                    string st = cur.ToString();
                    if(st.Equals("&quot;"))
                    {
                        sb.Append("\"");
                    }
                    else if(st.Equals("&apos;"))
                    {
                        sb.Append("\'");
                    }                        
                    else if(st.Equals("&amp;"))
                    {
                        sb.Append("&");
                    }
                    else if(st.Equals("&gt;"))
                     {
                        sb.Append(">");
                     }
                     else if(st.Equals("&lt;"))
                     {
                         sb.Append("<");
                     }
                    else if(st.Equals("&frasl;"))
                     {
                        sb.Append("/");
                     }
                    else
                    {
                        sb.Append(cur);
                    }
                  }
                else
                {
                    sb.Append(cur);
                    //i++;
                }
                }
                else
                {
                    sb.Append(text[i++]);
                }
        }
        return sb.ToString();
        
    }
}
