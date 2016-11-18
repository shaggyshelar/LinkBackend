
using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Espl.Linkup.Domain.Core
{
    public abstract class BaseSearch : IBaseSearch
    {
        public long ID { get; set; }
        public int CurrentPage { get; set; }
        public int RecordsPerPage { get; set; }
        public string BranchCode { get; set; }
        public string SearchString { get; set; }
        public string SortColName { get; set; }
        public string SortColType { get; set; }

    }
}
