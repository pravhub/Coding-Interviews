

public class SortFunc : IComparer<KeyValuePair<string,int>>
{
    public int Compare(KeyValuePair<string,int> a, KeyValuePair<string,int> b)
    {
      if(a.Value == b.Value)
      {
        return a.Key.CompareTo(b.Key);
      }
      else if (a.Value > b.Value)
         return 1;
      else // (a.Value < b.Value)
         return -1;
         
    }
}
/*
time = O(level * (avg of friends in each level))  + O(number of friends in "level") + O(vidCount * log(vidCount))
space: O(3 * avg of friends in each level) + O(avg of list of friends * avg of videos watched) + O(2 * avg. of videos watched)
*/
public class Solution {
    public IList<string> WatchedVideosByFriends(IList<IList<string>> watchedVideos, int[][] friends, int id, int level) {
        List<int> l1Friends = new List<int>(friends[id]);
        List<int> lnFriends = new List<int>(friends[id]);
        level--;
        HashSet<int> levelsOfFriends= new HashSet<int>(friends[id]);
        levelsOfFriends.Add(id);
        while(level>0)
        {
            lnFriends = new List<int>();
            foreach(var f in l1Friends)
            {
                lnFriends.AddRange(friends[f].Where(i=>!levelsOfFriends.Contains(i)));
                levelsOfFriends.Add(f);
            }   
            //Console.WriteLine("{0}",string.Join(" ",levelsOfFriends));
            level--;
            l1Friends = lnFriends.ToList();
        }
        List<string> videos = new List<string>();
        foreach(var f in lnFriends.Distinct())
        {
            //if(f != id)
            {
                videos.AddRange(watchedVideos[f]);
            }
        }
        
        var map = videos.GroupBy(v=>v).ToDictionary(x=>x.Key,x=>x.Count()).OrderBy(v=>v,new SortFunc()).ToDictionary(x=>x.Key,x=>x.Value);
        
        return map.Keys.ToList();
    }
}
