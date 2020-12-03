﻿using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Report> GetTopReports(int count)
        {
            return _context.Reports.Take(3);
        }
        public IEnumerable<Report> GetUptoDateReport()
        {
            return _context.Reports.Where(x => x.DateTime >= DateTime.Today).ToList();
        }

        public DatabaseContext DataContext { get { return _context as DatabaseContext; } }

    }
}