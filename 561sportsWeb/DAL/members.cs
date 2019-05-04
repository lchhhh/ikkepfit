using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SP.DBUtility;//Please add references
namespace SP.DAL
{
	/// <summary>
	/// 数据访问类:members
	/// </summary>
	public partial class members
	{
		public members()
		{}
		

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string lname)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from members");
			strSql.Append(" where lname=@lname ");
			SqlParameter[] parameters = {
					new SqlParameter("@lname", SqlDbType.VarChar,50)			};
			parameters[0].Value = lname;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SP.Model.members model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into members(");
			strSql.Append("lname,pass,mname,sex,tel,mpic,regtime)");
			strSql.Append(" values (");
			strSql.Append("@lname,@pass,@mname,@sex,@tel,@mpic,@regtime)");
			SqlParameter[] parameters = {
					new SqlParameter("@lname", SqlDbType.VarChar,50),
					new SqlParameter("@pass", SqlDbType.VarChar,50),
					new SqlParameter("@mname", SqlDbType.VarChar,50),
					new SqlParameter("@sex", SqlDbType.VarChar,20),
					new SqlParameter("@tel", SqlDbType.VarChar,50),
					new SqlParameter("@mpic", SqlDbType.VarChar,50),
					new SqlParameter("@regtime", SqlDbType.DateTime)};
			parameters[0].Value = model.lname;
			parameters[1].Value = model.pass;
			parameters[2].Value = model.mname;
			parameters[3].Value = model.sex;
			parameters[4].Value = model.tel;
			parameters[5].Value = model.mpic;
			parameters[6].Value = model.regtime;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(SP.Model.members model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update members set ");
			strSql.Append("pass=@pass,");
			strSql.Append("mname=@mname,");
			strSql.Append("sex=@sex,");
			strSql.Append("tel=@tel,");
			strSql.Append("mpic=@mpic");
	
			strSql.Append(" where lname=@lname ");
			SqlParameter[] parameters = {
					new SqlParameter("@pass", SqlDbType.VarChar,50),
					new SqlParameter("@mname", SqlDbType.VarChar,50),
					new SqlParameter("@sex", SqlDbType.VarChar,20),
					new SqlParameter("@tel", SqlDbType.VarChar,50),
					new SqlParameter("@mpic", SqlDbType.VarChar,50),
					new SqlParameter("@lname", SqlDbType.VarChar,50)};
			parameters[0].Value = model.pass;
			parameters[1].Value = model.mname;
			parameters[2].Value = model.sex;
			parameters[3].Value = model.tel;
			parameters[4].Value = model.mpic;
			parameters[5].Value = model.lname;

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
		public bool Delete(string lname)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from members ");
			strSql.Append(" where lname=@lname ");
			SqlParameter[] parameters = {
					new SqlParameter("@lname", SqlDbType.VarChar,50)			};
			parameters[0].Value = lname;

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
		public bool DeleteList(string lnamelist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from members ");
			strSql.Append(" where lname in ("+lnamelist + ")  ");
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
		public SP.Model.members GetModel(string lname)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 lname,pass,mname,sex,tel,mpic,regtime from members ");
			strSql.Append(" where lname=@lname ");
			SqlParameter[] parameters = {
					new SqlParameter("@lname", SqlDbType.VarChar,50)			};
			parameters[0].Value = lname;

			SP.Model.members model=new SP.Model.members();
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
		public SP.Model.members DataRowToModel(DataRow row)
		{
			SP.Model.members model=new SP.Model.members();
			if (row != null)
			{
				if(row["lname"]!=null)
				{
					model.lname=row["lname"].ToString();
				}
				if(row["pass"]!=null)
				{
					model.pass=row["pass"].ToString();
				}
				if(row["mname"]!=null)
				{
					model.mname=row["mname"].ToString();
				}
				if(row["sex"]!=null)
				{
					model.sex=row["sex"].ToString();
				}
				if(row["tel"]!=null)
				{
					model.tel=row["tel"].ToString();
				}
				if(row["mpic"]!=null)
				{
					model.mpic=row["mpic"].ToString();
				}
				if(row["regtime"]!=null && row["regtime"].ToString()!="")
				{
					model.regtime=DateTime.Parse(row["regtime"].ToString());
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
			strSql.Append("select lname,pass,mname,sex,tel,mpic,regtime ");
			strSql.Append(" FROM members ");
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
			strSql.Append(" lname,pass,mname,sex,tel,mpic,regtime ");
			strSql.Append(" FROM members ");
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
			strSql.Append("select count(1) FROM members ");
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
				strSql.Append("order by T.lname desc");
			}
			strSql.Append(")AS Row, T.*  from members T ");
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
			parameters[0].Value = "members";
			parameters[1].Value = "lname";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		
		

		
	}
}

