namespace AssignmentApp3.Repositories;
using AssignmentApp3.DataModel;



public class DepartmentRepository : IRepository<Department>
{ 

    List<Department> Departments = new List<Department>();
    
    public int Insert(Department obj)
    {
        if (GetById(obj.Id) == null)
        {
            Departments.Add(obj);
            return 1;
        }

        return 0;
    }

    public int Update(Department obj)
    {
        Department c = GetById(obj.Id);
        if (c != null)
        {
            c.Id = obj.Id;
            c.Name = obj.Name;
            c.Head = obj.Head;
            c.BudgetEndTime = obj.BudgetEndTime;
            c.BudgetStartTime=obj.BudgetStartTime;
            return 1;
        }

        return 0;
    }

    public int Delete(int id)
    {
        Department c = GetById(id);
        if (c != null)
        {
            Departments.Remove(c);
            return 1;
        }

        return 0;
    }

    public List<Department> GetAll()
    {
        return Departments;
    }

    public Department GetById(int id)
    {
        for (int i = 0; i < Departments.Count; i++)
        {
            if (Departments[i].Id == id)
            {
                return Departments[i];
            }
        }

        return null;
    }
}