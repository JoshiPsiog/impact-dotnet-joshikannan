namespace Week04_MVC_Pattern.Data;

public interface IRepository<T>
{
    T Add(T entity);

    IEnumerable<T> GetAll();

    T? GetById(int id);

    bool Update(T entity);

    bool Delete(int id);
}