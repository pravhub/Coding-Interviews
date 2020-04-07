

public class Solution {
    public IList<int> PathInZigZagTree(int label) {
       
        int level  = 0;
        int curCount = 0;
        while(curCount < label)
        {
            curCount += (int) Math.Pow(2, level);
            level++;
        }
        level--;
        //Console.WriteLine(level);
        List<int> ans = new List<int>();
        while(level>0)
        {
            ans.Insert(0,label);
            int parent = -1;
            if(label % 2 ==0)
            {
                 parent = label/2;

            }
            else
            {
                 parent = (label-1)/2;
            }
            int prevLevel = level-1;
            int nodeCountPrevLevel = (int)Math.Pow(2,prevLevel);
            int start = nodeCountPrevLevel;
            int[] arr = new int[nodeCountPrevLevel];
            int idx = 0;
            int parentIdx = -1;
            /*
            arr = [8,9,10,11,12,13,14,15] - level 3
            */
            while(nodeCountPrevLevel > 0)
            {
                if(start == parent)
                {
                    parentIdx = idx;
                }
                arr[idx++] = start++;
                nodeCountPrevLevel--;
            }
            Array.Reverse(arr);
            label = arr[parentIdx];
            level--;
        }
        ans.Insert(0,1);
        return ans;
    }
}
