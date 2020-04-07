public class Cashier {
    int custNum;  
    int nth;
    int[] pro;
    int[] pri;
    int disc;
    Dictionary<int,int> pps = new Dictionary<int,int>();
    public Cashier(int n, int discount, int[] products, int[] prices) {
        custNum=0;
        nth = n;
        pro = products;
        disc = discount;
        for(int i=0;i<products.Length;i++)
        {
            pps.Add(products[i],prices[i]);
        }
    }
    
    public double GetBill(int[] product, int[] amount) {
        custNum++;
        double total=0.0;
        for(int i = 0;i<product.Length; i++)
        {
            total += pps[product[i]] * amount[i];
        }
        
        if(custNum == nth)
        {
            custNum = 0;
            total = total - (total * disc/100);
        }
        return total;
    }
}
