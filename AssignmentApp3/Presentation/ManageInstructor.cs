using AssignmentApp3.DataModel;
using AssignmentApp3.Repositories;

namespace AssignmentApp3.Presentation;

public class ManageInstructor{
    private InstructorRepository _InstructorRepository = new InstructorRepository();

    public void AddInstructor(){
        Instructor c = new Instructor();
        Console.WriteLine("Enter Id=>");
        c.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter BaseSalary=>");
        c.Salary = (decimal)Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name=>");
        c.Name = Console.ReadLine();
        Console.WriteLine("Enter Age=>");
        c.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Address=>");
        c.Address = Console.ReadLine();
        Console.WriteLine("Enter Department=>");
        c.Department = Console.ReadLine();
        Console.WriteLine("Enter JoinDate=>");
        c.JoinDate = Convert.ToDateTime(Console.ReadLine());
        if(_InstructorRepository.Insert(c)==1){
            Console.WriteLine("Instructor has been added");
        }else{
            Console.WriteLine("Same error has occured");
        }

    }
    private void PrintAllInstructor(){
        List<Instructor> Instructors = _InstructorRepository.GetAll();
        foreach(var Instructor in Instructors){
            Console.WriteLine(Instructor.Id + "\t"+Instructor.Name+"\t"+Instructor.Address);
        }
    }

    private void DeleteInstructor(){
        Console.WriteLine("Enter Id ==>");
        int id = Convert.ToInt32(Console.ReadLine());
        if(_InstructorRepository.Delete(id)==1){
            Console.WriteLine("Instructor been deleted");
        }
        else{
            Console.WriteLine("fail to delete");
        }
    }
    public void Run(){
        Console.Clear();
        Console.WriteLine("Press 1 to add");
        Console.WriteLine("Press 2 to print all");
        Console.WriteLine("Press 3 to delete");
        Console.WriteLine("Press 9 to exit");
        Console.WriteLine("Enter Choice ==>");
        int choice = Convert.ToInt32(Console.ReadLine());
        while(choice!=9){
            switch(choice){
                case 1:
                    AddInstructor();
                    break;
                case 2:
                    PrintAllInstructor();
                    break;
                case 3:
                    DeleteInstructor();
                    break;
                default:
                    Console.WriteLine("Please Enter correct digit");
                    break;
            }
        }
    }
}
