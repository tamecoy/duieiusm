using System.Collections.Generic;

// A generic interface for a repository
public interface IRepository<T>
{
    // A method to add an item to the repository
    void Add(T item);

    // A method to remove an item from the repository
    void Remove(T item);

    // A method to remove all items from the repository
    void RemoveAll();

    // A method to get all items from the repository
    IEnumerable<T> GetAll();
}

// A concrete implementation of a repository using a list
public class ListRepository<T> : IRepository<T>
{
    // A private field to store the items
    private List<T> items;

    // A constructor that initializes the list
    public ListRepository()
    {
        items = new List<T>();
    }

    // A method to add an item to the repository
    public void Add(T item)
    {
        items.Add(item);
    }

    // A method to remove an item from the repository
    public void Remove(T item)
    {
        items.Remove(item);
    }

    // A method to remove all items from the repository
    public void RemoveAll()
    {
        items.Clear();
    }

    // A method to get all items from the repository
    public IEnumerable<T> GetAll()
    {
        return items;
    }
}
