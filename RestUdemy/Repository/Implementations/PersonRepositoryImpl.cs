﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestUdemy.Models;
using RestUdemy.Models.Context;

namespace RestUdemy.Repository.Implementations
{
    public class PersonRepositoryImpl : IPersonRepository
    {
        private readonly RestUdemyContext _context;

        public PersonRepositoryImpl(RestUdemyContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }

        public Person FindById(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        public List<Person> FindAll() => _context.Persons.ToList();

        public Person Update(Person person)
        {
            if (!Exists(person.Id)) return new Person();

            var result = _context.Persons.SingleOrDefault(b => b.Id == person.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return result;
        }

        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            try
            {
                if (result != null)
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Exists(int? id) => _context.Persons.Any(p => p.Id.Equals(id));
    }
}
