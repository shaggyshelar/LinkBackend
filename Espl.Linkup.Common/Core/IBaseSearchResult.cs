using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Core
{
    public interface IBaseSearchResult<IEntity>
    {
        long TotalCount { get; set; }
        IList<IEntity> Items { get; set; }
    }
}
