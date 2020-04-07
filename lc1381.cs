public class CustomStack {

    int sz;
    int top;
    int[] s;
    public CustomStack(int maxSize) {
        sz = maxSize;
        s = new int[maxSize];
        top = -1;
    }
    
    public void Push(int x) {
        if(top<sz-1)
        {
            top++;
            s[top]=x;
        }
    }
    
    public int Pop() {
        if(top <=-1)
            return -1;
        int temp = top;
        top--;
        return s[temp];
    }
    
    public void Increment(int k, int val) {
        int min = Math.Min(k-1, top);
        for(int i=0;i<=min;i++)
        {
            s[i] = s[i]+val;
        }
    }
}
