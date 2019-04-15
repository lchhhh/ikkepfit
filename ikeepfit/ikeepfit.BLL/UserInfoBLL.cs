using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ikeepfit.Model;
using ikeepfit.IDAL;
using ikeepfit.IBLL;
using ikeepfit.DAL;
using ikeepfit.Common;

namespace ikeepfit.BLL
{
    public class UserInfoBLL : IUserInfoBLL
    {
        ikeepfitEF db = new ikeepfitEF();
        IUserInfoRepository rep = new UserInfoRepository();

        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Create(mt_user model)
        {
            if (rep.Create(model) == 1)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 根据id删除实体
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            if (rep.Delete(id) > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 编辑实体
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(mt_user model)
        {
            if (rep.Edit(model) > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 根据id查找实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public mt_user GetById(int id)
        {
            return rep.GetById(id);
        }
        /// <summary>
        /// 实体列表
        /// </summary>
        /// <param name="pager"></param>
        /// <param name="queryStr"></param>
        /// <returns></returns>
        public List<mt_user> GetList()
        {
            IQueryable<mt_user> queryData = rep.GetList(db);
            return queryData.ToList();
        }
        /// <summary>
        /// 判断是否存在实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsExist(int id)
        {
            return rep.IsExist(id);
        }
    }
}
