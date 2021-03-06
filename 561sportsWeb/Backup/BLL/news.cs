﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using SP.Model;
namespace SP.BLL
{
	/// <summary>
	/// news
	/// </summary>
	public partial class news
	{
		private readonly SP.DAL.news dal=new SP.DAL.news();
		public news()
		{}
		#region  BasicMethod

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
		public bool Exists(int nid)
		{
			return dal.Exists(nid);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(SP.Model.news model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SP.Model.news model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int nid)
		{
			
			return dal.Delete(nid);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string nidlist )
		{
			return dal.DeleteList(nidlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SP.Model.news GetModel(int nid)
		{
			
			return dal.GetModel(nid);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public SP.Model.news GetModelByCache(int nid)
		{
			
			string CacheKey = "newsModel-" + nid;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(nid);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (SP.Model.news)objModel;
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
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SP.Model.news> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SP.Model.news> DataTableToList(DataTable dt)
		{
			List<SP.Model.news> modelList = new List<SP.Model.news>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				SP.Model.news model;
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
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

