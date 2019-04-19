using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ikeepfit.Model;
using ikeepfit.IServices;
using ikeepfit.IRepository;


namespace ikeepfit.Services
{
    public partial class CourseServices : BaseServices<mt_course>, ICourseServices
    {
        ICourseRepository dal;
        public CourseServices(ICourseRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }

    }
}
