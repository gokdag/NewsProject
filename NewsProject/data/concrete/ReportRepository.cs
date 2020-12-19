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
            return _context.Reports.Take(6).ToArray();
        }
        public IEnumerable<Report> GetUptoDateReport()
        {
            return _context.Reports.Where(x => x.DateTime >= DateTime.Today).OrderByDescending(x=>x.DateTime).ToList();
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

        public IEnumerable<Report> UpdateReport(Report model)
        {
            var data = _context.Reports.Find(model.Id);

            data.Title = model.Title;
            data.LongTitle = model.LongTitle;
            data.Content = model.Content;
            data.ReadOfNumber = model.ReadOfNumber;
            data.CategoryId = model.CategoryId;
            data.IsActive = model.IsActive;
            data.DateTime = DateTime.Now;
            data.SourceUrl = model.SourceUrl;
            data.IMageUrl = model.IMageUrl;
            

            _context.SaveChanges();



            return _context.Reports;
        }

        public IEnumerable<Report> CreateReport(Report model)
        {
            var data = new Report();

            data.Title = model.Title;
            data.LongTitle = model.LongTitle;
            data.Content = model.Content;
            data.ReadOfNumber = 1;
            data.IsActive = model.IsActive;
            data.IMageUrl = model.IMageUrl;
            data.CategoryId = model.CategoryId;
            data.DateTime = DateTime.Now;

            _context.Reports.Add(data);
            return _context.Reports;
        }

        public IEnumerable<Category> getAllCategory()
        {
           return _context.Categories.ToList();
        }

        public IEnumerable<Report> getTopRead()
        {
            int maxRead = _context.Reports.Max(x=>x.ReadOfNumber);
            return _context.Reports.OrderByDescending(x=>x.ReadOfNumber).Take(3).ToArray();
        }

        public DatabaseContext DataContext { get { return _context as DatabaseContext; } }

    }
}
