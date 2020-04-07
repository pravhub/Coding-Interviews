public class Solution {
    public IList<int> FilterRestaurants(int[][] re, int veganFriendly, int maxPrice, int maxDistance) {
        int n = re.Length;
        List<Restaurant> rests = new List<Restaurant>();
        for(int i=0;i<n;i++)
        {
            Restaurant rest = new Restaurant(re[i][0],re[i][1],re[i][2],re[i][3],re[i][4]);
            rests.Add(rest);
        }
        if(veganFriendly==1)
        {
            return rests.Where(r=>r.veganFriendly == veganFriendly && r.price<=maxPrice && r.distance <= maxDistance).OrderBy(r=>r,new CompareRests()).Select(r=>r.id).ToList();
        }
        else
        {
            return rests.Where(r=> r.price<=maxPrice && r.distance <= maxDistance).OrderBy(r=>r,new CompareRests()).Select(r=>r.id).ToList();
        }
    }
}
public class CompareRests: IComparer<Restaurant>
{
 public int Compare(Restaurant a, Restaurant b)
 {
   if(a.rating!=b.rating)
   {
      return b.rating.CompareTo(a.rating);
   }
   else
   {
     return b.id.CompareTo(a.id);
   }
 }
}
public class Restaurant{
    public int id;
    public int rating;
    public int veganFriendly;
    public int price;
    public int distance;
    public Restaurant(int i,int r, int v, int p,int d)
    {
        id=i;
        rating = r;
        veganFriendly = v;
        price =p;
        distance = d;
    }
}
