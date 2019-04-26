using System;
using System.Data;
using System.Collections.Generic;

using SP.Model;
namespace SP.BLL
{
    /// <summary>
    /// plansType
    /// </summary>
    public partial class plansType
    {
        private readonly SP.DAL.plansType dal = new SP.DAL.plansType();
        public plansType()
        { }


        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int tid)
        {
            return dal.Exists(tid);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(SP.Model.plansType model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(SP.Model.plansType model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int tid)
        {

            return dal.Delete(tid);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string tidlist)
        {
            return dal.DeleteList(tidlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public SP.Model.plansType GetModel(int tid)
        {

            return dal.GetModel(tid);
        }



        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<SP.Model.plansType> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<SP.Model.plansType> DataTableToList(DataTable dt)
        {
            List<SP.Model.plansType> modelList = new List<SP.Model.plansType>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                SP.Model.plansType model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}





    }
}

