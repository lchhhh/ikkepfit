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
    public class PlanInfoRepository : IPlanInfoRepository
    {
        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Create(mt_plan entity)
        {
            using (ikeepfitEntities db = new ikeepfitEntities())
            {
                db.Set<mt_plan>().Add(entity);
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
            using (ikeepfitEntities db = new ikeepfitEntities())
            {
                mt_plan entity = db.mt_plan.Find(id);
                db.Set<mt_plan>().Remove(entity);
                return db.SaveChanges();
            }
        }
        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Edit(mt_plan entity)
        {
            using (ikeepfitEntities db = new ikeepfitEntities())
            {
                db.Set<mt_plan>().Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
        /// <summary>
        /// 获得一个实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns></returns>
        public mt_plan GetById(int id)
        {
            using (ikeepfitEntities db = new ikeepfitEntities())
            {
                return db.mt_plan.Find(id);
            }
        }
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public IQueryable<mt_plan> GetList(ikeepfitEntities db)
        {
            IQueryable<mt_plan> list = db.mt_plan.AsQueryable();
            return list;
        }
        /// <summary>
        /// 判断一个实体是否存在
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns></returns>
        public bool IsExist(int id)
        {
            using (ikeepfitEntities db = new ikeepfitEntities())
            {
                mt_plan entity = GetById(id);
                if (entity != null)
                    return true;
                return false;
            }
        }
    }
}
