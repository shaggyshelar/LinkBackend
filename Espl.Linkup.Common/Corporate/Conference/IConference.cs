using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Corporate.Treatments;
using Espl.Linkup.Common.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Corporate.Conferences
{
    public interface IConference : IBaseEntity<IConference, IConferenceSearch>
    {
        #region Properties
        //
        string Title { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        IList<IEmployee> Attendees { get; set; }
        string Description { get; set; }
        IList<ITreatment> SpecialTreatment { get; set; }
        string SpecialComments { get; set; }
        Int64 NumberOfGuests { get; set; }
        bool IsDeleted { get; set; }
        #endregion Properties
    }
}
