using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ikeepfit.Model;
using ikeepfit.IServices;
using ikeepfit.Services;
using ikeepfit.Repository;
using ikeepfit.IRepository;

namespace ikeepfit.Services
{
    public partial class PlanServices : BaseServices<mt_plan>, IPlanServices
    {
        IPlanRepository dal;
        public PlanServices(IPlanRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }

    }
}
