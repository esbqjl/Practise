using System.Dynamic;
using AssignmentApp3.Repositories;

namespace AssignmentApp3.DataModel;

public abstract class Person{
    public int Id{get;set;}
    public string Name{get;set;}
    public int Age{get;set;}
    public decimal Salary{get;set;}
    public string Address{get;set;}
    //Virtual is to permit override
    public virtual void SalaryCalculation(){
    }
}
public class Instructor : Person{
    public string Department{get;set;}
    public DateTime JoinDate{get;set;}
    public override void SalaryCalculation(){
        Salary = (decimal)((DateTime.Now-JoinDate).Days*0.2)+Salary;
    }
}

public sealed class Student: Person{
    public string Courses{get;set;}
    public string[] Grades{get;set;}
    public double CalculateGpa(){
        double Gpa = 0;
        foreach(var grade in Grades){
            switch(grade){
                case "A":
                    Gpa+=4.0;
                    break;
                case "B":
                    Gpa+=3.0;
                    break;
                case "C":
                    Gpa+=2.0;
                    break;
                default:
                    Gpa+=1.0;
                    break;
            }
        }
        return Gpa/Grades.Length;
    }
}
public class HeadofDepartment:Instructor{
    public decimal ExtraBonus{get;set;}
    public void AttendMeeting(){
        Console.WriteLine("Head of Department has to attend meeting");
    }
    public override void SalaryCalculation(){
        Salary = (decimal)((DateTime.Now-JoinDate).Days*0.2)+Salary+ExtraBonus;
    }
}

