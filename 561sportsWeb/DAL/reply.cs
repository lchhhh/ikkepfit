using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SP.DBUtility;//Please add references
namespace SP.DAL
{
	/// <summary>
	/// 数据访问类:reply
	/// </summary>
	public partial class reply
	{
		public reply()
		{}
		

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("rid", "reply"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int rid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from reply");
			strSql.Append(" where rid=@rid");
			SqlParameter[] parameters = {
					new SqlParameter("@rid", SqlDbType.Int,4)
			};
			parameters[0].Value = rid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SP.Model.reply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into reply(");
            strSql.Append("aid,rmemo,lname,rtime)");
			strSql.Append(" values (");
            strSql.Append("@aid,@rmemo,@lname,@rtime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@aid", SqlDbType.Int,4),
					new SqlParameter("@rmemo", SqlDbType.NText),
					new SqlParameter("@lname", SqlDbType.VarChar,50),
					new SqlParameter("@rtime", SqlDbType.DateTime)};
			parameters[0].Value = model.aid;
            parameters[1].Value = model.rmemo;
			parameters[2].Value = model.lname;
            parameters[3].Value = model.rtime;


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
		public bool Update(SP.Model.reply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update reply set ");
			strSql.Append("aid=@aid,");
            strSql.Append("rmemo=@rmemo,");
			strSql.Append("lname=@lname,");
            strSql.Append("rtime=@rtime");
			strSql.Append(" where rid=@rid");
			SqlParameter[] parameters = {
					new SqlParameter("@aid", SqlDbType.Int,4),
					new SqlParameter("@rmemo", SqlDbType.NText),
					new SqlParameter("@lname", SqlDbType.VarChar,50),
					new SqlParameter("@rtime", SqlDbType.DateTime),
					new SqlParameter("@rid", SqlDbType.Int,4)};
			parameters[0].Value = model.aid;
            parameters[1].Value = model.rmemo;
			parameters[2].Value = model.lname;
            parameters[3].Value = model.rtime;
			parameters[4].Value = model.rid;

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
		public bool Delete(int rid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from reply ");
			strSql.Append(" where rid=@rid");
			SqlParameter[] parameters = {
					new SqlParameter("@rid", SqlDbType.Int,4)
			};
			parameters[0].Value = rid;

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
		public bool DeleteList(string ridlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from reply ");
			strSql.Append(" where rid in ("+ridlist + ")  ");
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
		public SP.Model.reply GetModel(int rid)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 rid,aid,rmemo,lname,rtime from reply ");
			strSql.Append(" where rid=@rid");
			SqlParameter[] parameters = {
					new SqlParameter("@rid", SqlDbType.Int,4)
			};
			parameters[0].Value = rid;

			SP.Model.reply model=new SP.Model.reply();
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
		public SP.Model.reply DataRowToModel(DataRow row)
		{
			SP.Model.reply model=new SP.Model.reply();
			if (row != null)
			{
				if(row["rid"]!=null && row["rid"].ToString()!="")
				{
					model.rid=int.Parse(row["rid"].ToString());
				}
				if(row["aid"]!=null && row["aid"].ToString()!="")
				{
					model.aid=int.Parse(row["aid"].ToString());
				}
                if (row["rmemo"] != null)
				{
                    model.rmemo = row["rmemo"].ToString();
				}
				if(row["lname"]!=null)
				{
					model.lname=row["lname"].ToString();
				}
                if (row["rtime"] != null && row["atime"].ToString() != "")
				{
                    model.rtime = DateTime.Parse(row["atime"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select rid,aid,rmemo,lname,rtime ");
			strSql.Append(" FROM reply ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
            strSql.Append(" rid,aid,rmemo,lname,rtime ");
			strSql.Append(" FROM reply ");
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
			strSql.Append("select count(1) FROM reply ");
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
				strSql.Append("order by T.rid desc");
			}
			strSql.Append(")AS Row, T.*  from reply T ");
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
			parameters[0].Value = "reply";
			parameters[1].Value = "rid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		
		

		
	}
}

