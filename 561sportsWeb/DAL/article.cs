using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SP.DBUtility;//Please add references
namespace SP.DAL
{
	/// <summary>
	/// 数据访问类:article
	/// </summary>
	public partial class article
	{
		public article()
		{}
		

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("aid", "article"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int aid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from article");
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
		public int Add(SP.Model.article model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into article(");
			strSql.Append("title,memo,total1,lname,pic,atime)");
			strSql.Append(" values (");
			strSql.Append("@title,@memo,@total1,@lname,@pic,@atime)");
			strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.VarChar,100),
					new SqlParameter("@memo", SqlDbType.NText),
					new SqlParameter("@total1", SqlDbType.Int,4),
					new SqlParameter("@lname", SqlDbType.VarChar,20),
                    new SqlParameter("@pic", SqlDbType.VarChar,100),
					new SqlParameter("@atime", SqlDbType.DateTime)};
			parameters[0].Value = model.title;
			parameters[1].Value = model.memo;
			parameters[2].Value = model.total1;
			parameters[3].Value = model.lname;
            parameters[4].Value = model.pic;
			parameters[5].Value = model.atime;

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
		public bool Update(SP.Model.article model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update article set ");		
			strSql.Append("total1=total1+1");			
			strSql.Append(" where aid=@aid");
			SqlParameter[] parameters = {
			
					new SqlParameter("@aid", SqlDbType.Int,4)};
	
			parameters[0].Value = model.aid;

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
			strSql.Append("delete from article ");
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
			strSql.Append("delete from article ");
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
		public SP.Model.article GetModel(int aid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 aid,title,memo,total1,lname,pic,atime from article ");
			strSql.Append(" where aid=@aid");
			SqlParameter[] parameters = {
					new SqlParameter("@aid", SqlDbType.Int,4)
			};
			parameters[0].Value = aid;

			SP.Model.article model=new SP.Model.article();
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
		public SP.Model.article DataRowToModel(DataRow row)
		{
			SP.Model.article model=new SP.Model.article();
			if (row != null)
			{
				if(row["aid"]!=null && row["aid"].ToString()!="")
				{
					model.aid=int.Parse(row["aid"].ToString());
				}
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
				if(row["memo"]!=null)
				{
					model.memo=row["memo"].ToString();
				}
				if(row["total1"]!=null && row["total1"].ToString()!="")
				{
					model.total1=int.Parse(row["total1"].ToString());
				}
				if(row["lname"]!=null)
				{
					model.lname=row["lname"].ToString();
				}
                if (row["pic"] != null)
                {
                    model.pic = row["pic"].ToString();
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
			strSql.Append("select aid,title,memo,total1,lname,pic,atime");
			strSql.Append(" FROM article ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList2(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select a.*,isnull(tt,0) as tt  from  article a   left join(    select aid,count(*) as tt from reply  group by aid ) b on a.aid=b.aid ");
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
			strSql.Append(" aid,title,memo,total1,lname,pic,atime ");
			strSql.Append(" FROM article ");
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
			strSql.Append("select count(1) FROM article ");
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
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount2(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM BBS ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
			strSql.Append(")AS Row, T.*  from bbsWZ T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage2(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.aid desc");
            }
            strSql.Append(")AS Row, T.*  from BBS T ");
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
			parameters[0].Value = "article";
			parameters[1].Value = "aid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/





    }
}

