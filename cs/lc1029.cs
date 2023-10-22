public class Solution {
    public int TwoCitySchedCost(int[][] costs) {
        int n = costs.Length;
        CityCost[] cc = new CityCost[n];
        for(int i=0;i<n;i++)
        {
            cc[i] = new CityCost(costs[i][0],costs[i][1]);
        }        
        Array.Sort(cc, new CityCostComparer());
        /*for(int i=0;i<n;i++)
        {
            Console.WriteLine("{0}.{1}",cc[i].a,cc[i].b);
        }*/
        int a = n/2;
        int b = n/2;
        int cost = 0;
        for(int i=0;i<n;i++)
        {
            if(a>0)
            {
               cost += cc[i].a;
                a--;
            }
            else
            {
               cost += cc[i].b;
                b--;
            }            
        }        
        return cost;
    }    
}
public class CityCostComparer : IComparer<CityCost>
{
    public int Compare(CityCost x, CityCost y)
    {        
        int diffx = x.a - x.b;
        int diffy = y.a - y.b;
        return diffx.CompareTo(diffy);
    }
}
public class CityCost 
{
    public int a;
    public int b;
    public CityCost(int x, int y)
    {
        a = x;
        b = y;
    }
    
}
