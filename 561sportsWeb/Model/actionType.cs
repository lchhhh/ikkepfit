using System;
namespace SP.Model
{
    /// <summary>
    /// actionType:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class actionType
    {
        public actionType()
        { }
        #region Model
        private int _levid;
        private string _levname;
        /// <summary>
        /// 类别编号
        /// </summary>
        public int levid
        {
            set { _levid = value; }
            get { return _levid; }
        }
        /// <summary>
        /// 类别名称
        /// </summary>
        public string levname
        {
            set { _levname = value; }
            get { return _levname; }
        }
        #endregion Model

    }
}

