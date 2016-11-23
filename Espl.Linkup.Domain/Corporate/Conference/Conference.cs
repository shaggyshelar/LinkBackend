
using Espl.Linkup.Common.Corporate.Conferences;
using Espl.Linkup.Common.Corporate.Treatments;
using Espl.Linkup.Common.Employee;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Corporate.Conferences
{

    public class Conference : BaseEntity<IConference, IConferenceSearch>,IConference
    {

        protected override IBaseDao<IConference, IConferenceSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IConferenceDAO>();
            throw new NotImplementedException();
        }

        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public IList<IEmployee> Attendees { get; set; }
        public string Description { get; set; }
        public IList<ITreatment> SpecialTreatment { get; set; }
        public string SpecialComments { get; set; }
        public long NumberOfGuests { get; set; }
        public bool IsDeleted { get; set; }


        public bool IsAllDay { get; set; }
        public Common.Corporate.Rooms.IRoom Room { get; set; }
    }
}
