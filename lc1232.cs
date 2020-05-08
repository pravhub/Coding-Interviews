public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        
        if(coordinates.Length <=2)
            return true;
        else
        {
            bool yLine = (coordinates[1][0] -  coordinates[0][0])==0?true:false; //invalid slope check. x2-x1
            if(yLine) //case2
            {
                for(int i=2;i<coordinates.Length;i++)
                {
                    if(0!=(coordinates[i][0] -  coordinates[i-1][0]))
                        return false;
                }
            }
            else
            {
                double slope = CalculateSlope(coordinates[0][0], coordinates[0][1], coordinates[1][0], coordinates[1][1]);
                //Console.WriteLine(slope);
                for(int i=2;i<coordinates.Length;i++)
                {
                    if(0== (coordinates[i][0] -  coordinates[i-1][0]))
                        return false;
                    double m = CalculateSlope(coordinates[i-1][0], coordinates[i-1][1], coordinates[i][0], coordinates[i][1]);
                    //Console.WriteLine(m);
                    if(m != slope)
                        return false;
                }
            }
            return true;
        }
    }
    public double CalculateSlope(int x1, int y1, int x2, int y2)
    {
        double slope = (double)(y2 -  y1)/(x2 - x1);
        return slope;
    }
}
