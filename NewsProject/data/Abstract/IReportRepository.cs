using NewsProject.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.data.Abstract
{
    public interface IReportRepository :IRepository<Report>
    {
        public IEnumerable<Report> GetTopReports();
        public Report GetFirstReport(Category id);
        public IEnumerable<Report> GetAllWithCategory();
        public IEnumerable<Report> GetUptoDateReport();
        public Report GetReportWithId(int id);
        public Report IncreaseReadNumber(int id);
        public IEnumerable<Report> ListWithCategoryId(int Id);
        public IEnumerable<Report> DeleteById(int Id);
        public IEnumerable<Report> UpdateReport(Report model);
        public IEnumerable<Report> CreateReport(Report model);
        public IEnumerable<Category> getAllCategory();




    }
}
