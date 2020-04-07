/*
first we need to split the given string into two parts such that
each part is at least 1 character. (excluding the brackets)
for each part there are several cases to be looked at 
(with logic below) and generate possible coordinates:

00011--> 0001,1 for ex. 0.001
(00, 011)
string starting 0:
      - if it does NOT end with zero we put a decimal point       
string ending with 0:
      - if it does NOT start with zero then we just take that number as is.
string with both starting and ending with 0:
     - discard this number for processing
if string length ==1 
     - just take that number
if string length >1 and the converted integer ==0 then discard 
that number for eg:"001","000";

once the coordinates are generated for both parts: 
use the cross product logic to come up with final list of coordinates.

for eg:
"(123)"
part1 - "1" -- coordinates = [1]
part2 - "23"-- coordinattes = [23,2.3]
crossproduct: [(1,23), (1,2.3)] 
part1 - "12" -- coordinates = [12, 1.2]
part2 - "3"-- coordinattes = [3]
crossproduct: [(12,3), (1.2,3)] 

final answer = [(1,23), (1,2.3),(12,3), (1.2,3)]  
*/
public class Solution {
    public IList<string> AmbiguousCoordinates(string S) {
        int n= S.Length;
        IList<string> ans = new List<string>();
        for(int i = 1;i<=S.Length-3;i++)
        {
            string substr1 = S.Substring(1,i);
            string substr2 = S.Substring(i+1, n-i-2);
            
            var coord1  = GenerateCordinates(substr1);
            var coord2  = GenerateCordinates(substr2);
            //Console.WriteLine("{0},{1}",substr1,string.Join(" ",coord1));
            //Console.WriteLine("{0},{1}",substr2,string.Join(" ",coord2));
            if(coord1 != null && coord2 != null)
            {
                foreach(string s1 in coord1)
                {
                    foreach(string s2 in coord2)
                    {
                        ans.Add(string.Format("({0}, {1})",s1,s2));
                    }
                }
            }
        } 
        return ans;
    }
    private List<string> GenerateCordinates(string s)
    {
        List<string> res = new List<string>();
        if(int.TryParse(s, out int i))
        {
            if(s.Length > 1 && i ==0)
            {
                return res;
            }
            else if(s.Length==1)
            {
                res.Add(i.ToString());
            }
            else if(!s.StartsWith('0') && s.EndsWith('0'))
            {
                res.Add(s);
            }
            else if(!s.EndsWith('0') && i.ToString().Length < s.Length)
            {
                res.Add(s.Insert(1,"."));
            }
            else if(!s.EndsWith('0'))
            {
                double d = (double)i;
                res.Add(d.ToString());
                while(d>10)
                {
                    res.Add((d/10).ToString());
                    d = d/10;
                }
                
            }
        }
        return res;
    }
}
