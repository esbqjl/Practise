//1.
// String is immutable in C%. If you want to modify a string, you better want to create it as string builder

//2.
// In C#, the base class for array is System.Array

//3. 
// You can use Array.Sort() to sort an Array

//4. 
// You can you Length to get the total number of elements in an array

//5.
// Yes, we can store multiple datatypes in an array, since all types are derived from System.object

//6.
// Former one is to copy elements from current array to another array, you need to initilize a new array first.
// clone will create a new array automatically and copies the entire array
//_______________________________________________________________________

//Practice Arrays
using System.Text;
using System.Text.RegularExpressions;
int [] source = new int[10];
for(int i=0;i<10;i++){
    source[i]=i;
}
int [] copycat = new int[10];
for(int i=0;i<source.Length;i++){
    copycat[i]= source[i];
}
for(int i=0;i<source.Length;i++){
    Console.WriteLine(source[i]+" "+copycat[i]);
}

void GroceryList(){
    bool todo = true;
    Dictionary<string,int> shopList = new Dictionary<string,int>();
    while(todo){
        Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
        String command = Console.ReadLine();
        if(command.Length<2) break;
        if(command.Substring(0,2).Equals("+ ")){
            string good = command.TrimStart('+',' ');
            if(shopList.ContainsKey(good)){
                shopList[good]++;
            }
            else{
                shopList[good]=1;
            }
        }else if(command.Substring(0,2).Equals("- ")){
            string good = command.TrimStart('-',' ');
            if(shopList.ContainsKey(good)){
                if(shopList[good]!=0){
                    shopList[good]--;
                }
            }
            else{
                continue;
            }
        }else if((command.Length==2)&&(command.Substring(0,2).Equals("--"))){
            shopList=new Dictionary<string, int>();
        }
        else{
            break;
        }
        List<KeyValuePair<string, int>> shopListPairs = shopList.ToList();
        for(int i=0;i<shopListPairs.Count;i++){
            Console.WriteLine($"Name: {shopListPairs[i].Key}, Quantity: {shopListPairs[i].Value}");
        }
    }
}
GroceryList();

//3
static int[] FindPrimesInRange(int startNum, int endNum)
{   
    Stack<int> primeStack = new Stack<int>();
    for(int i=startNum;i<endNum;i++){
        bool isPrime=true;
        for(int j=2;j<=i/2;j++ ){
            if(i%j==0){
                isPrime=false;
                break;
            }
        }
        if(isPrime){
                primeStack.Push(i);
            
        }
    }   
    return primeStack.ToArray();
}
int [] answer = FindPrimesInRange(1,52);
for(int i=0;i<answer.Length;i++){
    Console.Write(answer[i]+" ");
}
Console.WriteLine();
//4.

static int[] Rotation(int[] input, int time ){
    int n= input.Length;
    
    int [] sum = new int[n];
    for(int t=1;t<=time;t++){
        for(int i=0;i<n;i++){
            sum[(i+t)%n]+= input[i];
        }
    }
    return sum;
}
answer = Rotation([1,2,3,4,5],3);
for(int i=0;i<answer.Length;i++){
    Console.Write(answer[i]+" ");
}
Console.WriteLine();
// 5.
static int[] FindLongestSequence(int [] input){
    if(input.Length==0) return new int [0];

    
    int currentCount=1;
    int maxCount = currentCount;
    int current= input[0];
    int maxCurrent = current;
    for(int i=1;i<input.Length;i++){
        if (current==input[i]){
            currentCount++;
            if(maxCount<currentCount){
                maxCount=currentCount;
                maxCurrent=current;
            }
        }else{
            currentCount=1;
            current = input[i];
        }
        
    }
    int[] array = new int[maxCount];
    Array.Fill(array, maxCurrent);   
    return array;
}
answer = FindLongestSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]);
for(int i=0;i<answer.Length;i++){
    Console.Write(answer[i]+" ");
}


Console.WriteLine();
//7.
static int FindFrequentSequence(int [] input){
    Dictionary<int, int> frequency = new Dictionary<int, int>();
        int maxCount = 0;
        int? mostFrequentNumber = null;

        foreach (var number in input)
        {
            if (!frequency.ContainsKey(number))
            {
                frequency[number] = 0;
            }

            frequency[number]++;
            
            if (frequency[number] > maxCount)
            {
                maxCount = frequency[number];
                mostFrequentNumber = number;
            }
        }

        if (mostFrequentNumber.HasValue)
        {
            return mostFrequentNumber.Value;
        }
        else
        {
            return -1;
        }
}

Console.WriteLine(FindFrequentSequence([7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10]));


//Practice Strings
//1.
static string reverseStr(string str){
    StringBuilder strb = new StringBuilder(str);
    for(int i=0,j=str.Length-1;i<j;i++,j--){
        if(strb[i]!=strb[j]){
            strb[i]^=strb[j];
            strb[j]^=strb[i];
            strb[i]^=strb[j];
        }
        
    }
    return strb.ToString();
}
Console.WriteLine(reverseStr("sample"));


//2.
static string ReverseWords(string sentence)
{
    var wordsAndSeparators = Regex.Matches(sentence, @"[\w\+#]+|[\.\,\:\;\=\(\)\&\[\]""'\\/!\? ]")
                                    .Cast<Match>()
                                    .Select(m => m.Value)
                                    .ToArray();

    var words = wordsAndSeparators.Where(s => !Regex.IsMatch(s, @"[\.\,\:\;\=\(\)\&\[\]""'\\/!\? ]"))
                                    .ToArray();

    Array.Reverse(words);

    int wordIndex = 0;
    for (int i = 0; i < wordsAndSeparators.Length; i++)
    {
        if (!Regex.IsMatch(wordsAndSeparators[i], @"[\.\,\:\;\=\(\)\&\[\]""'\\/!\? ]"))
        {
            wordsAndSeparators[i] = words[wordIndex++];
        }
    }

    return string.Concat(wordsAndSeparators);
}

Console.WriteLine(ReverseWords("C# is not C++, and PHP is not Delphi!"));

//3.
static bool checkPalidromes(string str){
    StringBuilder strb = new StringBuilder(str);
    for(int i=0,j=strb.Length-1;i<j;i++,j--){
        
        if(!strb[i].Equals(strb[j])){
            return false;
        }
    }
    return true;
}
static string[] extractPalidromes(string str){
    var wordsAndSeparators = Regex.Matches(str, @"[\w\+#]+|[\.\,\:\;\=\(\)\&\[\]""'\\/!\? ]")
                                    .Cast<Match>()
                                    .Select(m => m.Value)
                                    .ToArray();

    var strArray = wordsAndSeparators.Where(s => !Regex.IsMatch(s, @"[\.\,\:\;\=\(\)\&\[\]""'\\/!\? ]"))
                                    .ToArray();
    HashSet<string> strSet = new HashSet<string>();
    for(int i=0;i<strArray.Length;i++){
        if(checkPalidromes(strArray[i])){
            strSet.Add(strArray[i]);
        }
    }
    strArray=strSet.ToArray();
    Array.Sort(strArray);
    return strArray;
} 
string[] strAnswer = extractPalidromes("Hi,exe? ABBA! Hog fully a string: ExE. Bob");
for(int i=0;i<strAnswer.Length;i++){
    Console.Write(strAnswer[i]+" ");
}

//4.
static void ParseUrl(string url)
{
    string protocol = "";
    string server = "";
    string resource = "";

    // Extracting the protocol (if exists)
    int protocolEnd = url.IndexOf("://");
    if (protocolEnd != -1)
    {
        protocol = url.Substring(0, protocolEnd);
        url = url.Substring(protocolEnd + 3);
    }

    // Extracting the server and resource
    int serverEnd = url.IndexOf("/");
    if (serverEnd != -1)
    {
        server = url.Substring(0, serverEnd);
        resource = url.Substring(serverEnd + 1);
    }
    else
    {
        server = url;
    }

    Console.WriteLine($"URL: {url}");
    Console.WriteLine($"[protocol] = \"{protocol}\"");
    Console.WriteLine($"[server] = \"{server}\"");
    Console.WriteLine($"[resource] = \"{resource}\"");
    Console.WriteLine();
}


ParseUrl("https://www.apple.com/iphone");
