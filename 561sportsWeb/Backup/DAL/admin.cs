using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace SP.DAL
{
	/// <summary>
	/// 数据访问类:admin
	/// </summary>
	public partial class admin
	{
		public admin()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("aid", "admin"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int aid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from admin");
			strSql.Append(" where aid=@aid");
			SqlParameter[] parameters = {
					new SqlParameter("@aid", SqlDbType.Int,4)
			};
			parameters[0].Value = aid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SP.Model.admin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into admin(");
			strSql.Append("lname,pwd,flag)");
			strSql.Append(" values (");
			strSql.Append("@lname,@pwd,@flag)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@lname", SqlDbType.VarChar,50),
					new SqlParameter("@pwd", SqlDbType.VarChar,100),
					new SqlParameter("@flag", SqlDbType.Int,4)};
			parameters[0].Value = model.lname;
			parameters[1].Value = model.pwd;
			parameters[2].Value = model.flag;

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
		public bool Update(SP.Model.admin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update admin set ");
			strSql.Append("lname=@lname,");
			strSql.Append("pwd=@pwd,");
			strSql.Append("flag=@flag");
			strSql.Append(" where aid=@aid");
			SqlParameter[] parameters = {
					new SqlParameter("@lname", SqlDbType.VarChar,50),
					new SqlParameter("@pwd", SqlDbType.VarChar,100),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@aid", SqlDbType.Int,4)};
			parameters[0].Value = model.lname;
			parameters[1].Value = model.pwd;
			parameters[2].Value = model.flag;
			parameters[3].Value = model.aid;

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
		public bool Delete(int aid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from admin ");
			strSql.Append(" where aid=@aid");
			SqlParameter[] parameters = {
					new SqlParameter("@aid", SqlDbType.Int,4)
			};
			parameters[0].Value = aid;

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
		public bool DeleteList(string aidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from admin ");
			strSql.Append(" where aid in ("+aidlist + ")  ");
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
		public SP.Model.admin GetModel(int aid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 aid,lname,pwd,flag from admin ");
			strSql.Append(" where aid=@aid");
			SqlParameter[] parameters = {
					new SqlParameter("@aid", SqlDbType.Int,4)
			};
			parameters[0].Value = aid;

			SP.Model.admin model=new SP.Model.admin();
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
		public SP.Model.admin DataRowToModel(DataRow row)
		{
			SP.Model.admin model=new SP.Model.admin();
			if (row != null)
			{
				if(row["aid"]!=null && row["aid"].ToString()!="")
				{
					model.aid=int.Parse(row["aid"].ToString());
				}
				if(row["lname"]!=null)
				{
					model.lname=row["lname"].ToString();
				}
				if(row["pwd"]!=null)
				{
					model.pwd=row["pwd"].ToString();
				}
				if(row["flag"]!=null && row["flag"].ToString()!="")
				{
					model.flag=int.Parse(row["flag"].ToString());
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
			strSql.Append("select aid,lname,pwd,flag ");
			strSql.Append(" FROM admin ");
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
			strSql.Append(" aid,lname,pwd,flag ");
			strSql.Append(" FROM admin ");
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
			strSql.Append("select count(1) FROM admin ");
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
				strSql.Append("order by T.aid desc");
			}
			strSql.Append(")AS Row, T.*  from admin T ");
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
			parameters[0].Value = "admin";
			parameters[1].Value = "aid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

