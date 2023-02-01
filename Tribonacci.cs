public class Solution {
    public int Tribonacci(int n) {
        List <int> TribonacciSeries = new List <int>();
        TribonacciSeries.Add(0);
        TribonacciSeries.Add(1);
        TribonacciSeries.Add(1);
        for(int i=3;i<=n;i++){
            TribonacciSeries.Add(TribonacciSeries[i-3]+TribonacciSeries[i-2]+TribonacciSeries[i-1]);
        }
        return TribonacciSeries[n];
    }
}
