namespace AssignmentApp3.Repositories;
using AssignmentApp3.DataModel;



public class CourseRepository : IRepository<Course>
{ 

    List<Course> Courses = new List<Course>();
    
    public int Insert(Course obj)
    {
        if (GetById(obj.Id) == null)
        {
            Courses.Add(obj);
            return 1;
        }

        return 0;
    }

    public int Update(Course obj)
    {
        Course c = GetById(obj.Id);
        if (c != null)
        {
            c.Id = obj.Id;
            c.Name = obj.Name;
            c.enrollment = obj.enrollment;
            return 1;
        }

        return 0;
    }

    public int Delete(int id)
    {
        Course c = GetById(id);
        if (c != null)
        {
            Courses.Remove(c);
            return 1;
        }

        return 0;
    }

    public List<Course> GetAll()
    {
        return Courses;
    }

    public Course GetById(int id)
    {
        for (int i = 0; i < Courses.Count; i++)
        {
            if (Courses[i].Id == id)
            {
                return Courses[i];
            }
        }

        return null;
    }
}