
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var output = new int [2];
        for(int i=0;i<nums.Length;i++){ //i loop for first pointer
            for(int j=i+1;j<nums.Length;j++){ //j loop for second pointer 
                if(nums[i]+nums[j]==target){
                    output[0]=i;
                    output[1]=j;;
                    
                }
            }
        }
        return output;
    }
}
