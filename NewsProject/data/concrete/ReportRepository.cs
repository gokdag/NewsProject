using Microsoft.EntityFrameworkCore;
using NewsProject.data.Abstract;
using NewsProject.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.data.concrete
{
    public class ReportRepository:Repository<Report>,IReportRepository
    {
        private readonly DatabaseContext _context;
        public ReportRepository(DatabaseContext context):base (context)
        {
            _context = context;
        }

        public Report GetFirstReport(Category id)
        {
            return _context.Reports.Find(id);
        }
        public IEnumerable<Report> GetAllWithCategory()
        {
            return _context.Reports.Include(x=>x.Category).ToList();
        }

        public IEnumerable<Report> GetTopReports()
        {
            return _context.Reports.Take(8).ToArray();
        }
        public IEnumerable<Report> GetUptoDateReport()
        {
            return _context.Reports.Where(x => x.DateTime >= DateTime.Today).ToList();
        }
        public Report GetReportWithId(int id)
        {
            //return _context.Reports.Include(x=>x.Category).Where(x=>x.Id==id);
            return _context.Reports.Include(x=>x.Category).Where(x=>x.Id==id).FirstOrDefault();

        }
        public Report IncreaseReadNumber(int id)
        {
            if (id != 0)
            { 
            _context.Reports.Where(x => x.Id == id).FirstOrDefault().ReadOfNumber += 1;
            
            }
            return _context.Reports.Where(x => x.Id == id).FirstOrDefault();
        }
        public IEnumerable<Report> ListWithCategoryId(int Id)
        {
            return _context.Reports.Where(x => x.CategoryId == Id).ToList();
        }

        public IEnumerable<Report> DeleteById(int Id)
        {
            var data = _context.Reports.Where(x=>x.Id==Id).FirstOrDefault();
            _context.Reports.Remove(data);
            return _context.Reports;
        }

        public DatabaseContext DataContext { get { return _context as DatabaseContext; } }

    }
}
