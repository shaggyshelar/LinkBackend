
using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Espl.Linkup.Domain.Core
{
    public class BaseSearchResult<IEntity> : IBaseSearchResult<IEntity>
    {
        //public BaseSearchResult()
        //{
        //    Items = new List<IEntity>();
        //}
        public long TotalCount { get; set; }
        public IList<IEntity> Items { get; set; }
    }
}
