public class Solution {
    public string ValidIPAddress(string IP) {
        if(string.IsNullOrEmpty(IP))
            return "Neither";
        string []v4 = IP.Split(".");
        string []v6 = IP.Split(":");
        
        if( (v4.Length==1 && v6.Length==1) || (v4.Length!=4 && v6.Length==1) ||(v4.Length==1 && v6.Length!=8))
        {
            //Console.WriteLine("len4={0}, len6={1}",v4.Length, v6.Length);
            return "Neither";
        }
        else if(v4.Length==4)
        {
            for(int i=0;i<4;i++)
            {
                if(string.IsNullOrEmpty(v4[i]) || !NoLeadingZero(v4[i])  || !ValidRange(v4[i]))
                    return "Neither";
            }
            return "IPv4";
        }
        else if(v6.Length==8)
        {//v6
            for(int i=0;i<8;i++)
            {
                if(string.IsNullOrEmpty(v6[i]) || v6[i].Length>4 || v6[i][0]=='-' || !ValidRangeV6(v6[i]))
                    return "Neither";
                
            }
            return "IPv6";
        }
        else
        {
            return "Neither";
        }
    }
    private bool ValidRangeV6(string str)
    {
        foreach(char c in str)
        {
            if((c>='0' && c<='9') || (c>='a' && c<='f') || (c>='A' && c<='F'))
            {
                //we are good'
            }
            else
            {
                //Console.WriteLine("not a valid v6 range");
                return false;
            }
        }
        return true;
    }
    private bool ValidRange(string str)
    {
        if(string.IsNullOrEmpty(str) || str[0]=='-')
            return false;
        int part;
        if(int.TryParse(str, out part) && part>=0 && part<=255)
        {
            return true;
        }
        return false;
    }
    private bool NoLeadingZero(string str)
    {
        if(string.IsNullOrEmpty(str))
            return false;
        if(str.Length>1 && str[0]=='0')
            return false;
        else
            return true;
    }
}
