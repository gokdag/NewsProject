using NewsProject.data.Abstract;
using NewsProject.data.concrete;
using NewsProject.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext _context;

        public UnitOfWork(DatabaseContext context)
        {

            _context = context;
            ReportRepository = new ReportRepository (_context);
        }
        public IReportRepository ReportRepository { get; private set; }

        public int Complete()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
