using DEPI.DAL.Database;
using DEPI.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI.DAL.Repository.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly DEPIContext _context;
        public readonly DbSet<T> _DbSet;
        public GenericRepository(DEPIContext context)
        {
            _context = context;
            _DbSet = _context.Set<T>(); //The set that I can access the entity type through _context
        }
        public IQueryable<T> GetAll()
        {
            return _DbSet.AsQueryable();
        }
        public T GetById(int Id)
        {
            return _DbSet.Find(Id);
        }
        public void Add(T entity)
        {
            _DbSet.Add(entity);
            _context.SaveChanges();
        }
        public void Delete(T entity)
        {
            _DbSet.Remove(entity);
            _context.SaveChanges();

        }
        public void Update(T entity)
        {
            _context.SaveChanges();
        }
    }
}
