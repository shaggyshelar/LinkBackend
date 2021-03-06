﻿using Espl.Linkup.Common.Contacts;
using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.PFs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Users
{
    public interface IUser : IBaseEntity<IUser, IUserSearch>
    {
        #region Properties
        //
        string Name { get; set; }
        DateTime DOB { get; set; }
        string ContactNo { get; set; }
        string CurrentAdd { get; set; }
        string Email { get; set; }
        IPF PF { get; set; }
        DateTime CareerStartDate { get; set; }
        DateTime LastWorkingDayOfPrevEmployer { get; set; }
        IContact Contact { get; set; }
        string BloodGroup { get; set; }
        string SkypeID { get; set; }
        string ProfilePath { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        #endregion Properties
    }
}
