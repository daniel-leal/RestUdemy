using RestUdemy.Models;
using RestUdemy.Models.Context;
using RestUdemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestUdemy.Services.Implementations
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private readonly IPersonRepository _repository;

        public PersonBusinessImpl(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Person person) => _repository.Create(person);
        public Person FindById(long id) => _repository.FindById(id);
        public List<Person> FindAll() => _repository.FindAll();
        public Person Update(Person person) => _repository.Update(person);
        public void Delete(long id) => _repository.Delete(id);
    }
}
