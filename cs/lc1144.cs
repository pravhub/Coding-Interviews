public class Solution {
    public int MovesToMakeZigzag(int[] A) {
        int n = A.Length;
        int even = 0;
        int odd = 0;        
        int first = -1;
        int second = -1;
        for(int i=0;i<n;i++)
        {
            if(i+1<n)
            {   
                if(first==-1 && second ==-1)
                {
                    first = A[i];
                    second = A[i+1];
                }
                else
                {
                    second = A[i+1];
                }
                if(i%2==0)
                {
                    if(first<=second)
                    {
                        int diff = second-first;
                        even += diff+1;
                        second = second - (diff+1);
                    }
                }
                else
                {
                    if(first>=second)
                    {
                        int diff = first-second;
                        even += diff+1;
                        first = first - (diff+1);
                    }
                } 
            }
            first = second;
        }
        //Console.WriteLine(string.Join(" ",A));
        //odd
        first = -1;
        second = -1;
        for(int i=0;i<n;i++)
        {
            if(i+1<n)
            {
                if(first==-1 && second ==-1)
                {
                    first = A[i];
                    second = A[i+1];
                }
                else
                {
                    second = A[i+1];
                }
                if(i%2==0)
                {
                    if(first>=second)
                    {
                        int diff = first-second;
                        odd += diff+1;
                        first = first - (diff+1);
                    }                    
                }
                else
                {
                    if(first<=second)
                    {
                        int diff = second-first;
                        odd += diff+1;
                        second = second - (diff+1);
                    }
                }
            }
            first = second;
        }
        //Console.WriteLine(string.Join(" ",B));
        return Math.Min(even,odd);
    }
    public int MovesToMakeZigzag_n_space(int[] A) {
        int n = A.Length;
        int even = 0;
        int odd = 0;
        int[] B = new int[n];
        for(int i=0;i<n;i++)
        {
            B[i] = A[i];
        }
        for(int i=0;i<n;i++)
        {
            if(i+1<n)
            {
                if(i%2==0)
                {
                    if(A[i]<=A[i+1])
                    {
                        int diff = A[i+1]-A[i];
                        even += diff+1;
                        A[i+1] = A[i+1] - (diff+1);
                    }
                }
                else
                {
                    if(A[i]>=A[i+1])
                    {
                        int diff = A[i]-A[i+1];
                        even += diff+1;
                        A[i] = A[i] - (diff+1);
                    }
                }
            }
        }
        //Console.WriteLine(string.Join(" ",A));
        //odd
        for(int i=0;i<n;i++)
        {
            if(i+1<n)
            {
                if(i%2==0)
                {
                    if(B[i]>=B[i+1])
                    {
                        int diff = B[i]-B[i+1];
                        odd += diff+1;
                        B[i] = B[i] - (diff+1);
                    }                    
                }
                else
                {
                    if(B[i]<=B[i+1])
                    {
                        int diff = B[i+1]-B[i];
                        odd += diff+1;
                        B[i+1] = B[i+1] - (diff+1);
                    }
                }
            }
        }
        //Console.WriteLine(string.Join(" ",B));
        return Math.Min(even,odd);
    }
}
