namespace AssignmentApp3.Repositories;
using AssignmentApp3.DataModel;



public class StudentRepository : IRepository<Student>
{ 

    List<Student> Students = new List<Student>();
    
    public int Insert(Student obj)
    {
        if (GetById(obj.Id) == null)
        {
            Students.Add(obj);
            return 1;
        }

        return 0;
    }

    public int Update(Student obj)
    {
        Student c = GetById(obj.Id);
        if (c != null)
        {
            c.Id = obj.Id;
            c.Name = obj.Name;
            c.Address=obj.Address;
            c.Age=obj.Age;
            c.Courses = obj.Courses;
            c.Grades = obj.Grades;
            return 1;
        }

        return 0;
    }

    public int Delete(int id)
    {
        Student c = GetById(id);
        if (c != null)
        {
            Students.Remove(c);
            return 1;
        }

        return 0;
    }

    public List<Student> GetAll()
    {
        return Students;
    }

    public Student GetById(int id)
    {
        for (int i = 0; i < Students.Count; i++)
        {
            if (Students[i].Id == id)
            {
                return Students[i];
            }
        }

        return null;
    }
}