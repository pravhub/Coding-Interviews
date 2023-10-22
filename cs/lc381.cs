public class RandomizedCollection {

    Dictionary<int,HashSet<int>> map;
    List<int> ll;
    int lStart;
    int lEnd;
    Random r;
    /** Initialize your data structure here. */
    public RandomizedCollection() {
        map = new Dictionary<int,HashSet<int>>();
        ll = new List<int>();        
        lStart = 0;
        lEnd = -1;
        r = new Random();
    }
    
    /** Inserts a value to the collection. Returns true if the collection did not already contain the specified element. */
    public bool Insert(int val) {
        if(lEnd == ll.Count-1)
        {
            ll.Add(val);
            lEnd++;
        }
        else
        {
            ll[lEnd+1] = val;
            lEnd++;
        } 
        if(map.ContainsKey(val))
        {  
            map[val].Add(lEnd);
            return false;
        }
        else
        {
            HashSet<int> hs = new HashSet<int>();
            hs.Add(lEnd);
            map.Add(val,hs);
            return true;
        }
    }
    
    /** Removes a value from the collection. Returns true if the collection contained the specified element. */
    public bool Remove(int val) {
        if(map.ContainsKey(val))
        {  
            int idx = map[val].First();            
            int temp = ll[lEnd];
            if(temp == val)
            {
                map[val].Remove(lEnd);
            }
            else
            {
                ll[lEnd] = val;
                ll[idx] = temp;
                map[temp].Add(idx);
                map[temp].Remove(lEnd);
                map[val].Remove(idx);
            }
            lEnd--;
            
            if(map[val].Count==0)
                map.Remove(val);
            return true;
        }
        return false;
    }
    
    /** Get a random element from the collection. */
    public int GetRandom() {
        int idx = r.Next(lStart,lEnd+1);        
        int ret = ll[idx];
        return ret;
    }
}
