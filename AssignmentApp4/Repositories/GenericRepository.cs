namespace AssignmentApp4.Repositories;
using AssignmentApp4.DataModel;
public class InstructorRepository<T> : IRepository<T> where T : Entity
{   
    private List<T> Entities;
    public void Add(T item)
    {
        Entities.Add(item);
    }

    public IEnumerable<T> GetAll()
    {
        return Entities;
    }

    public T GetById(int id)
    {
        if (id>=0&&id<Entities.Count()-1){
            T temp = Entities[id];
            return temp;
        }
        return null;
    }

    public void Remove(T item)
    {
        Entities.Remove(item);
    }

    public void Save()
    {
        //sql logic
        // in-memory storage, this will do nothing
    }
}