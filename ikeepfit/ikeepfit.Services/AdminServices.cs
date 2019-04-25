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
    public partial class AdminServices : BaseServices<mt_admin>, IAdminServices
    {
        IAdminRepository dal;
        public AdminServices(IAdminRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }

    }
}
