using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SP.DBUtility;//Please add references
namespace SP.DAL
{
	/// <summary>
	/// 数据访问类:plans
	/// </summary>
	public partial class plans
	{
		public plans()
		{}
		

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("pid", "plans"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from plans");
			strSql.Append(" where pid=@pid");
			SqlParameter[] parameters = {
					new SqlParameter("@pid", SqlDbType.Int,4)
			};
			parameters[0].Value = pid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SP.Model.plans model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into plans(");
			strSql.Append("title,tid,memo,atime)");
			strSql.Append(" values (");
			strSql.Append("@title,@tid,@memo,@atime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.VarChar,50),
                    new SqlParameter("@tid", SqlDbType.Int,4),
					new SqlParameter("@memo", SqlDbType.NText),
					new SqlParameter("@atime", SqlDbType.DateTime)};
			parameters[0].Value = model.title;
            parameters[1].Value = model.tid;
			parameters[2].Value = model.memo;
			parameters[3].Value = model.atime;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SP.Model.plans model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update plans set ");
			strSql.Append("title=@title,");
            strSql.Append("tid=@tid,");
			strSql.Append("memo=@memo,");
			strSql.Append("atime=@atime");
			strSql.Append(" where pid=@pid");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.VarChar,50),
                    new SqlParameter("@tid", SqlDbType.Int,4),
					new SqlParameter("@memo", SqlDbType.NText),
					new SqlParameter("@atime", SqlDbType.DateTime),
					new SqlParameter("@pid", SqlDbType.Int,4)};
			parameters[0].Value = model.title;
            parameters[1].Value = model.tid;
			parameters[2].Value = model.memo;
			parameters[3].Value = model.atime;
			parameters[4].Value = model.pid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int pid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from plans ");
			strSql.Append(" where pid=@pid");
			SqlParameter[] parameters = {
					new SqlParameter("@pid", SqlDbType.Int,4)
			};
			parameters[0].Value = pid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string pidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from plans ");
			strSql.Append(" where pid in ("+pidlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SP.Model.plans GetModel(int pid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 pid,title,tid,memo,atime from plans ");
			strSql.Append(" where pid=@pid");
			SqlParameter[] parameters = {
					new SqlParameter("@pid", SqlDbType.Int,4)
			};
			parameters[0].Value = pid;

			SP.Model.plans model=new SP.Model.plans();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SP.Model.plans DataRowToModel(DataRow row)
		{
			SP.Model.plans model=new SP.Model.plans();
			if (row != null)
			{
				if(row["pid"]!=null && row["pid"].ToString()!="")
				{
					model.pid=int.Parse(row["pid"].ToString());
				}
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
                if (row["tid"] != null && row["tid"].ToString() != "")
                {
                    model.tid = int.Parse(row["tid"].ToString());
                }
				if(row["memo"]!=null)
				{
					model.memo=row["memo"].ToString();
				}
				if(row["atime"]!=null && row["atime"].ToString()!="")
				{
					model.atime=DateTime.Parse(row["atime"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  a.*,b.tname from plans a  left join plansType b on a.tid=b.tid ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" pid,title,tid,memo,atime ");
			strSql.Append(" FROM plans ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM plans ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.pid desc");
			}
			strSql.Append(")AS Row, T.*  from plans T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "plans";
			parameters[1].Value = "pid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		
		

		
	}
}

