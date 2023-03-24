using ClassLibraryTryitter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tryitter.Data;

namespace Tryitter.Services
{
    public class TeamService:BaseService<Team>,ITeamService
    {
        public TeamService(CrudApiDbContext crudApiDbContext) : base(crudApiDbContext) { }
    }
}
