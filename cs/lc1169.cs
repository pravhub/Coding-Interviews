/*
create a place holder class with 4 fields
create array of "place holder" class
fill the array by splitting each transaction.
create a new IComparer for "place holder" class.
sort array by using the new Icomparer class.
  -use time
go thru the array and apply the logic detection of 
  - $1000
  - within 60 mins for same name in another city.

[,,"alex,355,1029,barcelona","alex,387,885,bangkok","alex,587,402,bangkok",,"alex,932,86,bangkok",]
"bob,627,1973,amsterdam","bob,188,989,amsterdam"
"chalicefy,973,830,barcelona"
*/
public class Solution {
    public IList<string> InvalidTransactions(string[] transactions) {
        int n = transactions.Length;
        HashSet<string> ans = new HashSet<string>();
        Trans[] tr = new Trans[n];
        bool []addtoanswer = new bool[n];
        Dictionary<string,Trans> map = new Dictionary<string,Trans>();
        int i=0;
        foreach(string t in transactions)
        {
            string[] details = t.Split(',');
            string name = details[0];
            int time = int.Parse(details[1]);
            int amount = int.Parse(details[2]);
            string city = details[3];
            tr[i++]= new Trans(name, time, amount, city);
        }
        //(onlog(n));
        Array.Sort(tr,new TransSort());

        //O(n) to o(n^2)
        for(int j=0;j<n;j++)
        {
            if(tr[j].amount>1000)
            {
                ans.Add(tr[j].ToString());
            }
            //else
            {
                for(int k=j+1;k<n;k++)
                {
                    if(tr[j].name!=tr[k].name)
                    {
                        break;
                    }
                    else if(tr[k].time-tr[j].time <= 60 && tr[k].city!= tr[j].city)
                    {
                        ans.Add(tr[j].ToString());
                        ans.Add(tr[k].ToString());
                    }
                }
            }
        }
        
        return ans.ToList();
    }
}
public class TransSort : IComparer<Trans>
{
   public int Compare(Trans a, Trans b)
   {
       if(a.name == b.name)
       {
         return a.time.CompareTo(b.time);
       }
       else
       {
        return a.name.CompareTo(b.name);
       }
   }
}
public class Trans
{
    public string name;
    public int time;
    public int amount;
    public string city;
    public Trans(string n, int t, int a,string c)
    {
        name = n;
        time = t;
        amount = a;
        city = c;
    }
    public override string ToString()
    {
        return string.Format("{0},{1},{2},{3}",name, time, amount, city);
    }
}
