public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> answer = new List<string>();
        
        for(int i=1;i<=n;i++){
        if(i%3==0 && i%5==0){
            answer.Add("FizzBuzz");
        }
        if(i%3==0 && i%5!=0){
            answer.Add("Fizz");
        }
        if(i%3!=0 && i%5==0){
            answer.Add("Buzz");
        }
        if(i%3!=0 && i%5!=0){
            answer.Add(i.ToString());
        }
        }
        return answer;
    }
}
