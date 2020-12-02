using NewsProject.data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject
{
    public interface IUnitOfWork:IDisposable  //işlem bitince otomatik sil
    {
        IReportRepository ReportRepository { get; }


        int Complete();

    }
}
