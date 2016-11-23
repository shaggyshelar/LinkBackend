using Espl.Linkup.Common.Clients;
using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Experience
{
    public interface IExperience : IBaseEntity<IExperience, IExperienceSearch>
    {
        #region Properties
        //
        IProject Project { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        IClient Client { get; set; }
        string Role { get; set; }
        string Environment { get; set; }
        string Duration { get; set; }
        bool IsCurrentProject { get; set; }
        string Responsibilites { get; set; }
        string Description { get; set; }
        string Status { get; set; }
        string Comments { get; set; }
        string ExperienceFilePath { get; set; }

        #endregion Properties
    }
}
