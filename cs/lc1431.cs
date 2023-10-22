public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
      IList<bool> ans = new List<bool>();  
        int max = candies.Max(); //O(len(candies))
        foreach(int i in candies)            
        {
            if(i+extraCandies>=max)
            {
                ans.Add(true);
            }
            else
            {
                ans.Add(false);
            }
        }
        return ans;
    }
}
