// 1. What type would you choose for the following “numbers”?
// A person’s telephone number
// string
// A person’s height
// short
// A person’s age
// short
// A person’s gender (Male, Female, Prefer Not To Answer)
// string
// A person’s salary
// decimal
// A book’s ISBN
// string
// A book’s price
// decimal
// A book’s shipping weight
// double
// A country’s population
// long
// The number of stars in the universe
// ulong
// The number of employees in each of the small or medium businesses in the
// United Kingdom (up to about 50,000 employees per business)
// int
//__________________________
//2. 
//Differences between Value types and Reference type
// 1). Value type will directly hold the value, while reference type will hold the memory address for this value.
// 2). Value types are stored in the stack memory, the heap types are stored in the heap memory
// 3). Value type will not be collected by garbage collector but reference will be collected by garbage collector
// 4). Value type can be created by struct or enum while reference type can be created by class, interface, delegate or array
// 5). Values type can not accept any null valuews while reference type can accept null value, otherwise you need to put such like 'int?'
//————————————————————————————————————
//3.
// boxing and unboxing
// boxing is to convert value types to object type, unboxing is to convert back object type to specific value types, example in following:

int num = 123;
object obj = num;
int numAgain = (int)obj;
//____________________________________
//4.
//Mangaged Resource and unmanaged resource
// Two parts in heap memory:
// 1. Managed Heap: cleaned up by garbage collector
// 2. Unmanaged heap: call Dispose() from Idisposable interface
//_______________________________________
//5.
// CG is to automatically manage memory, it automatically handle the allocations and release memory for our objects.
// CLR allocated heap memory for our created objects, as long as the object exists, the memory remain allocated.
// There are three generations, 0 means short-lived collection , 2 is long-lived collection, and 1 is the buffer between those. It helps GC to frenquently check specific objects instead of checking those all.


//Play with Console

Console.WriteLine("I can create a hacker name for you, before that let me ask you few question.");
Console.WriteLine("What is your favorite color?");
string color = Console.ReadLine();
Console.WriteLine("What is your strology sign?");
string strology_sign = Console.ReadLine();
Console.WriteLine("What is your street address number?");
string s_num = Console.ReadLine();
Console.WriteLine("Your hacker name is "+color+strology_sign+s_num);

//Practice number sizes and ranges

Console.WriteLine($"sbyte:\n\tBytes: {sizeof(sbyte)}\n\tMin: {sbyte.MinValue}\n\tMax: {sbyte.MaxValue}\n");
Console.WriteLine($"byte:\n\tBytes: {sizeof(byte)}\n\tMin: {byte.MinValue}\n\tMax: {byte.MaxValue}\n");
Console.WriteLine($"short:\n\tBytes: {sizeof(short)}\n\tMin: {short.MinValue}\n\tMax: {short.MaxValue}\n");
Console.WriteLine($"ushort:\n\tBytes: {sizeof(ushort)}\n\tMin: {ushort.MinValue}\n\tMax: {ushort.MaxValue}\n");
Console.WriteLine($"int:\n\tBytes: {sizeof(int)}\n\tMin: {int.MinValue}\n\tMax: {int.MaxValue}\n");
Console.WriteLine($"uint:\n\tBytes: {sizeof(uint)}\n\tMin: {uint.MinValue}\n\tMax: {uint.MaxValue}\n");
Console.WriteLine($"long:\n\tBytes: {sizeof(long)}\n\tMin: {long.MinValue}\n\tMax: {long.MaxValue}\n");
Console.WriteLine($"ulong:\n\tBytes: {sizeof(ulong)}\n\tMin: {ulong.MinValue}\n\tMax: {ulong.MaxValue}\n");
Console.WriteLine($"decimal:\n\tBytes: {sizeof(decimal)}\n\tMin: {decimal.MinValue}\n\tMax: {decimal.MaxValue}\n");
Console.WriteLine($"float:\n\tBytes: {sizeof(float)}\n\tMin: {float.MinValue}\n\tMax: {float.MaxValue}\n");
Console.WriteLine($"double:\n\tBytes: {sizeof(double)}\n\tMin: {double.MinValue}\n\tMax: {double.MaxValue}\n");

//2

void CenturyConvertor(int a){
    short year = (short)(100*a);
    int day = (int)(365.2425* year);
    int hour = 24* day;
    long minute = (60*hour);
    long second =  (long)(60*minute);
    ulong millisecond =(ulong)(1000*second);
    ulong microsecond =(1000*millisecond);
    ulong nanosecond = (1000*microsecond);
    Console.WriteLine($"{a} centuries = {year} years = {day} days = {hour} hours = {minute} minutes= {second} seconds = {millisecond} milliseconds = {microsecond} microseconds = {nanosecond} nanoseconds");
}
CenturyConvertor(1);
CenturyConvertor(5);
//1.
// An Error will pop out, Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.

//2.
// Interesting thing is, it will not throw an error, instead a infinity sign will be printed.

//3.
// it will go to back of the head, like 0-255, if we assign a 256 to it, it will go back to 0.

//4.
// former one will assign x to y, and then y increment 1, later one will be y increment one first, and then assign it to x.

//5.
// break is to terminate loop and continue rest of the statement in method/class, continue is to skip current looping process and directly start next looping, return is to finish and wraping up not just looping, but for a whole method.

//6.
// Initilization: where to start the for loop, condition: where to stop the for loop, iteration Experssion: how to get to the stop condition from initilizatied variable.

//7.
// = is to assign value to variable, == is to compare value between two variable.

//8.
//Yes, but it will be a dead loop, becuase we don't have iteration Expersion and initilization to terminate the looping.
//9. 
// _ means default, it usually will be at the end of switch statment, when there are no condition fit to the statment, _ option will be its value.

//10.
//IEnumerable is the interface, foreach loop calls the GetEnumerator method to get an enumerator, and then it repeatedly calls MoveNext and accesses the Current property.

//Practice loops and operators
//1.
//1)


void FizzBuzzGame(){
    for(int i=1;i<=100;i++){
        if(i%3==0&&i%5!=0) Console.WriteLine("Fizz");
        else if(i%3!=0&&i%5==0) Console.WriteLine("Buzz");
        else if(i%3!=0&&i%5!=0) Console.WriteLine(i);
        else{
            Console.WriteLine("FizzBuzz!");
        }
    }
}
FizzBuzzGame();

//2)

void PrintPyramid(int rows)
{
    for (int row = 0; row < rows; row++)
    {
        string stars = new string('*', row * 2 + 1);
        string spaces = new string(' ', rows - row - 1);

        Console.WriteLine(spaces + stars + spaces);
    }
}

PrintPyramid(5);

// 3)
void GuessNumber(){
    int correctNumber = new Random().Next(3) + 1;
    Console.WriteLine("Guessing Game! Guess the number, 1,2 or 3?");
    string userInput = Console.ReadLine();
    if(userInput.Length==0){
        Console.WriteLine("Empty input, please enter number");
        return;
    }
    if(int.TryParse(userInput, out int userType)){
        int guessedNumber = int.Parse(userInput);
        if (guessedNumber != 1 && guessedNumber != 2 && guessedNumber != 3)
        {
            Console.WriteLine("Wrong input, the answer will be in 1 to 3");
            return;
        }
        else if (guessedNumber < correctNumber){
            Console.WriteLine("Too Low!");
            return;
        }else if (guessedNumber > correctNumber){
            Console.WriteLine("Too High!");
            return;
        }else if (guessedNumber == correctNumber){
            Console.WriteLine("Bingo!");
            return;
        }
    }else{
        Console.WriteLine("Please enter valid Integer between 1 to 3");
        return;
    }
        
}
GuessNumber();

//4)
void BirthDateCalculator(){
    Console.WriteLine("What is your birthdate year:  ");
    String year = Console.ReadLine();
    Console.WriteLine("What is your birthdate month: 1-12");
    String month = Console.ReadLine();
    Console.WriteLine("What is your birthdate days: 1-31");
    String day = Console.ReadLine();
    DateTime birthDate = new DateTime(int.Parse(year),int.Parse(month),int.Parse(day));
    DateTime currentDate = DateTime.Now;
    TimeSpan age = currentDate- birthDate;
    int daysOld = age.Days;
    Console.WriteLine($"You are {daysOld} days old.");

    // Calculate days to next 10,000 day anniversary
    int daysToNextAnniversary = 10000 - (daysOld % 10000);
    Console.WriteLine($"Days to next 10,000 day anniversary: {daysToNextAnniversary}");

}
BirthDateCalculator();

//5
void Greeting(){
    DateTime currentTime = DateTime.Now;
    int hour = currentTime.Hour;

    string greeting = "";
    if(hour>=5&&hour<12){
        greeting = "Good Morning!";
    }
    if(hour>=12&&hour<17){
        greeting = "Good Afternoon!";
    }
    if(hour>=17&&hour<21){
        greeting = "Good Evening!";
    }
    if(hour>=21&&hour<5){
        greeting = "Good Night!";
    }
    Console.WriteLine(greeting);
}
Greeting();
//6
void CountNumber(){
    for(int i=1;i<=4;i++){
        for(int j=0;j<=24;j+=i){
            Console.Write(j+" ");
        }
        Console.Write("\n");
    }
}
CountNumber();