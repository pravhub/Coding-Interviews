class Solution {
    public boolean checkInclusion(String p, String s) {        
        HashMap<Character, Integer> map = new HashMap<Character, Integer>();
        for(char c : p.toCharArray())
        {
            if(!map.containsKey(c))
            {
                map.put(c,0);
            }
            map.put(c,map.get(c)+1);
        }
        HashMap<Character, Integer> smap = new HashMap<Character, Integer>();
        for(int i=0;i<s.length();i++)
        {
            if(!smap.containsKey(s.charAt(i)))
            {
                smap.put(s.charAt(i),1);
            }            
            else
            {
                smap.put(s.charAt(i),map.get(s.charAt(i))+1);
            }
            if(i>=p.length()-1)
            {
                if(CheckIfMapsAreEqual(map, smap))
                {
                   return true;
                }
                char ch = s.charAt(i-p.length()+1);
                int val = smap.get(ch);
                smap.put(ch,val-1);
                if(smap.get(ch)==0)
                {
                    smap.remove(ch);
                }
            }
        }
        return false;
    }
    private boolean CheckIfMapsAreEqual(HashMap<Character, Integer> a, HashMap<Character, Integer> b)
    {
        if(a.size() != b.size())
            return false;
        for(char c: a.keySet())
        {
            if(b.containsKey(c) && a.get(c) ==b.get(c))
            {
                //we are good
            }
            else
            {
                return false;
            }
        }
        return true;
    }    
}
