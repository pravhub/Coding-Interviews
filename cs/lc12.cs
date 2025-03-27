public class Solution {
    public string IntToRoman(int num) {
        var ans = new StringBuilder();
        while(num > 0)
        {
            if (num >= 1000)
            {
                num -= 1000;
                ans.Append('M');
            }
            else if (num >= 900){
                num -= 900;
                ans.Append("CM");}
            else if (num >= 500){
                num -= 500;
                ans.Append("D");}
            else if (num >= 400){
                num -= 400;
                ans.Append("CD");}
            else if (num >= 100){
                num -= 100;
                ans.Append("C");}
            else if (num >= 90){
                num -= 90;
                ans.Append("XC");}
            else if (num >= 50){
                num -= 50;
                ans.Append("L");}
            else if (num >= 40){
                num -= 40;
                ans.Append("XL");}
            else if (num >= 10){
                num -= 10;
                ans.Append("X");}
            else if (num >= 9){
                num -= 9;
                ans.Append("IX");}
            else if (num >= 5){
                num -= 5;
                ans.Append("V");}
            else if (num >= 4){
                num -= 4;
                ans.Append("IV");}
            else if (num >= 1){
                num -= 1;
                ans.Append("I");}
        }
        return ans.ToString();             

    }
}
