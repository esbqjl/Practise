namespace AssignmentApp3.Repositories;
using AssignmentApp3.DataModel;



public class InstructorRepository : IRepository<Instructor>
{ 

    List<Instructor> Instructors = new List<Instructor>();
    
    public int Insert(Instructor obj)
    {
        if (GetById(obj.Id) == null)
        {
            Instructors.Add(obj);
            return 1;
        }

        return 0;
    }

    public int Update(Instructor obj)
    {
        Instructor c = GetById(obj.Id);
        if (c != null)
        {
            c.Id = obj.Id;
            c.Name = obj.Name;
            c.Address=obj.Address;
            c.Age=obj.Age;
            c.Salary=obj.Salary;
            c.JoinDate=obj.JoinDate;
            c.Department=obj.Department;
            return 1;
        }

        return 0;
    }

    public int Delete(int id)
    {
        Instructor c = GetById(id);
        if (c != null)
        {
            Instructors.Remove(c);
            return 1;
        }

        return 0;
    }

    public List<Instructor> GetAll()
    {
        return Instructors;
    }

    public Instructor GetById(int id)
    {
        for (int i = 0; i < Instructors.Count; i++)
        {
            if (Instructors[i].Id == id)
            {
                return Instructors[i];
            }
        }

        return null;
    }
}