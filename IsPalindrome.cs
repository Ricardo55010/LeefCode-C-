public class Solution {
    public bool IsPalindrome(int x) {
        String xValue = x.ToString();
        for(int i=0;i<xValue.Length;i++){
            if(xValue[i]!=xValue[xValue.Length-1-i]){
                return false;
            }
        }
        return true;
    }
}
