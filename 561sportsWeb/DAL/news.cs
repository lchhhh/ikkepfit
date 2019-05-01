using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SP.DBUtility;//Please add references
namespace SP.DAL
{
	/// <summary>
	/// 数据访问类:news
	/// </summary>
	public partial class news
	{
		public news()
		{}
		

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("nid", "news"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int nid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from news");
			strSql.Append(" where nid=@nid");
			SqlParameter[] parameters = {
					new SqlParameter("@nid", SqlDbType.Int,4)
			};
			parameters[0].Value = nid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SP.Model.news model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into news(");
			strSql.Append("title,tid,bgpic,memo,atime)");
			strSql.Append(" values (");
			strSql.Append("@title,@tid,@bgpic,@memo,@atime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.VarChar,50),
					new SqlParameter("@tid", SqlDbType.Int,4),
                    new SqlParameter("@bgpic", SqlDbType.VarChar,100),
					new SqlParameter("@memo", SqlDbType.NText),
					new SqlParameter("@atime", SqlDbType.DateTime)};
			parameters[0].Value = model.title;
			parameters[1].Value = model.tid;
            parameters[2].Value = model.bgpic;
			parameters[3].Value = model.memo;
			parameters[4].Value = model.atime;

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
		public bool Update(SP.Model.news model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update news set ");
			strSql.Append("title=@title,");
			strSql.Append("tid=@tid,");
            strSql.Append("bgpic=@bgpic,");
			strSql.Append("memo=@memo");
			strSql.Append(" where nid=@nid");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.VarChar,50),
					new SqlParameter("@tid", SqlDbType.Int,4),
                    new SqlParameter("@bgpic", SqlDbType.VarChar,100),
					new SqlParameter("@memo", SqlDbType.NText),
					new SqlParameter("@nid", SqlDbType.Int,4)};
			parameters[0].Value = model.title;
			parameters[1].Value = model.tid;
            parameters[2].Value = model.bgpic;
			parameters[3].Value = model.memo;
			parameters[4].Value = model.nid;

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
		public bool Delete(int nid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from news ");
			strSql.Append(" where nid=@nid");
			SqlParameter[] parameters = {
					new SqlParameter("@nid", SqlDbType.Int,4)
			};
			parameters[0].Value = nid;

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
		public bool DeleteList(string nidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from news ");
			strSql.Append(" where nid in ("+nidlist + ")  ");
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
		public SP.Model.news GetModel(int nid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 nid,title,tid,bgpic,memo,atime from news ");
			strSql.Append(" where nid=@nid");
			SqlParameter[] parameters = {
					new SqlParameter("@nid", SqlDbType.Int,4)
			};
			parameters[0].Value = nid;

			SP.Model.news model=new SP.Model.news();
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
		public SP.Model.news DataRowToModel(DataRow row)
		{
			SP.Model.news model=new SP.Model.news();
			if (row != null)
			{
				if(row["nid"]!=null && row["nid"].ToString()!="")
				{
					model.nid=int.Parse(row["nid"].ToString());
				}
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
				if(row["tid"]!=null && row["tid"].ToString()!="")
				{
					model.tid=int.Parse(row["tid"].ToString());
				}
                if (row["bgpic"] != null)
                {
                    model.bgpic = row["bgpic"].ToString();
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  a.*,b.tname from news a  left join newsType b on a.tid=b.tid ");
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
			strSql.Append(" nid,title,tid,bgpic,memo,atime ");
			strSql.Append(" FROM news ");
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
			strSql.Append("select count(1) FROM news ");
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
				strSql.Append("order by T.nid desc");
			}
			strSql.Append(")AS Row, T.*  from news T ");
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
			parameters[0].Value = "news";
			parameters[1].Value = "nid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		
		

		
	}
}

