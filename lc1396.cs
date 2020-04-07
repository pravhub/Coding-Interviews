public class UndergroundSystem {

    Dictionary<int,Passenger> pMap;
    Dictionary<string, Avgs> avgMap;
    public UndergroundSystem() {
        pMap = new Dictionary<int,Passenger>();
        avgMap = new Dictionary<string,Avgs>();
    }
    
    public void CheckIn(int id, string stationName, int t) {
        pMap.Add(id,new Passenger(stationName,t));
    }
    
    public void CheckOut(int id, string stationName, int t) {
        Passenger p = pMap[id];
        pMap.Remove(id);
        string fromTo = string.Format("{0}#{1}",p.city,stationName);
        if(!avgMap.ContainsKey(fromTo))
        {
            avgMap.Add(fromTo, new Avgs(0.0,0));
        }
        avgMap[fromTo].totalTime += t-p.time;
        avgMap[fromTo].totalCount++;
    }
    
    public double GetAverageTime(string startStation, string endStation) {
        string fromTo = string.Format("{0}#{1}",startStation,endStation);
        return avgMap[fromTo].totalTime/avgMap[fromTo].totalCount;
    }
}
public class Passenger
{
    public string city;
    public int time;
    public Passenger(string c, int t)
    {
        city = c;
        time = t;
    }
}
public class Avgs
{
    public double totalTime;
    public int totalCount;
    public Avgs(double t, int c)
    {
        totalTime = t;
        totalCount = c;
    }
}
/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem obj = new UndergroundSystem();
 * obj.CheckIn(id,stationName,t);
 * obj.CheckOut(id,stationName,t);
 * double param_3 = obj.GetAverageTime(startStation,endStation);
 */
