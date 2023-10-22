public class Solution {
    public IList<IList<string>> DisplayTable(IList<IList<string>> orders) {
        IList<IList<string>> ans = new List<IList<string>>();
        SortedDictionary<int,SortedDictionary<string,int>> map = new SortedDictionary<int,SortedDictionary<string,int>>();
        HashSet<string> items = new HashSet<string>();
        foreach(var l in orders)
        {
            int table = int.Parse(l[1]);
            string item = l[2];
            items.Add(item);
            if(!map.ContainsKey(table))
            {
                map.Add(table, new SortedDictionary<string,int>());
            }
            if(!map[table].ContainsKey(item))
            {
                map[table].Add(item,0);
            }
            map[table][item]++;
        }
        var itemsList = items.ToList();
        itemsList.Sort(new CustomSort());
        itemsList.Insert(0,"Table");
        ans.Add(itemsList);
        foreach(var kvp in map)
        {
            List<string> curTable = new List<string>();
            curTable.Add(kvp.Key.ToString()); //table number.
            for(int i=1;i<itemsList.Count;i++)
            {
                if(kvp.Value.ContainsKey(itemsList[i]))
                {
                    curTable.Add(kvp.Value[itemsList[i]].ToString()); //quantity.
                }
                else
                {
                    curTable.Add("0"); //quantity
                }
            }
            ans.Add(curTable);
        }
        return ans;
    }
}
public class CustomSort: IComparer<string>
{
  public int Compare(string a, string b)
  {
       if(a[0]==b[0])
       {
          int i = 0;
          int j =0;
          while(i<a.Length && j <b.Length)
          {
             if(a[i]==b[j])
             {
               i++;
               j++;
             }
             else
             {
               break;
             }
          }
          if(i<a.Length && j<b.Length)
          {
             return ((int)a[i]).CompareTo((int)b[j]);
          }
          else if(i<a.Length && j>=b.Length)
          {
             return 1;
          }
          else if(i>=a.Length && j<b.Length)
          {
            return -1;
          }
          else
          {
            return 0;
          }
       }
       else
       {
          return ((int)a[0]).CompareTo((int)b[0]);
       }
  }
}
