using Microsoft.AspNetCore.Mvc.Rendering;
using NewsProject.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.ViewModels
{
    public class ReportViewModel
    {
        UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());

        public int Id { get; set; }
        public string Title { get; set; }
        public string LongTitle { get; set; }
        public string Content { get; set; }
        public int ReadOfNumber { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
        public string IMageUrl { get; set; }
        public DateTime DateTime { get; set; }
        public string SourceUrl { get; set; }
        public virtual Category Category { get; set; }

    }
}
