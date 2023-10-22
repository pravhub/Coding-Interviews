
public class TweetCounts {

    Dictionary<string,Dictionary<int,int>> map;
    int minute = 60;
    int hour = 3600;
    int day = 24 * 3600;
    public TweetCounts() {
        map = new Dictionary<string,Dictionary<int,int>>();
    }
    
    public void RecordTweet(string tweetName, int time) {
        if(!map.ContainsKey(tweetName))
        {
            map.Add(tweetName,new Dictionary<int,int>());
        }
        if(!map[tweetName].ContainsKey(time))
        {
            map[tweetName].Add(time,0);
        }
        map[tweetName][time]++;
    }
        public IList<int> GetTweetCountsPerFrequency(string freq, string tweetName, int startTime, int endTime) {
        if(!map.ContainsKey(tweetName))
            return null;
        if(freq.Equals("minute") || freq.Equals("hour")||freq.Equals("day"))
        {
            Dictionary<int,int> tMap = map[tweetName];
            Dictionary<int,int> curMap = tMap.Where(t=>t.Key>= startTime && t.Key <= endTime).ToDictionary(t=>t.Key,t=>t.Value); 
            Dictionary<int,int> ans = new Dictionary<int,int>();
            
            int interval = freq.Equals("minute")?minute:freq.Equals("hour")?hour:day;
            if(freq.Equals("day"))
            {
                IList<int> dayList = new List<int>();
                dayList.Add(curMap.Select(c=>c.Value).Sum());
                return dayList;
            }
            int endT = startTime;
            //int i= startTime/interval;
            while(endT<=endTime) 
            {
                endT += interval;
                ans.Add(endT,0);
                //i++;
                
                // Console.WriteLine(endT);
            }
            Console.WriteLine(ans.Count);
            foreach(var kvp in curMap)
            {
                int roundedBucket = (kvp.Key - startTime) / interval;
                if(roundedBucket == 0)
                {
                    ans[startTime+interval]+=kvp.Value;
                }
                else
                {
                   ans[startTime+interval + roundedBucket * interval] += kvp.Value;
                }
            }
            return ans.Values.ToList();
        }
        else return null;
    }
    
    
    
    
    
