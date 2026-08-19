namespace Week04_MVC_Pattern.Data;

public class InMemoryRepository<T> : IRepository<T>
{
    private readonly List<T> _items = new();

    private readonly Func<T, int> _idSelector;

    public InMemoryRepository(Func<T, int> idSelector)
    {
        _idSelector = idSelector;
    }

    public T Add(T entity)
    {
        _items.Add(entity);
        return entity;
    }

    public IEnumerable<T> GetAll()
    {
        return _items;
    }

    public T? GetById(int id)
    {
        return _items.FirstOrDefault(
            item => _idSelector(item) == id);
    }

    public bool Update(T entity)
    {
        var id = _idSelector(entity);

        var index = _items.FindIndex(
            item => _idSelector(item) == id);

        if (index == -1)
        {
            return false;
        }

        _items[index] = entity;

        return true;
    }

    public bool Delete(int id)
    {
        var entity = GetById(id);

        if (entity is null)
        {
            return false;
        }

        return _items.Remove(entity);
    }
}