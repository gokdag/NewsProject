using Microsoft.EntityFrameworkCore;
using NewsProject.data.Abstract;
using NewsProject.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.data.concrete
{
     public class Repository<Tentity> : IRepository<Tentity> where Tentity : class
    {
        private readonly DatabaseContext _context;
        private DbSet<Tentity> _dbSet;
        
            public Repository(DatabaseContext context)
        {
            _context = context;
            _dbSet = _context.Set<Tentity>();
        }
        public IEnumerable<Tentity> GetAll()
        {
            //return _dbSet.ToList();
            return _dbSet.ToList();
        }
       
        public Tentity GetById(int id)
        {
            return _dbSet.Find(id);
        }
    }
}
