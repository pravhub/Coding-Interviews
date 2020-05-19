public class StockSpanner {

    List<int> prices;
    int idx = -1;
    Stack<Span> s;
    public StockSpanner() {
        //prices = new List<int>();
        s = new Stack<Span>();
    }
    
    public int Next(int price) {
         //implementation without Stack.
        /*prices.Add(price);
        idx++;        
        return GetSpan(price); */
        // implementation with stack 
        return GetSpanWithStack(price);
    }
    
    
    ///time = O(n) 
    //space = O(n) - n is days and foreach day we get 1 stock price.
    private int GetSpanWithStack(int pr)
    {
        int spanDays = 1;
        if(s.Count==0)
        {
            s.Push(new Span(pr,spanDays));            
        }
        else
        {
            while(s.Count>0 && s.Peek().val <= pr)
            {
               spanDays += s.Pop().days;
            }
            s.Push(new Span(pr,spanDays));
        }
        return spanDays;
    }
    //time = 1+2+3+4+5+..n = O(n^2)
    //1,2,3,4,5,6,7,8
    //space = O(n) - n is days and foreach day we get 1 stock price.
    private int GetSpan(int pr)
    {
        int count = 0;
        int curIdx = idx;
        while(curIdx>=0 && prices[curIdx]<=pr)
        {
            count++;
            curIdx--;
        }
        return count;
    }
}
public class Span
{
    public int val;
    public int days;
    public Span(int v, int i)
    {
        val=v;
        days= i;
    }
}
