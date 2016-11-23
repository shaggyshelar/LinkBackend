
using Espl.Linkup.Common.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Core
{
    public interface IBaseEntity<IEntity, IEntitySearch>
    {
        long ID { get; set; }
        long? CreatedBy { get; set; }
        DateTime? CreatedOn { get; set; }
        long? UpdatedBy { get; set; }
        DateTime? UpdatedOn { get; set; }
        bool DeleteFlag { get; set; }
        IEmployee employee { get; set; }
        IBaseSearchResult<IEntity> Search(IEntitySearch entitySearch);
        IList<long> Save(IList<IEntity> entities);
        bool Remove(IEntity entity);
        long RemoveAndGetRecordID(IEntity entities);
    }
}
