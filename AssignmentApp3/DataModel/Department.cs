namespace AssignmentApp3.DataModel;


public class Department{
    public int Id{get;set;}
    public string Name{get;set;}
    public Instructor Head{get;set;}

    public DateTime BudgetStartTime{get;set;}

    public DateTime BudgetEndTime{get;set;}

}