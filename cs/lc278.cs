public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int start =1;
        int end = n;
        while(start<=end)
        {
            int mid = start+(end-start)/2;
            /*
            mid = (start+end)/2;
            start =1 
            end = int.Max
            (1+int.Max) ==> overflow of integer (-ve number)
            
            */
            bool v1 =  IsBadVersion(mid);
            if(v1)
            {
                end = mid-1;
            }
            else
            {
                start = mid+1;
            }
        }
        return start;
    }
}
