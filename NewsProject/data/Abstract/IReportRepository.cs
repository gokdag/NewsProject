using NewsProject.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.data.Abstract
{
    public interface IReportRepository :IRepository<Report>
    {
        public IEnumerable<Report> GetTopReports(int count);
        public Report GetFirstReport(Category id);
        public IEnumerable<Report> GetAllWithCategory();
        public IEnumerable<Report> GetUptoDateReport();
        public Report GetReportWithId(int id);
        


    }
}
