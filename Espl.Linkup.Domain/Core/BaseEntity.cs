using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Core
{
    public abstract class BaseEntity<IEntity, IEntitySearch>
        where IEntity : IBaseEntity<IEntity, IEntitySearch>
    {
        public long ID { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }
        public IUser User { get; set; }

        public IBaseSearchResult<IEntity> Search(IEntitySearch branch)
        {
            return GetDAO().Search(branch);
        }

        public IList<long> Save(IList<IEntity> branch)
        {
            return GetDAO().Save(branch);
        }

        public bool Remove(IEntity branch)
        {
            return GetDAO().Remove(branch);
        }

        public long RemoveAndGetRecordID(IEntity branch)
        {
            return GetDAO().RemoveAndGetRecordID(branch);
        }

        protected abstract IBaseDao<IEntity, IEntitySearch> GetDAO();
    }

    //public abstract class BaseEntity : IBaseEntity
    //{
    //    public long ID { get; set; }
    //    public long? CreatedBy { get; set; }
    //    public DateTime? CreatedOn { get; set; }
    //    public long? UpdatedBy { get; set; }
    //    public DateTime? UpdatedOn { get; set; }
    //    public bool DeleteFlag { get; set; }

    //}
}
