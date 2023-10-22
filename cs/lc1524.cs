public class Solution {
    public int NumOfSubarrays(int[] nums) {
        int n = nums.Length;     
        int even = 1;
        int odd = 0;
        int mod = 1000000007;
        int curSum = 0;
        int res =0;
        for(int i=0;i<n;i++)
        {            
            curSum +=nums[i];
            if(curSum%2==0)
            {
                res = res+odd;
                even++;
            }
            else
            {
                odd++;
                res = res+even;
            }
            res = res % mod;
        }
        return res;
    }
    public int NumOfSubarrays_TLE(int[] nums) {
        int n = nums.Length;        
        int count = nums[0]%2==1?1:0;
        int[] arr = new int[n];
        arr[0]= nums[0];
        int mod = 1000000007;
        for(int i=1;i<n;i++)
        {            
            if(nums[i]%2==1)
                count++;
            arr[i] = nums[i]+arr[i-1];
            if(arr[i]%2==1)
                count++;
        }
        count = count % mod;
        for(int i=1;i<n;i++)
        {
            for(int j=i+1;j<n;j++)
            {
                /*if(i==0)
                {
                    count+= arr[j]%2==1?1:0;
                }
                else*/
                {
                    count+=(arr[j]-arr[i] + nums[i])%2==1?1:0;
                }
                count = count % mod;
            }
        }
        return count;
    }
}
