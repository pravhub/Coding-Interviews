public class RandomizedSet {

    Dictionary<int,int> map;
    List<int> ll;
    int lStart;
    int lEnd;
     Random r;
    /** Initialize your data structure here. */
    public RandomizedSet() {
        map = new Dictionary<int,int>();
        ll = new List<int>();        
        lStart = 0;
        lEnd = -1;
        r = new Random();
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if(!map.ContainsKey(val))
        {            
            if(lEnd == ll.Count-1)
            {//no elements removed yet.
                ll.Add(val);
                lEnd++;
            }
            else
            {
                ll[lEnd+1] = val;
                lEnd++;
            }            
            map.Add(val,lEnd);
            return true;
        }
        return false;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if(map.ContainsKey(val))
        {   
            int idx = map[val];
            int temp = ll[lEnd];
            ll[lEnd] = val;
            ll[idx] = temp;
            map[temp] = idx;
            lEnd--;
            map.Remove(val);
            return true;
        }
        return false;
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
       
        
        int idx = r.Next(lStart,lEnd+1);        
        int ret = ll[idx];
      
        return ret;
    }
}
