using Espl.Linkup.Common.Users;
using Espl.Linkup.Common.PFs;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Profile.Users
{

    public class User : BaseEntity<IUser, IUserSearch>, IUser
    {

        protected override IBaseDao<IUser, IUserSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IUserDAO>();
            throw new NotImplementedException();
        }



        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string ContactNo { get; set; }
        public string CurrentAdd { get; set; }
        public string Email { get; set; }
        public IPF PF { get; set; }
        public DateTime CareerStartDate { get; set; }
        public DateTime LastWorkingDayOfPrevEmployer { get; set; }
        public string BloodGroup { get; set; }
        public string SkypeID { get; set; }
        public string ProfilePath { get; set; }
        public Common.Contacts.IContact Contact { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
