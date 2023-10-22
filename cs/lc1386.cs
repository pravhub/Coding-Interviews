/*
we need arrange 4person families in the rows.
we can split across isle but exactly two people on each side.
- with that we can fit max of 2 families (4person)  per row 
    - n rows , so 2*n (=totalCount) families can be arranged.
- now with the following constraints we need to decrement the totalCount.
- for a given row if seats 2 or 3 or 4 or 5  reserved then we cannot allocate a family by split
     similarly if seats 6 or 7 or 8 or 9 reserved then also  we cannot allocate a family by split
- final case is if 4,5,6 or 7 is reserved then we cannot allocate for a family (together))
*/
public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        Dictionary<int, HashSet<int>> map = new Dictionary<int, HashSet<int>>();
        int fourFamilies = n * 2;
        int m = reservedSeats.Length;
        for(int i=0;i<m;i++)
        {
            int row = reservedSeats[i][0];
            int seat = reservedSeats[i][1];
            if(!map.ContainsKey(row))
            {
                map.Add(row, new HashSet<int>());
            }
            map[row].Add(seat);
        } 
        //m
        foreach(var kvp in map)
        {
            int decremented = 0;
            if(kvp.Value.Contains(2) || kvp.Value.Contains(3) || kvp.Value.Contains(4) || kvp.Value.Contains(5))
            {
                decremented++;
                fourFamilies--;
            }
            if(kvp.Value.Contains(6) || kvp.Value.Contains(7) || kvp.Value.Contains(8) || kvp.Value.Contains(9))
            {
                decremented++;
                fourFamilies--;
            }
            if(!kvp.Value.Contains(4) && !kvp.Value.Contains(5) && !kvp.Value.Contains(6) && !kvp.Value.Contains(7))
            {
                if(decremented==2)
                {
                    fourFamilies++;
                }
            }
        }
        return fourFamilies;
    }
}
