/* https://leetcode.com/problems/maximum-candies-you-can-get-from-boxes/
if the initialBoxes is empty return 0
use Queue datastructure to keep track of the boxes to be opened.
use a hashset to hold available keys and "boxes with out keys YET".
while the queue is not empty, proceed and open the box from queue,
if the status is 1 or (status==0 and has a key already) then we proceed to collect candy, keys, contained boxes.
            when collecting keys, see if there is a box waiting in ""boxes with out keys YET" if so, remove it from that and 
            add it to queue.
else add the box to the "boxes with out keys YET"
*/
public class Solution {
    public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes) {
        int totalCandy =0;
        if(initialBoxes.Length==0)
            return totalCandy;
        Queue<int> boxes = new Queue<int>(initialBoxes);
        HashSet<int> boxeWithNoKeysYet = new HashSet<int>();
        HashSet<int> availableKeys = new HashSet<int>();
        while(boxes.Count>0)
        {
            //int[] before = new int[boxes.Count];
            //boxes.CopyTo(before,0);
            int i = boxes.Dequeue();
            if(status[i]==1 || availableKeys.Contains(i))
            {
                if(availableKeys.Contains(i))
                {
                    availableKeys.Remove(i);
                }
                //Console.WriteLine("box {0} is open",i);
                totalCandy+=candies[i];
                foreach(int k in keys[i])
                {
                    availableKeys.Add(k);
                    if(boxeWithNoKeysYet.Contains(k))
                    {
                        boxes.Enqueue(k);
                        boxeWithNoKeysYet.Remove(k);
                    }
                }
                foreach(int b in containedBoxes[i])
                {
                    boxes.Enqueue(b);
                }
            }
            else
            {
                boxeWithNoKeysYet.Add(i);
                /*
                if(boxes.Count==0 && availableKeys.Count ==0)
                    break;
                Console.WriteLine("box {0} is NOT open going back to queue",i);
                boxes.Enqueue(i);
                if(boxes.Count == before.Length && availableKeys.Count ==0)
                {
                    int[] after = new int[boxes.Count];
                    boxes.CopyTo(after,0);
                    Array.Sort(before);
                    Array.Sort(after);
                    bool same = true;
                    for(int j=0;j<boxes.Count;j++)
                    {
                        if(before[j] != after[j])
                        {
                            same = false;
                        }
                    }
                    if(same)
                        break;
                }*/
            }
        }
        return totalCandy;
    }
}
