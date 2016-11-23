using Espl.Linkup.Common.Clients;
using Espl.Linkup.Common.Experience;
using Espl.Linkup.Common.Projects;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Profile.Experience
{

    public class Experience : BaseEntity<IExperience, IExperienceSearch>, IExperience
    {

        protected override IBaseDao<IExperience, IExperienceSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IExperienceDAO>();
            throw new NotImplementedException();
        }

        public IProject Project { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IClient Client { get; set; }
        public string Role { get; set; }
        public string Environment { get; set; }
        public string Duration { get; set; }

        public string Description { get; set; }
        public string Responsibilites { get; set; }

        public bool IsCurrentProject { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public string ExperienceFilePath { get; set; }
    }
}
