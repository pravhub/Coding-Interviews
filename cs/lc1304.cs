/*
Given an integer n, return any array containing n unique integers such that they add up to 0.

 

Example 1:

Input: n = 5
Output: [-7,-1,1,3,4]
Explanation: These arrays also are accepted [-5,-1,1,2,3] , [-3,-1,2,-2,4].
Example 2:

Input: n = 3
Output: [-1,0,1]
Example 3:

Input: n = 1
Output: [0]
*/
public class Solution {
    public int[] SumZero(int n) {
        int[] ans = new int[n];
        int idx =0;
        if(n%2==1)
        {
            ans[idx++]=0;
        }
        int num = 1;
        for(int i=idx;i<n;i=i+2)
        {
            ans[i] = num;
            ans[i+1] = -num;
            num++;
        }
        return ans;            
    }
}
