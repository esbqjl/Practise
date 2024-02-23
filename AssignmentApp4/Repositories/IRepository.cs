namespace AssignmentApp4.Repositories;
using AssignmentApp4.DataModel;
public interface IRepository<T> where T: class{
    void Add(T item);
    void Remove(T item);

    void Save();
    IEnumerable<T> GetAll();

    T GetById(int id);
}