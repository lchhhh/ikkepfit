using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SP.DBUtility;//Please add references
namespace SP.DAL
{
    /// <summary>
    /// 数据访问类:actionType
    /// </summary>
    public partial class actionType
    {
        public actionType()
        { }


        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("levid", "actionType");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int levid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from actionType");
            strSql.Append(" where levid=@levid");
            SqlParameter[] parameters = {
					new SqlParameter("@levid", SqlDbType.Int,4)
			};
            parameters[0].Value = levid;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(SP.Model.actionType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into actionType(");
            strSql.Append("levname)");
            strSql.Append(" values (");
            strSql.Append("@levname)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@levname", SqlDbType.VarChar,50)};
            parameters[0].Value = model.levname;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(SP.Model.actionType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update actionType set ");
            strSql.Append("levname=@levname");
            strSql.Append(" where levid=@levid");
            SqlParameter[] parameters = {
					new SqlParameter("@levname", SqlDbType.VarChar,50),
					new SqlParameter("@levid", SqlDbType.Int,4)};
            parameters[0].Value = model.levname;
            parameters[1].Value = model.levid;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(int levid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from actionType ");
            strSql.Append(" where levid=@levid");
            SqlParameter[] parameters = {
					new SqlParameter("@levid", SqlDbType.Int,4)
			};
            parameters[0].Value = levid;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string levidlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from actionType ");
            strSql.Append(" where levid in (" + levidlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public SP.Model.actionType GetModel(int levid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 levid,levname from actionType ");
            strSql.Append(" where levid=@levid");
            SqlParameter[] parameters = {
					new SqlParameter("@levid", SqlDbType.Int,4)
			};
            parameters[0].Value = levid;

            SP.Model.actionType model = new SP.Model.actionType();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public SP.Model.actionType DataRowToModel(DataRow row)
        {
            SP.Model.actionType model = new SP.Model.actionType();
            if (row != null)
            {
                if (row["levid"] != null && row["levid"].ToString() != "")
                {
                    model.levid = int.Parse(row["levid"].ToString());
                }
                if (row["levname"] != null)
                {
                    model.levname = row["levname"].ToString();
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
            strSql.Append("select levid,levname ");
            strSql.Append(" FROM actionType ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" levid,levname ");
            strSql.Append(" FROM actionType ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM actionType ");
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.levid desc");
            }
            strSql.Append(")AS Row, T.*  from actionType T ");
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
            parameters[0].Value = "actionType";
            parameters[1].Value = "levid";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/





    }
}

