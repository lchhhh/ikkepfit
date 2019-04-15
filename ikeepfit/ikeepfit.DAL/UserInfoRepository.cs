using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ikeepfit.IDAL;
using ikeepfit.Model;
using System.Data.Entity;
namespace ikeepfit.DAL
{
    public class UserInfoRepository : IUserInfoRepository
    {
        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Create(mt_user entity)
        {
            using (ikeepfitEF db = new ikeepfitEF())
            {
                db.Set<mt_user>().Add(entity);
                return db.SaveChanges();
            }
        }
        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (ikeepfitEF db = new ikeepfitEF())
            {
                mt_user entity = db.mt_user.Find(id);
                db.Set<mt_user>().Remove(entity);
                return db.SaveChanges();
            }
        }
        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Edit(mt_user entity)
        {
            using (ikeepfitEF db = new ikeepfitEF())
            {
                db.Set<mt_user>().Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
        /// <summary>
        /// 获得一个实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns></returns>
        public mt_user GetById(int id)
        {
            using (ikeepfitEF db = new ikeepfitEF())
            {
                return db.mt_user.Find(id);
            }
        }
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public IQueryable<mt_user> GetList(ikeepfitEF db)
        {
            IQueryable<mt_user> list = db.mt_user.AsQueryable();
            return list;
        }
        /// <summary>
        /// 判断一个实体是否存在
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns></returns>
        public bool IsExist(int id)
        {
            using (ikeepfitEF db = new ikeepfitEF())
            {
                mt_user entity = GetById(id);
                if (entity != null)
                    return true;
                return false;
            }
        }
    }
}
