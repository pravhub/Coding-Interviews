public class Solution {
    public int[][] ReconstructQueue(int[][] people) {
        int n = people.Length;
        List<Person> l = new List<Person>();
        List<int[]> ans = new List<int[]>();
        
        for(int i=0;i<n;i++)
        {
            int h = people[i][0];
            int k = people[i][1];
            l.Add(new Person(h,k));
        }
        l.Sort();
        for(int i=0;i<n;i++)
        {
            //Console.WriteLine("{0}--{1}",l[i].height,l[i].pplBeforeMe);
            int h = l[i].height;
            int k = l[i].pplBeforeMe;
            if(k>=ans.Count)
            {
                ans.Add(new int[]{h,k}); //end of the list
            }
            else
            {
                ans.Insert(k, new int[]{h,k}); //
            }
        }
        return ans.ToArray();
    }
}
public class Person : IComparable
{
    public int height;
    public int pplBeforeMe;
    public Person(int h, int p)
    {
        height = h;
        pplBeforeMe = p;
    }
    int IComparable.CompareTo(object o)
    {
       Person that = (Person)o;
       if(this.height == that.height)
       {
          return this.pplBeforeMe.CompareTo(that.pplBeforeMe);
       }
       else
       {
        return that.height.CompareTo(this.height);
       }
    }
}
