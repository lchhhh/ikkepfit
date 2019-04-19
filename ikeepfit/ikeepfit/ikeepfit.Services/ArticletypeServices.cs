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
    public partial class ArticletypeServices : BaseServices<mt_articletype>, IArticletypeServices
    {
        IArticletypeRepository dal;
        public ArticletypeServices(IArticletypeRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }

    }
   
  
}
