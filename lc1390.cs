/*
have a placeholder class to hold {number, power_value}
foreach number calculate power and store them in placholder array {number, power_value}
    have IComparer class with the required ascending order.
sort the placeholder array by using the IComparer class.
return the number from the placeholder array at (k-1)th index. c# array is 0 based.
*/
public class Solution {
    public int GetKth(int lo, int hi, int k) {
        Node[] nums = new Node[hi-lo+1];
        int idx =0;
        for(int i=lo;i<=hi;i++)
        {
            nums[idx++] = new Node(i, GetPowerValue(i));
        }
        Array.Sort(nums, new PowerCompare());
        /*for(int i=0;i<idx;i++)
        {
            Console.WriteLine("num={0}, pow={1}",nums[i].num,nums[i].pow);
        } */
        return nums[k-1].num;
    }
    private int GetPowerValue(int n)
    {
        int steps = 0;
        while(n!=1)
        {
            if(n%2 ==0)
            {
                n = n/2;
            }
            else
            {
                n = 3*n +1;
            }
            steps++;
        }
        return steps;
    }
}
public class PowerCompare : IComparer<Node>
{
    public int Compare(Node a, Node b)
    {
        if(a.pow == b.pow)
        {
           return a.num.CompareTo(b.num);
        }
        else
        {
            return a.pow.CompareTo(b.pow);
        }
    }
}
public class Node
{
    public int num;
    public int pow;
    public Node(int n, int p)
    {
        num = n;
        pow = p;
    }
}
