public class Solution {
    public bool CheckOverlap(int radius, int x_center, int y_center, int x1, int y1, int x2, int y2) {
        
        ///check partial overlap for all 4 corners of rectangle.
        //if any of them overalp then return true;
        if(CheckPartialOverlap( radius,  x_center,  y_center,  x1,  y1) ||
           CheckPartialOverlap( radius,  x_center,  y_center,  x1,  y2) ||
           CheckPartialOverlap( radius,  x_center,  y_center,  x2,  y1) ||
           CheckPartialOverlap( radius,  x_center,  y_center,  x2,  y2))
        {
            return true;
        }
        
        int left_x1 = x1-radius;
        int right_x2 = x2+radius;
        int below_y1 = y1-radius;
        int above_y2 = y2+radius;
        
        if(x_center>=x1 && x_center <=x2 && y_center>=below_y1 && y_center<=above_y2)
        {
            return true;
        }
        
        if(y_center>=y1 && y_center <=y2 && x_center>=left_x1 && x_center<=right_x2)
        {
            return true;
        }
        
        return false;
    }
    public bool CheckPartialOverlap(int radius, int x_center, int y_center, int x1, int y1)
    {
        double x_dist = Math.Pow(x_center-x1,2);
        double y_dist = Math.Pow(y_center-y1,2);
        
        if(x_dist + y_dist > Math.Pow(radius,2))
            return false;
        else
            return true;
    }
}
