using RestUdemy.Models;
using System.Collections.Generic;

namespace RestUdemy.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
        bool Exists(int? id);
    }
}
