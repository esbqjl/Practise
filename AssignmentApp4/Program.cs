//1.
//type safe, code reusability, performance, extensibility

//2.
// List is a generic class, List<T>
List<string> strList = new List<string>();

//3.
// in Dictionary, it contains Tkey and Tvalue, Dictionary<Tkey,Tvalue> to store data.

//4. False

//5. Add()

//6. 
// Remove() and RemoveAt() can remove elements from List, former method remove the first encountered fit element, the second method will remove specific index element.

//7.
class MyClass<T>
{
    // Class implementation goes here
}
//8.
// False

//9.
// True

//10.
// True

//Practise Working with Generics
//1.
public class MyStack<T>{
    Stack<T> stack;
    public MyStack(){
        stack = new Stack<T>();
    }
    public int Count(){
        return stack.Count();
    }
    public T Pop(){
        return stack.Pop();
    }
    public void Push(T value){
        stack.Push(value);
    }
}
//2.
public class MyList<T>{
    List<T> list;
    public MyList(){
        list = new List<T>();
    }
    public void Add(T element){
        list.Add(element);
    }
    public T Remove(int index){
        T temp= Find(index);
        DeleteAt(index);
        return temp;
    }
    public bool Contains(T element){
        return list.Contains(element);
    }
    public void Clear(){
        list=new List<T>();
    }
    public void InsertAt(T element, int index){
        list.Insert(index,element);
    }
    public void DeleteAt(int index){
        Remove(index);
    }
    public T Find(int index){
            
        if (index>=0&&index<list.Count()-1){
            T temp = list[index];
            return temp;
        }
        throw new ArgumentOutOfRangeException(nameof(index),"The index out of range");
    }
}
