using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Core
{
    public interface IBaseSearch
    {
        long ID { get; set; }
        int CurrentPage { get; set; }
        int RecordsPerPage { get; set; }
        string BranchCode { get; set; }
        string SearchString { get; set; }

    }
}
