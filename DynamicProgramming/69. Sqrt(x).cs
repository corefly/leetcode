namespace DynamicProgramming;

public class SqrtSolution
{
    public int MySqrt(int x) {
        long start = 0;
        long end = x;
        
        while (start + 1 < end) {

            var mid = start + (end - start) / 2;
            if (mid * mid == x) {
                return (int)mid;
            } else if (mid * mid < x) {
                start = mid;
            } else {
                end = mid;
            }
        }
        
        if (end * end == x) {
            return (int)end;
        }
        return (int)start;
    }
}
