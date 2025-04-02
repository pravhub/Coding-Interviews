public class Solution {
    public string GetHint(string secret, string guess) {
        int bulls = 0;
        int cows = 0;
        var bmap = new Dictionary<char,int>();
        var cmap = new Dictionary<char,int>();
        for(int i=0;i< secret.Length;i++)
        {
            if (secret[i] == guess[i])
                bulls +=1;
            else
            {
                if(bmap.ContainsKey(secret[i]))
                    bmap[secret[i]] +=1;
                else
                    bmap.Add(secret[i], 1);
                if(cmap.ContainsKey(guess[i]))
                    cmap[guess[i]] +=1;
                else
                    cmap.Add(guess[i],1);
            }
        }
        foreach(var kvp in  bmap)
        {
            if (cmap.ContainsKey(kvp.Key))
                cows += Math.Min(kvp.Value, cmap[kvp.Key]);
        }
        return bulls.ToString()+"A"+cows.ToString()+"B";
    }
}
