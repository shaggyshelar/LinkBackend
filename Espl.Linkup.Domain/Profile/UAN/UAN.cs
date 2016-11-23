using Espl.Linkup.Common.UAN;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Profile.UAN
{

    public class UAN : BaseEntity<IUAN, IUANSearch>, IUAN
    {

        protected override IBaseDao<IUAN, IUANSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IUANDAO>();
            throw new NotImplementedException();
        }

        public string Status { get; set; }
        public string Comments { get; set; }
        public string Number { get; set; }
        public bool FromESPL { get; set; }
        public string FilePath { get; set; }
    }
}
