using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CategoryService1
{
    public class IProductRepository
    {
        Add(new Product { Name = "1", Description = "2", Price = "3",  CategoryId = "4" });

        }

        public IEnumerable<Product> GetAll()
{
    return products;
}

public Product Get(int id)
{
    return products.Find(p => p.Id == id);
}

public Product Add(Product item)
{
    if (item == null)
    {
        throw new ArgumentNullException("item");
    }
    item.Id = _nextId++;
    products.Add(item);
    return item;
}

public void Remove(int id)
{
    products.RemoveAll(p => p.Id == id);
}

public bool Update(Product item)
{
    if (item == null)
    {
        throw new ArgumentNullException("item");
    }
    int index = products.FindIndex(p => p.Id == item.Id);
    if (index == -1)
    {
        return false;
    }
    products.RemoveAt(index);
    products.Add(item);
    return true;
}
}
