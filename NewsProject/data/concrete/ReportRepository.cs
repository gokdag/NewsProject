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

        public IEnumerable<Report> GetTopReports(int count)
        {
            return _context.Reports.Take(count);
        }
    }
}
