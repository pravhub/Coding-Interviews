/*
https://leetcode.com/problems/number-of-burgers-with-no-waste-of-ingredients/
https://leetcode.com/contest/weekly-contest-165/problems/number-of-burgers-with-no-waste-of-ingredients/
*/
public class Solution {
    public IList<int> NumOfBurgers(int tomatoSlices, int cheeseSlices) {
        
        /*
        solve the equations first. Z-- tomatoSlices, W- cheeseSlices
        assume there will be x jumbo burgers and y small burges, here is the forumula.
        4x + 2y = Z;
        x + y = W;
        by solving algebra you can get x = (Z-2W)/2 and y = (4W-Z)/2
        one verification that we need to do is make sure (Z-2W) and (4W-Z) are >=0 
        following code just uses this formula and returns the output.
        */
        
        if((tomatoSlices - 2*cheeseSlices)>=0 && (4*cheeseSlices - tomatoSlices)>=0 &&
           (tomatoSlices - 2*cheeseSlices)%2==0 &&  (4*cheeseSlices - tomatoSlices)%2 ==0)
        {
            int jumbo = (tomatoSlices - 2*cheeseSlices)/2;
            int small = (4*cheeseSlices - tomatoSlices)/2;
            return new List<int>{jumbo,small};
        }
        else
        {
            return new List<int>();
        }
    }
}
