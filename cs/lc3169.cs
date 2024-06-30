public class Solution {
    public int CountDays(int days, int[][] meetings) {
        Array.Sort(meetings, new EqualityComparer());

        // foreach(var x in meetings)
        // {
        //     Console.WriteLine($"{x[0]},{x[1]}");
        // }
        int n = meetings.Length;
        int count = meetings[0][0] - 1;
        int start = meetings[0][0];
        int end = meetings[0][1];
        for(int i = 1; i< n; i++)
        {
            if(end >= meetings[i][0])
            {
                end = Math.Max(end, meetings[i][1]);
            }
            else
            {
                int noMeetings = meetings[i][0] - end - 1;
                count += noMeetings;
                start = meetings[i][0];
                end = meetings[i][1];
            }
        }   
        // Console.WriteLine($"{start},{end}");
        count += (days - end);
        return count;
    }
}
class EqualityComparer : IComparer<int[]>
{
    public int Compare(int[] b1, int[] b2)
    {        
        if(b1[0] < b2[0])
            return -1;
        else if(b1[0] > b2[0])
            return 1;
        else 
            if (b1[1] < b2[1])
                return -1;
            else if (b1[1] > b2[1])
                return 1;
            else 
                return 0;
    }
}
