
using Espl.Linkup.Common.Corporate.Treatments;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Corporate.Treatments
{

    public class Treatment : BaseEntity<ITreatment, ITreatmentSearch>,ITreatment
    {

        protected override IBaseDao<ITreatment, ITreatmentSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<ITreatmentDAO>();
            throw new NotImplementedException();
        }



        public string TreatmentName { get; set; }
    }
}
