namespace AssignmentApp3;
public class Question2{
    public int Fibonacci(int num){
        int prev1=1;
        int prev2=1;
        
        for(int i=2;i<num;i++){
            int temp=prev1+prev2;
            prev1=prev2;
            prev2=temp;
        }
        return prev2;
    }
    public void Main(string[] args){
        Console.WriteLine(Fibonacci(8));
    }
}