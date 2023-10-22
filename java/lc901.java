class StockSpanner {

    List<Integer> prices;
    int idx = -1;
    Stack<Span> s;
    public StockSpanner() {
        //prices = new ArrayList<Integer>();
        s = new Stack<Span>();
    }
    
    public int next(int price) {
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
        if(s.size()==0)
        {
            s.push(new Span(pr,spanDays));            
        }
        else
        {
            while(s.size()>0 && s.peek().val <= pr)
            {
               spanDays += s.pop().days;
            }
            s.push(new Span(pr,spanDays));
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
        while(curIdx>=0 && prices.get(curIdx)<=pr)
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

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.next(price);
 */
