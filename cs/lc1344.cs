/*
 time = O(1)
 space = O(1)
*/
public class Solution {
    public double AngleClock(int hour, int minutes) {
        //total = 360 degrees
        //hour hand: moves 30 degrees for 1 hour (60 minutes) ==> for each minute 0.5 degrees.
        //minute hand: every minute it will move 6 degress. (360/60 min).
        //take base as 12 oclock. == 0th degree.
        if(hour == 12)
            hour = 0;
        double minuteDegrees = minutes * 6.0;
        double hourDegrees = hour * 30.0 + minutes * 0.5;
        double diff =  Math.Abs(minuteDegrees - hourDegrees);
        if(diff > 180)
            diff = 360 - diff;
        return diff;
    }
}
