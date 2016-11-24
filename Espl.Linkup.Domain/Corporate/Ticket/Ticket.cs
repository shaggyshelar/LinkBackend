
using Espl.Linkup.Common.Corporate.Ticket;
using Espl.Linkup.Common.Departments;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Corporate.Ticket
{

    public class Ticket : BaseEntity<ITicket, ITicketSearch>,ITicket
    {

        protected override IBaseDao<ITicket, ITicketSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<ITicketDAO>();
            throw new NotImplementedException();
        }

        public IDepartment Department { get; set; }
        public DateTime HolidayDate { get; set; }
        public Enum Priority { get; set; }
        public string Concern { get; set; }
        public string Description { get; set; }
        public Common.Users.IUser ResolvedBy { get; set; }
        public bool Isclosed { get; set; }
        public bool IsReopen { get; set; }
        public string Status { get; set; }
    }
}
