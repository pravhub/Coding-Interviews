public class Solution {
    public bool IsPerfectSquare(int num) {
        if(num<=0)
            return false;
        if(num==1)
            return true;
        int start = 1;
        int end = num;
        while(start<=end)
        {
            long mid = (start + (long)end)/2;            
            long product = mid*mid;
            //Console.WriteLine("s={0}, e={1}, m= {2}, prod={3}",start,end,mid,product);                
            if(product == num)
                return true;
            else if(product > num)
                end = (int) (mid-1);
            else
                start = (int)(mid+1);
        }
        return false;
    }
}
