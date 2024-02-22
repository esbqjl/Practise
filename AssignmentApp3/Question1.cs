namespace AssignmentApp3;
public class Question1{
    public void Reverse(int[] numbers){
        for(int i=0,j=numbers.Length-1;i<j;i++,j--){
            if(numbers[i]!=numbers[j]){
                numbers[i]^=numbers[j];
                numbers[j]^=numbers[i];
                numbers[i]^=numbers[j];
            }
        }
    }

    public void PrintNumbers(int[] numbers){
        for(int i=0;i<numbers.Length;i++){
            Console.Write(numbers[i]+" ");
        }
    }

    public int[] GenerateNumbers(){
        return new int[10]{1,2,3,4,5,6,7,8,9,10};
    }   
}